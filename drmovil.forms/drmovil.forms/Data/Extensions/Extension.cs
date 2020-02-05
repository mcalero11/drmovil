using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace drmovil.forms.Data.Extensions
{
    public static partial class Extension
    {

        public static string ToQueryString(this IDictionary<string, string> dictionary)
        {
            return '?' + string.Join("&", dictionary.Select(p => p.Key + '=' + Uri.EscapeUriString(p.Value)).ToArray());
        }

        public static async void SafeFireAndForget(this Task task,
                                                   bool returnToCallingContext,
                                                   Action<Exception> onException = null)
        {
            try
            {
                await task.ConfigureAwait(returnToCallingContext);
            }

            catch (Exception ex) when (onException != null)
            {
                onException(ex);
            }
        }
    }
}
