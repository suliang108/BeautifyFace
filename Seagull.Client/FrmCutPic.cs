using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seagull.Client
{
    public partial class FrmCutPic : Form
    {
        public FrmCutPic()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            Point[] p = {
                            new Point(424,244),
                            new Point(240,440),
                            new Point(340,552),
                            new Point(550,526),
                            new Point(478,366),
                            new Point(348,660),
                            new Point(424,244)
                        };
            path.AddLines(p);
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = @"Bitmap文件(*.bmp)|*.bmp|Jpeg文件(*.jpg)|*.jpg|所有合适文件(*.bmp,*.jpg)|*.bmp;*.jpg";

            openFileDialog.FilterIndex = 3;

            openFileDialog.RestoreDirectory = true;

            if (DialogResult.OK == openFileDialog.ShowDialog())
            {

                Bitmap bit = (Bitmap)Bitmap.FromFile(openFileDialog.FileName, false);

                Bitmap newBit = null;
                BitmapCrop(bit, path, out newBit);
                newBit.Save(@"C:\Users\Public\Pictures\Sample Pictures\沙漠22.jpg");
            }
        }

        /// <summary>
        /// 图片截图
        /// </summary>
        /// <param name="bitmap">原图</param>
        /// <param name="path">裁剪路径</param>
        /// <param name="outputBitmap">输出图</param>
        /// <returns></returns>
        public static Bitmap BitmapCrop(Bitmap bitmap, GraphicsPath path, out Bitmap outputBitmap)
        {
            RectangleF rect = path.GetBounds();
            int left = (int)rect.Left;
            int top = (int)rect.Top;
            int width = (int)rect.Width;
            int height = (int)rect.Height;
            Bitmap image = (Bitmap)bitmap.Clone();
            outputBitmap = new Bitmap(width, height);
            for (int i = left; i < left + width; i++)
            {
                for (int j = top; j < top + height; j++)
                {
                    //判断坐标是否在路径中   
                    if (path.IsVisible(i, j))
                    {
                        //复制原图区域的像素到输出图片   
                        outputBitmap.SetPixel(i - left, j - top, image.GetPixel(i, j));
                        //设置原图这部分区域为透明   
                        image.SetPixel(i, j, Color.FromArgb(0, image.GetPixel(i, j)));
                    }
                    else
                    {
                        outputBitmap.SetPixel(i - left, j - top, Color.FromArgb(0, 255, 255, 255));
                    }
                }
            }
            bitmap.Dispose();
            return image;
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    var dlg = new OpenFileDialog();

        //}

        private void button2_Click(object sender, EventArgs e)
        {
            //初始化openFileDialog
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择要上传的图片";
            ofd.Filter = "图像文件(*.jpg;*.gif;*.png)|*.jpg;*.gif;*.png";
            ofd.Multiselect = false;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string oldFilePath = ofd.FileName;
                int position = oldFilePath.LastIndexOf("\\");
                string OldfileName = oldFilePath.Substring(position + 1);
                string[] splitName = oldFilePath.Split('.');
                string ext = splitName[splitName.Length - 1];

                string newName = DateTime.Now.ToString("yyyyMMddhhmmss") + "." + ext;

                //判断根目录下是否含有指定文件夹，若没有则创建一个新的
                string path = AppDomain.CurrentDomain.BaseDirectory + "/Images";
                DirectoryInfo di = new DirectoryInfo(path);
                if (!di.Exists)
                {
                    di.Create();
                }
                string newFilePath = AppDomain.CurrentDomain.BaseDirectory + "/Images" + newName;

                File.Copy(oldFilePath, newFilePath, true);
                Image img = Image.FromFile(newFilePath);
                pictureBox1.Image = img;
            }
        }
    }
}
