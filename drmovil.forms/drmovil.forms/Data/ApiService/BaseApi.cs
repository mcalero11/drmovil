﻿using drmovil.forms.Data.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static drmovil.forms.Data.Constants.Constants;

namespace drmovil.forms.Data.ApiService
{
    public class BaseApi
    {
        protected HttpClient _client = null;

        public BaseApi(string baseUrl = BaseURL, string version = nameof(Entities.Helpers.ApiVersion.V1), string prefix = "")
        {
            _client = new HttpClient();
            _client.DefaultRequestHeaders.Add("If-Modified-Since", DateTime.UtcNow.ToString("r")); //Disable caching

            _client.DefaultRequestHeaders
                             .Accept
                             .Add(new MediaTypeWithQualityHeaderValue("application/json"));

            

            _client.BaseAddress = new Uri($"{baseUrl}/{prefix}/{version}");
        }


        public async Task<Result<TOutbound>> Put<TInbound, TOutbound>(TInbound data, string id, String controller)
        {

            var content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");

            var result = await _client.PutAsync(controller + "/" + id, content);

            if (result.IsSuccessStatusCode)
            {
                return new Result<TOutbound>()
                {
                    Success = true,
                    Value = JsonConvert.DeserializeObject<TOutbound>(await result.Content.ReadAsStringAsync())
                };
            }
            else
            {
                var error = new Result<TOutbound>()
                {
                    Error = result.StatusCode.ToString(),
                    Message = result.ReasonPhrase,
                    Success = false
                };

                return error;
            }

        }


        public async Task<Result<TOutbound>> Post<TInbound, TOutbound>(TInbound data, String controller)
        {

            var content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");

            var result = await _client.PostAsync(controller, content);

            if (result.IsSuccessStatusCode)
            {
                return new Result<TOutbound>()
                {
                    Success = true,
                    Value = JsonConvert.DeserializeObject<TOutbound>(await result.Content.ReadAsStringAsync())
                };
            }
            else
            {
                var error = new Result<TOutbound>()
                {
                    Error = result.StatusCode.ToString(),
                    Message = result.ReasonPhrase,
                    Success = false
                };

                return error;
            }

        }

        public async Task<Result<IList<TOutbound>>> GetList<TOutbound>(String controller, IDictionary<String, String> parameters = null)
        {

            HttpResponseMessage result = null;

            if (parameters == null)
                result = await _client.GetAsync(controller);
            else
                result = await _client.GetAsync(controller + "/" + parameters.ToQueryString());

            if (result.IsSuccessStatusCode)
            {
                return new Result<IList<TOutbound>>()
                {
                    Success = true,
                    Value = JsonConvert.DeserializeObject<IList<TOutbound>>(await result.Content.ReadAsStringAsync())
                };
            }
            else
            {
                var error = new Result<IList<TOutbound>>()
                {
                    Error = result.StatusCode.ToString(),
                    Message = result.ReasonPhrase,
                    Success = false
                };

                return error;
            }
        }


        public async Task<Result<TOutbound>> Get<TOutbound>(String id, String controller, IDictionary<String, String> parameters = null)
        {
            HttpResponseMessage result = null;

            if (parameters == null)
                result = await _client.GetAsync(controller + "/" + id);
            else
                result = await _client.GetAsync(controller + "/" + id + parameters.ToQueryString());


            if (result.IsSuccessStatusCode)
            {
                return new Result<TOutbound>()
                {
                    Success = true,
                    Value = JsonConvert.DeserializeObject<TOutbound>(await result.Content.ReadAsStringAsync())
                };
            }
            else
            {
                var error = new Result<TOutbound>()
                {
                    Error = result.StatusCode.ToString(),
                    Message = result.ReasonPhrase,
                    Success = false
                };

                return error;
            }
        }

        public async Task<Result<TOutbound>> Delete<TOutbound>(string id, String controller, IDictionary<String, String> parameters = null)
        {
            HttpResponseMessage result = null;

            if (parameters == null)
                result = await _client.DeleteAsync(controller + "/" + id.ToString());
            else
                result = await _client.DeleteAsync(controller + "/" + id.ToString() + parameters.ToQueryString());


            if (result.IsSuccessStatusCode)
            {
                return new Result<TOutbound>()
                {
                    Success = true //No Content
                };
            }
            else
            {
                var error = new Result<TOutbound>()
                {
                    Error = result.StatusCode.ToString(),
                    Message = result.ReasonPhrase,
                    Success = false
                };

                return error;
            }
        }

        public void InjectAuthorizationHeader(string token)
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }

    }
}

