using AForge.Video.DirectShow;
using Seagull.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seagull.BeautifyFace
{
    public partial class FrmMain : Sunny.UI.UIForm
    {
        private FilterInfoCollection videoDevices;//所有摄像设备
        private VideoCaptureDevice videoDevice;//摄像设备
        private VideoCapabilities[] videoCapabilities;//摄像头分辨率

        public FrmMain()
        {
            InitializeComponent();
            this.FormClosing += FrmMain_FormClosing;
        }

        private void SetTitle()
        {
            this.tpCenter.Text = "我的主页";
            //this.tabPage2.Text = "我的配置";
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            SetForm();
            SetTitle();
            InitDevices();
            ClearTempFile();
        }

        private void ClearTempFile()
        {
            if (Directory.Exists(SystemConfig.GetTempPath()))
            {
                Directory.Delete(SystemConfig.GetTempPath(), true);
            }
        }

        private void btnStartVideo_Click(object sender, EventArgs e)
        {
            if (videoDevice != null)//如果摄像头不为空
            {
                if ((videoCapabilities != null) && (videoCapabilities.Length != 0))
                {
                    videoDevice.VideoResolution = videoCapabilities[cboResolution.SelectedIndex];//摄像头分辨率
                    vispShoot.VideoSource = videoDevice;//把摄像头赋给控件
                    vispShoot.Start();//开启摄像头
                    EnableControlStatus(false);
                }
            }
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            DisConnect();//断开连接
            EnableControlStatus(true);
        }

        //关闭并释放
        private void DisConnect()
        {
            if (vispShoot.VideoSource != null)
            {
                vispShoot.SignalToStop();
                vispShoot.WaitForStop();
                vispShoot.VideoSource = null;
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Sunny.UI.UIMessageBox.ShowAsk("您确定退出系统吗？"))
            {
                e.Cancel = true;
                return;
            }
            DisConnect();//关闭并释放
            e.Cancel = false;
        }

        private void btnPic_Click(object sender, EventArgs e)
        {
            Bitmap img = vispShoot.GetCurrentVideoFrame();//拍照
            var fileName = SystemConfig.GetTempPath() + "\\" + DateTime.Now.ToString("HHmmssfff") + ".jpg";
            img.Save(fileName);
            pbMe.Tag = fileName;
            pbMe.Image = img;
            //这里可以根据情况，把照片存到某个路径下
            //img.Save("");
        }

        //控件的显示切换
        private void EnableControlStatus(bool status)
        {
            cboVideo.Enabled = status;
            cboResolution.Enabled = status;
            btnConnect.Enabled = status;
            btnPic.Enabled = !status;
            btnCut.Enabled = !status;
        }

        private void InitDevices()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);//得到机器所有接入的摄像设备
            if (videoDevices.Count != 0)
            {
                foreach (FilterInfo device in videoDevices)
                {
                    cboVideo.Items.Add(device.Name);//把摄像设备添加到摄像列表中
                }
            }
            else
            {
                cboVideo.Items.Add("没有找到摄像头");
            }
            cboVideo.SelectedIndex = 0;//默认选择第一个
        }

        private void cboVideo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (videoDevices.Count != 0)
            {
                //获取摄像头
                videoDevice = new VideoCaptureDevice(videoDevices[cboVideo.SelectedIndex].MonikerString);
                GetDeviceResolution(videoDevice);//获得摄像头的分辨率
            }
        }

        //获得摄像头的分辨率
        private void GetDeviceResolution(VideoCaptureDevice videoCaptureDevice)
        {
            cboResolution.Items.Clear();//清空列表
            videoCapabilities = videoCaptureDevice.VideoCapabilities;//设备的摄像头分辨率数组
            foreach (VideoCapabilities capabilty in videoCapabilities)
            {
                //把这个设备的所有分辨率添加到列表
                cboResolution.Items.Add($"{capabilty.FrameSize.Width} x {capabilty.FrameSize.Height}");
            }
            cboResolution.SelectedIndex = 0;//默认选择第一个
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            txtMsg.Text = string.Empty;
            var dlg = new OpenFileDialog();
            //dlg.Filter = "*.jpg|*.png|*.bmp";
            dlg.DefaultExt = "*.jpg|*.png|*.bmp";
            if (dlg.ShowDialog() != DialogResult.OK)
                return;
            pbBeforeMerge.Tag = dlg.FileName;
            pbBeforeMerge.Image = ImageHelper.ReadImage(dlg.FileName);
        }

        private void SetForm()
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {

            var mainImageFilePath = @"C:\Users\Administrator\Desktop\temp\图片\002.jpg";
            var mergeImageFilePath = @"C:\Users\Administrator\Desktop\temp\图片\靓女.jpg";

            if (!IsHasPictures())
                return;
            mainImageFilePath = (string)pbMe.Tag;
            mergeImageFilePath = (string)pbBeforeMerge.Tag;

            var afterFilePath = SystemConfig.GetTempPath() + "\\" + DateTime.Now.ToString("HHmmssff") + ".jpg";

            var requester = new HttpRequster();
            var result = requester.PostSend(mainImageFilePath, mergeImageFilePath);

            var faceReq = JsonHelper.ConvertTo<FaceRequster>(result);
            if (faceReq == null || string.IsNullOrEmpty(faceReq.result))
            {
                txtMsg.Text = result;
                return;
            }
            ImageHelper.SaveImage(faceReq.result, afterFilePath);
            pbAfterMerge.Tag = afterFilePath;
            pbAfterMerge.Image = ImageHelper.ReadImage(afterFilePath);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            //var dlg = new SaveFileDialog();
            //dlg.Filter = "jpg(*.jpg)|*.jpg|png(*.png)|*.png";
            //dlg.DefaultExt = "jpg";
            //dlg.FileName = DateTime.Now.ToString("HHmmssff");
            //if (dlg.ShowDialog() != DialogResult.OK)
            //    return;
            try
            {
                var fileName = (string)pbAfterMerge.Tag;
                if (string.IsNullOrEmpty(fileName))
                {
                    Sunny.UI.UIMessageBox.Show("您尚未融合靓图，需[启动摄像头->拍照->上传融合->确认融合->再导出即可]^_^");
                    return;
                }
                Process.Start(fileName);
            }
            catch (Exception ex)
            {
            
            }
        }

        private void btnActivite_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 检查是否拍照到主图
        /// </summary>
        /// <returns></returns>
        private bool IsHasPictures()
        {
            var mainImageFilePath = (string)pbMe.Tag;
            if (string.IsNullOrEmpty(mainImageFilePath))
            {
                Sunny.UI.UIMessageBox.Show("需先[启动摄像头]->[拍照] 生成主图哦^_^");
                return false;
            }
            var mergeImageFilePath = (string)pbBeforeMerge.Tag;
            if (string.IsNullOrEmpty(mergeImageFilePath))
            {
                Sunny.UI.UIMessageBox.Show("需再[上传融合图]噢，然后[确认融合]即可^_^");
                return false;
            }
            return true;
        }
    }
}
