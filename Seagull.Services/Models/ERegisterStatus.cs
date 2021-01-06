using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seagull.Services.Models
{
    public enum ERegisterStatus
    {
        /// <summary>
        /// 正常
        /// </summary>
        Normal = 0,

        /// <summary>
        /// 软件尚未注册，请注册软件！
        /// </summary>
        NotRegister = 1,

        /// <summary>
        /// 注册机器与本机不一致,请联系管理员！
        /// </summary>
        RegisterCodeError = 2,

        /// <summary>
        /// 软件试用已到期！
        /// </summary>
        Expired = 3,

        /// <summary>
        /// 软件运行出错，请重新启动！
        /// </summary>
        RunningError = 4
    }
}
