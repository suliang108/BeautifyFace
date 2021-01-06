using Seagull.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seagull.BeautifyFace.Utils
{
    public class Encrytor
    {
        public static void Check()
        {
            var status = RegisterHelper.InitRegedit();
            switch (status)
            {
                case Services.Models.ERegisterStatus.Normal:
                    Application.Run(new FrmMain());
                    break;
                case Services.Models.ERegisterStatus.NotRegister:
                    MessageBox.Show("软件尚未注册，请注册软件！");
                    break;
                case Services.Models.ERegisterStatus.RegisterCodeError:
                    MessageBox.Show("注册机器与本机不一致,请联系管理员！");
                    break;
                case Services.Models.ERegisterStatus.Expired:
                    MessageBox.Show("软件试用已到期！");
                    break;
                case Services.Models.ERegisterStatus.RunningError:
                    MessageBox.Show("软件运行出错，请重新启动！");
                    break;
            }
        }
    }
}
