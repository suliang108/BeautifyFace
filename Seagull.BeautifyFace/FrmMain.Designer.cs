namespace Seagull.BeautifyFace
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.uiTabControlMenu1 = new Sunny.UI.UITabControlMenu();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnUpload = new Sunny.UI.UIButton();
            this.pbBeforeMerge = new AForge.Controls.PictureBox();
            this.pbMe = new AForge.Controls.PictureBox();
            this.cboResolution = new Sunny.UI.UIComboBox();
            this.cboVideo = new Sunny.UI.UIComboBox();
            this.btnPic = new Sunny.UI.UIButton();
            this.btnCut = new Sunny.UI.UIButton();
            this.btnConnect = new Sunny.UI.UIButton();
            this.vispShoot = new AForge.Controls.VideoSourcePlayer();
            this.pbAfterMerge = new AForge.Controls.PictureBox();
            this.btnMerge = new Sunny.UI.UIButton();
            this.txtMsg = new Sunny.UI.UITextBox();
            this.btnExport = new Sunny.UI.UIButton();
            this.uiTabControlMenu1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBeforeMerge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAfterMerge)).BeginInit();
            this.SuspendLayout();
            // 
            // uiTabControlMenu1
            // 
            this.uiTabControlMenu1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.uiTabControlMenu1.Controls.Add(this.tabPage1);
            this.uiTabControlMenu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTabControlMenu1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControlMenu1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiTabControlMenu1.ItemSize = new System.Drawing.Size(40, 200);
            this.uiTabControlMenu1.Location = new System.Drawing.Point(0, 35);
            this.uiTabControlMenu1.Multiline = true;
            this.uiTabControlMenu1.Name = "uiTabControlMenu1";
            this.uiTabControlMenu1.SelectedIndex = 0;
            this.uiTabControlMenu1.Size = new System.Drawing.Size(1289, 633);
            this.uiTabControlMenu1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControlMenu1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnExport);
            this.tabPage1.Controls.Add(this.txtMsg);
            this.tabPage1.Controls.Add(this.btnMerge);
            this.tabPage1.Controls.Add(this.pbAfterMerge);
            this.tabPage1.Controls.Add(this.btnUpload);
            this.tabPage1.Controls.Add(this.pbBeforeMerge);
            this.tabPage1.Controls.Add(this.pbMe);
            this.tabPage1.Controls.Add(this.cboResolution);
            this.tabPage1.Controls.Add(this.cboVideo);
            this.tabPage1.Controls.Add(this.btnPic);
            this.tabPage1.Controls.Add(this.btnCut);
            this.tabPage1.Controls.Add(this.btnConnect);
            this.tabPage1.Controls.Add(this.vispShoot);
            this.tabPage1.Location = new System.Drawing.Point(201, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1088, 633);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "我的主页";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnUpload
            // 
            this.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpload.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnUpload.Location = new System.Drawing.Point(402, 368);
            this.btnUpload.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(108, 38);
            this.btnUpload.TabIndex = 10;
            this.btnUpload.Text = "上传融合图";
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // pbBeforeMerge
            // 
            this.pbBeforeMerge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBeforeMerge.Image = null;
            this.pbBeforeMerge.Location = new System.Drawing.Point(784, 3);
            this.pbBeforeMerge.Name = "pbBeforeMerge";
            this.pbBeforeMerge.Size = new System.Drawing.Size(267, 175);
            this.pbBeforeMerge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBeforeMerge.TabIndex = 9;
            this.pbBeforeMerge.TabStop = false;
            // 
            // pbMe
            // 
            this.pbMe.Image = null;
            this.pbMe.Location = new System.Drawing.Point(516, 3);
            this.pbMe.Name = "pbMe";
            this.pbMe.Size = new System.Drawing.Size(262, 175);
            this.pbMe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMe.TabIndex = 8;
            this.pbMe.TabStop = false;
            // 
            // cboResolution
            // 
            this.cboResolution.FillColor = System.Drawing.Color.White;
            this.cboResolution.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cboResolution.Location = new System.Drawing.Point(4, 468);
            this.cboResolution.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboResolution.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboResolution.Name = "cboResolution";
            this.cboResolution.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboResolution.Size = new System.Drawing.Size(235, 29);
            this.cboResolution.TabIndex = 7;
            this.cboResolution.Text = "uiComboBox1";
            this.cboResolution.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboVideo
            // 
            this.cboVideo.FillColor = System.Drawing.Color.White;
            this.cboVideo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cboVideo.Location = new System.Drawing.Point(4, 420);
            this.cboVideo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboVideo.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboVideo.Name = "cboVideo";
            this.cboVideo.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboVideo.Size = new System.Drawing.Size(235, 29);
            this.cboVideo.TabIndex = 6;
            this.cboVideo.Text = "uiComboBox1";
            this.cboVideo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboVideo.SelectedIndexChanged += new System.EventHandler(this.cboVideo_SelectedIndexChanged);
            // 
            // btnPic
            // 
            this.btnPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPic.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnPic.Location = new System.Drawing.Point(267, 368);
            this.btnPic.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnPic.Name = "btnPic";
            this.btnPic.Size = new System.Drawing.Size(108, 38);
            this.btnPic.TabIndex = 3;
            this.btnPic.Text = "拍照";
            this.btnPic.Click += new System.EventHandler(this.btnPic_Click);
            // 
            // btnCut
            // 
            this.btnCut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCut.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnCut.Location = new System.Drawing.Point(138, 368);
            this.btnCut.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(108, 38);
            this.btnCut.TabIndex = 2;
            this.btnCut.Text = "断开摄像头";
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnect.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnConnect.Location = new System.Drawing.Point(4, 368);
            this.btnConnect.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(108, 38);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "启用摄像头";
            this.btnConnect.Click += new System.EventHandler(this.btnStartVideo_Click);
            // 
            // vispShoot
            // 
            this.vispShoot.Location = new System.Drawing.Point(3, 3);
            this.vispShoot.Name = "vispShoot";
            this.vispShoot.Size = new System.Drawing.Size(507, 348);
            this.vispShoot.TabIndex = 0;
            this.vispShoot.Text = "videoSourcePlayer1";
            this.vispShoot.VideoSource = null;
            // 
            // pbAfterMerge
            // 
            this.pbAfterMerge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAfterMerge.Image = null;
            this.pbAfterMerge.Location = new System.Drawing.Point(516, 184);
            this.pbAfterMerge.Name = "pbAfterMerge";
            this.pbAfterMerge.Size = new System.Drawing.Size(535, 366);
            this.pbAfterMerge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAfterMerge.TabIndex = 11;
            this.pbAfterMerge.TabStop = false;
            // 
            // btnMerge
            // 
            this.btnMerge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMerge.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnMerge.Location = new System.Drawing.Point(402, 420);
            this.btnMerge.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(108, 38);
            this.btnMerge.TabIndex = 12;
            this.btnMerge.Text = "确认融合";
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // txtMsg
            // 
            this.txtMsg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMsg.FillColor = System.Drawing.Color.White;
            this.txtMsg.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtMsg.Location = new System.Drawing.Point(4, 522);
            this.txtMsg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMsg.Maximum = 2147483647D;
            this.txtMsg.Minimum = -2147483648D;
            this.txtMsg.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Padding = new System.Windows.Forms.Padding(5);
            this.txtMsg.ReadOnly = true;
            this.txtMsg.Size = new System.Drawing.Size(505, 106);
            this.txtMsg.TabIndex = 13;
            // 
            // btnExport
            // 
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnExport.Location = new System.Drawing.Point(402, 468);
            this.btnExport.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(108, 38);
            this.btnExport.TabIndex = 14;
            this.btnExport.Text = "导出融合图";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 668);
            this.Controls.Add(this.uiTabControlMenu1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMain";
            this.Text = "Seagull.BeautifyFace";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.uiTabControlMenu1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBeforeMerge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAfterMerge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITabControlMenu uiTabControlMenu1;
        private System.Windows.Forms.TabPage tabPage1;
        private Sunny.UI.UIButton btnConnect;
        private AForge.Controls.VideoSourcePlayer vispShoot;
        private Sunny.UI.UIButton btnPic;
        private Sunny.UI.UIButton btnCut;
        private Sunny.UI.UIComboBox cboResolution;
        private Sunny.UI.UIComboBox cboVideo;
        private AForge.Controls.PictureBox pbBeforeMerge;
        private AForge.Controls.PictureBox pbMe;
        private Sunny.UI.UIButton btnUpload;
        private AForge.Controls.PictureBox pbAfterMerge;
        private Sunny.UI.UIButton btnMerge;
        private Sunny.UI.UITextBox txtMsg;
        private Sunny.UI.UIButton btnExport;
    }
}

