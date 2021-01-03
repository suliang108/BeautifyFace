using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seagull.Services
{
    public class ImageHelper
    {
        public static Image ReadImage(string filePath)
        {
            try
            {
                Image img = Image.FromFile(filePath);
                return img;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        /// <summary>
        /// 编码
        /// </summary>
        /// <param name="strImgBase64"></param>
        /// <param name="imgFilePath"></param>
        /// <returns></returns>
        public static Image SaveImage(string strImgBase64, string imgFilePath)
        {
            System.Drawing.Bitmap bmp2 = null;
            byte[] arr2 = Convert.FromBase64String(strImgBase64);
            using (MemoryStream ms2 = new MemoryStream(arr2))
            {
                bmp2 = new System.Drawing.Bitmap(ms2);
                bmp2.Save(imgFilePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                //bmp2.Save(filePath + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                //bmp2.Save(filePath + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                //bmp2.Save(filePath + ".gif", System.Drawing.Imaging.ImageFormat.Gif);
                //bmp2.Save(filePath + ".png", System.Drawing.Imaging.ImageFormat.Png);
                bmp2.Dispose();
            }
            return bmp2;
        }

        /// <summary>
        /// 解码
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        public static string GetBase64String(Bitmap image)
        {
            string UserPhoto = "";
            using (MemoryStream ms1 = new MemoryStream())
            {
                image.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] arr1 = new byte[ms1.Length];
                ms1.Position = 0;
                ms1.Read(arr1, 0, (int)ms1.Length);
                ms1.Close();
                UserPhoto = Convert.ToBase64String(arr1);
            }
            return UserPhoto;
        }
    }
}
