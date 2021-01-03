using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seagull.Services
{
    public class JsonHelper
    {
        public static T ConvertTo<T>(string jsonResult)
        {
            try
            {
                var req = JsonConvert.DeserializeObject<T>(jsonResult);
                return req;
            }
            catch (Exception ex)
            {
                return default(T);
            }
        }
    }
}
