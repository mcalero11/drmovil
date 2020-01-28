using System;
using System.Collections.Generic;
using System.Text;

namespace drmovil.forms.Data.Extensions
{
    public static partial class Extension
    {

        public static string ToQueryString(this IDictionary<string, string> dictionary)
        {
            return '?' + string.Join("&", dictionary.Select(p => p.Key + '=' + Uri.EscapeUriString(p.Value)).ToArray());
        }

    }
}
