using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seagull.Services
{
    public class FaceRequster : BaseFaceRequster
    {
        /// <summary>
        /// 融合后的图片，jpg 格式。base64 编码的二进制图片数据。图片尺寸大小与模板图一致。
        /// </summary>
        public string result { get; set; }

        /// <summary>
        /// 当发生错误时才返回。
        /// </summary>
        public string error_message { get; set; }

    }
}
