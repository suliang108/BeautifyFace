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
            this.tpCenter = new System.Windows.Forms.TabPage();
            this.btnExport = new Sunny.UI.UIButton();
            this.txtMsg = new Sunny.UI.UITextBox();
            this.btnMerge = new Sunny.UI.UIButton();
            this.pbAfterMerge = new AForge.Controls.PictureBox();
            this.btnUpload = new Sunny.UI.UIButton();
            this.pbBeforeMerge = new AForge.Controls.PictureBox();
            this.pbMe = new AForge.Controls.PictureBox();
            this.cboResolution = new Sunny.UI.UIComboBox();
            this.cboVideo = new Sunny.UI.UIComboBox();
            this.btnPic = new Sunny.UI.UIButton();
            this.btnCut = new Sunny.UI.UIButton();
            this.btnConnect = new Sunny.UI.UIButton();
            this.vispShoot = new AForge.Controls.VideoSourcePlayer();
            this.tpConfig = new System.Windows.Forms.TabPage();
            this.btnActivite = new Sunny.UI.UIButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.txtSerialNumber = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiTabControlMenu1.SuspendLayout();
            this.tpCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAfterMerge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBeforeMerge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMe)).BeginInit();
            this.tpConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiTabControlMenu1
            // 
            this.uiTabControlMenu1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.uiTabControlMenu1.Controls.Add(this.tpCenter);
            this.uiTabControlMenu1.Controls.Add(this.tpConfig);
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
            // tpCenter
            // 
            this.tpCenter.Controls.Add(this.btnExport);
            this.tpCenter.Controls.Add(this.txtMsg);
            this.tpCenter.Controls.Add(this.btnMerge);
            this.tpCenter.Controls.Add(this.pbAfterMerge);
            this.tpCenter.Controls.Add(this.btnUpload);
            this.tpCenter.Controls.Add(this.pbBeforeMerge);
            this.tpCenter.Controls.Add(this.pbMe);
            this.tpCenter.Controls.Add(this.cboResolution);
            this.tpCenter.Controls.Add(this.cboVideo);
            this.tpCenter.Controls.Add(this.btnPic);
            this.tpCenter.Controls.Add(this.btnCut);
            this.tpCenter.Controls.Add(this.btnConnect);
            this.tpCenter.Controls.Add(this.vispShoot);
            this.tpCenter.Location = new System.Drawing.Point(201, 0);
            this.tpCenter.Name = "tpCenter";
            this.tpCenter.Size = new System.Drawing.Size(1088, 633);
            this.tpCenter.TabIndex = 0;
            this.tpCenter.Text = "我的主页";
            this.tpCenter.UseVisualStyleBackColor = true;
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
            // pbAfterMerge
            // 
            this.pbAfterMerge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAfterMerge.Image = null;
            this.pbAfterMerge.Location = new System.Drawing.Point(516, 226);
            this.pbAfterMerge.Name = "pbAfterMerge";
            this.pbAfterMerge.Size = new System.Drawing.Size(535, 402);
            this.pbAfterMerge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAfterMerge.TabIndex = 11;
            this.pbAfterMerge.TabStop = false;
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
            this.pbBeforeMerge.Size = new System.Drawing.Size(267, 217);
            this.pbBeforeMerge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBeforeMerge.TabIndex = 9;
            this.pbBeforeMerge.TabStop = false;
            // 
            // pbMe
            // 
            this.pbMe.Image = null;
            this.pbMe.Location = new System.Drawing.Point(516, 3);
            this.pbMe.Name = "pbMe";
            this.pbMe.Size = new System.Drawing.Size(262, 217);
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
            // tpConfig
            // 
            this.tpConfig.Controls.Add(this.uiLabel2);
            this.tpConfig.Controls.Add(this.btnActivite);
            this.tpConfig.Controls.Add(this.uiLabel1);
            this.tpConfig.Controls.Add(this.txtSerialNumber);
            this.tpConfig.ForeColor = System.Drawing.Color.Gray;
            this.tpConfig.Location = new System.Drawing.Point(201, 0);
            this.tpConfig.Name = "tpConfig";
            this.tpConfig.Size = new System.Drawing.Size(1088, 633);
            this.tpConfig.TabIndex = 1;
            this.tpConfig.Text = "我的配置";
            this.tpConfig.UseVisualStyleBackColor = true;
            // 
            // btnActivite
            // 
            this.btnActivite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActivite.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnActivite.Location = new System.Drawing.Point(444, 30);
            this.btnActivite.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnActivite.Name = "btnActivite";
            this.btnActivite.Size = new System.Drawing.Size(100, 35);
            this.btnActivite.TabIndex = 2;
            this.btnActivite.Text = "激活";
            this.btnActivite.Click += new System.EventHandler(this.btnActivite_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(31, 36);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(110, 23);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "我的注册码：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSerialNumber.FillColor = System.Drawing.Color.White;
            this.txtSerialNumber.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtSerialNumber.Location = new System.Drawing.Point(148, 36);
            this.txtSerialNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSerialNumber.Maximum = 2147483647D;
            this.txtSerialNumber.Minimum = -2147483648D;
            this.txtSerialNumber.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Padding = new System.Windows.Forms.Padding(5);
            this.txtSerialNumber.Size = new System.Drawing.Size(268, 29);
            this.txtSerialNumber.TabIndex = 0;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.ForeColor = System.Drawing.Color.Gray;
            this.uiLabel2.Location = new System.Drawing.Point(12, 605);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(279, 23);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 3;
            this.uiLabel2.Text = "© 2021. Seagull.版权所有";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.tpCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAfterMerge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBeforeMerge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMe)).EndInit();
            this.tpConfig.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITabControlMenu uiTabControlMenu1;
        private System.Windows.Forms.TabPage tpCenter;
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
        private System.Windows.Forms.TabPage tpConfig;
        private Sunny.UI.UIButton btnActivite;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox txtSerialNumber;
        private Sunny.UI.UILabel uiLabel2;
    }
}

