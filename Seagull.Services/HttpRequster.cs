using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Seagull.Services
{
    public class HttpRequster
    {
        /// <summary>
        /// 调用三方接口实现图片合成
        /// </summary>
        /// <param name="tempurl">人脸融合的模板图</param>
        /// <param name="mergeurl">人脸融合的融合图</param>
        [HttpPost]
        public string PostSend(string tempImg, string mergeImg)
        {
            try
            {
                //用来存储接口参数值
                //Dictionary<string, object> verifyPostParameters = new Dictionary<string, object>();

                Dictionary<string, object> verifyPostParameters = InitParams();

                //var key = "JJ78KFXevml97OheVMKfzoanEJQsmzfb";//注册后得到的key
                //var secret = "CBXHrGC7FcmR2YwUesVn4BS9M3cFBpPw";//注册后得到的secret

                //var key = "Fa-KvgBUsg0ZV7STCfAFOw7RWTn1FccB";//注册后得到的key
                //var secret = "yVnDEgWQu3cam6yGQ2abOleJdevV0I0d";//注册后得到的secret

                ////接口必须参数一
                //verifyPostParameters.Add("api_key", key);
                ////接口必须参数二
                //verifyPostParameters.Add("api_secret", secret);
                //（模板图）
                Bitmap bmp = new Bitmap(tempImg); // 图片地址
                byte[] fileImage;
                using (Stream stream1 = new MemoryStream())
                {
                    bmp.Save(stream1, ImageFormat.Jpeg);
                    byte[] arr = new byte[stream1.Length];
                    stream1.Position = 0;
                    stream1.Read(arr, 0, (int)stream1.Length);
                    stream1.Close();
                    fileImage = arr;
                }
                //接口必须参数三 模板图的路径地址，必须以post multipart/form-data 的方式上传(此处通过调用HTTPHelper4MultipartForm的方法已实现)
                verifyPostParameters.Add("template_file", new HttpHelper4MultipartForm.FileParameter(fileImage, "1.jpg", "application/octet-stream"));
                //接口可选参数 脸部坐标位置
                //verifyPostParameters.Add("template_rectangle", "415,225,402,402");
                //（融合图）
                Bitmap bmp2 = new Bitmap(mergeImg); // 图片地址
                byte[] fileImage2;
                using (Stream stream2 = new MemoryStream())
                {
                    bmp2.Save(stream2, ImageFormat.Jpeg);
                    byte[] arr2 = new byte[stream2.Length];
                    stream2.Position = 0;
                    stream2.Read(arr2, 0, (int)stream2.Length);
                    stream2.Close();
                    fileImage2 = arr2;
                }
                //接口必须参数四 融合图的路径地址，必须以post multipart/form-data 的方式上传(此处通过调用HTTPHelper4MultipartForm的方法已实现)
                verifyPostParameters.Add("merge_file", new HttpHelper4MultipartForm.FileParameter(fileImage2, "2.jpg", "application/octet-stream"));
                //调用HttpHelper4MultipartForm的MultipartFormDataPost方法实现post提交并反馈第三方提供的返回结果
                HttpWebResponse verifyResponse = HttpHelper4MultipartForm.MultipartFormDataPost("https://api-cn.faceplusplus.com/imagepp/v1/mergeface", "", verifyPostParameters);

                //此处获取反馈的流来读取json格式的字符串，因为图片的字符串非常的“大”，必须循环获取，此操作在HttpHelper4MultipartForm类的MultipartFormDataPost方法中已经实现，所以在调用反馈的字符串是这个地方只需将它全部读取。
                var res = verifyResponse.GetResponseStream();
                StreamReader sr = new StreamReader(res, Encoding.ASCII);
                string reslut = sr.ReadToEnd();
                sr.Close();
                res.Close();
                verifyResponse.Close();
                return reslut;
            }
            catch (WebException ex)
            {

                HttpWebResponse res = (HttpWebResponse)ex.Response;
                Stream myResponseStream = res.GetResponseStream();
                StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.Default);
                string retString = myStreamReader.ReadToEnd();
                return retString;
            }
        }

        private Dictionary<string, object> InitParams()
        { 
            var verifyPostParameters = new Dictionary<string, object>();

            var key = "Fa-KvgBUsg0ZV7STCfAFOw7RWTn1FccB";//注册后得到的key
            var secret = "yVnDEgWQu3cam6yGQ2abOleJdevV0I0d";//注册后得到的secret

            //接口必须参数一
            verifyPostParameters.Add("api_key", key);
            //接口必须参数二
            verifyPostParameters.Add("api_secret", secret);
            /*
             融合比例，范围 [0,100]。数字越大融合结果包含越多融合图 (merge_url, merge_file, merge_base64 代表图片) 特征。
             默认值为50
             */
            verifyPostParameters.Add("merge_rate", 50);
            /*
             五官融合比例，范围 [0,100]。主要调节融合结果图中人像五官相对位置，数字越小融合图 (merge_url, merge_file, merge_base64 代表图片)中人像五官相对更集中 。
             默认值为45
             */
            verifyPostParameters.Add("feature_rate", 45);

            return verifyPostParameters;
        }
    }
}
