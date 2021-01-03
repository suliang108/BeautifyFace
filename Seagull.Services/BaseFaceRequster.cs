using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seagull.Services
{
    public class BaseFaceRequster
    {
        /// <summary>
        /// 整个请求所花费的时间，单位为毫秒
        /// </summary>
        public int time_used { get; set; }

        /// <summary>
        /// 用于区分每一次请求的唯一的字符串
        /// </summary>
        public string request_id { get; set; }
    }
}
