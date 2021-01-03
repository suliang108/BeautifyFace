using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seagull.Services
{
    class PictureMerger
    {

        public Bitmap MergePictrue()
        {
            //模板图
            //var tempImg = Server.MapPath(@"~\Image\Template\1.jpg");
            var tempImg = System.AppDomain.CurrentDomain.BaseDirectory + @"\Image\Template\1.jpg";
            //融合图
            var mergeImg = System.AppDomain.CurrentDomain.BaseDirectory + "\\" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg";
            //调用三方接口生成字符串
            string postset = new HttpRequster().PostSend(tempImg, mergeImg);
            //将得到的json格式字符串转换得到图片字符串
            JObject read = JsonConvert.DeserializeObject<JObject>(postset);
            string resul = read["result"].ToString();//图片字符串
            string err = read["error_message"].ToString();//错误信息
            string id = read["request_id"].ToString();//所用时间
            Bitmap Phon = ToImage(resul);//生成的图片
            return Phon;
        }
        /// <summary>
        /// 将Base64字符串转换为图片
        /// </summary>
        /// <param name="base64">base64格式图片字符串</param>
        private Bitmap ToImage(string base64)
        {
            try
            {
                byte[] bytes = Convert.FromBase64String(base64);
                MemoryStream ms = new MemoryStream();
                ms.Write(bytes, 0, bytes.Length);
                Bitmap bmp = new Bitmap(ms);
                return bmp;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
