namespace ArkMedal
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstDef = new System.Windows.Forms.ListBox();
            this.chkDC = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.bfb = new WK.Libraries.BetterFolderBrowserNS.BetterFolderBrowser(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefreshDef = new System.Windows.Forms.Button();
            this.btnRefreshPng = new System.Windows.Forms.Button();
            this.lstErr = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlAbout = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.gpbHelp = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlAbout.SuspendLayout();
            this.gpbHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(281, 17);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(66, 37);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "导出";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(598, 509);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lstDef
            // 
            this.lstDef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstDef.FormattingEnabled = true;
            this.lstDef.ItemHeight = 12;
            this.lstDef.Items.AddRange(new object[] {
            "test1",
            "test2",
            "test3"});
            this.lstDef.Location = new System.Drawing.Point(3, 17);
            this.lstDef.Name = "lstDef";
            this.lstDef.Size = new System.Drawing.Size(272, 112);
            this.lstDef.TabIndex = 3;
            this.lstDef.SelectedIndexChanged += new System.EventHandler(this.lstDef_SelectedIndexChanged);
            // 
            // chkDC
            // 
            this.chkDC.AutoSize = true;
            this.chkDC.Checked = true;
            this.chkDC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDC.Location = new System.Drawing.Point(281, 20);
            this.chkDC.Name = "chkDC";
            this.chkDC.Size = new System.Drawing.Size(48, 16);
            this.chkDC.TabIndex = 5;
            this.chkDC.Text = "镀层";
            this.chkDC.UseVisualStyleBackColor = true;
            this.chkDC.CheckedChanged += new System.EventHandler(this.chkDC_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(3, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(272, 21);
            this.textBox1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.gpbHelp);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(368, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 529);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "预览";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRefreshDef);
            this.groupBox2.Controls.Add(this.lstDef);
            this.groupBox2.Location = new System.Drawing.Point(12, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 134);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Step2. 选择定义文件";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnOpen);
            this.groupBox3.Location = new System.Drawing.Point(12, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 60);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Step1. 选择工作目录";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(1, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "PathPathPathPathPathPathPathPathPathPathPathPathPathPathPathPathPathPathPath";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(281, 16);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(66, 37);
            this.btnOpen.TabIndex = 5;
            this.btnOpen.Text = "浏览";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.lstErr);
            this.groupBox4.Controls.Add(this.btnRefreshPng);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.lstFiles);
            this.groupBox4.Controls.Add(this.chkDC);
            this.groupBox4.Location = new System.Drawing.Point(12, 229);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(350, 262);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Step3. 预览";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "待加载资源：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstFiles
            // 
            this.lstFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstFiles.CausesValidation = false;
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.ItemHeight = 12;
            this.lstFiles.Items.AddRange(new object[] {
            "test1",
            "test2",
            "test3",
            "test1",
            "test2",
            "test3",
            "test1",
            "test2",
            "test3",
            "test1",
            "test2",
            "test3",
            "test1",
            "test2",
            "test3",
            "test1",
            "test2",
            "test3"});
            this.lstFiles.Location = new System.Drawing.Point(3, 42);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstFiles.Size = new System.Drawing.Size(272, 124);
            this.lstFiles.TabIndex = 3;
            this.lstFiles.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 560);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(984, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel1
            // 
            this.StatusLabel1.Name = "StatusLabel1";
            this.StatusLabel1.Size = new System.Drawing.Size(32, 17);
            this.StatusLabel1.Text = "状态";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Controls.Add(this.btnSave);
            this.groupBox5.Location = new System.Drawing.Point(12, 497);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(350, 60);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Step4. 导出";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(1, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "套组名称";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bfb
            // 
            this.bfb.Multiselect = false;
            this.bfb.RootFolder = "C:\\";
            this.bfb.Title = "Please select a folder...";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelp,
            this.menuAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 25);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuHelp
            // 
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(44, 21);
            this.menuHelp.Text = "帮助";
            this.menuHelp.Click += new System.EventHandler(this.menuHelp_Click);
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(44, 21);
            this.menuAbout.Text = "关于";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // btnRefreshDef
            // 
            this.btnRefreshDef.Location = new System.Drawing.Point(281, 17);
            this.btnRefreshDef.Name = "btnRefreshDef";
            this.btnRefreshDef.Size = new System.Drawing.Size(66, 37);
            this.btnRefreshDef.TabIndex = 4;
            this.btnRefreshDef.Text = "刷新";
            this.btnRefreshDef.UseVisualStyleBackColor = true;
            this.btnRefreshDef.Click += new System.EventHandler(this.btnRefreshDef_Click);
            // 
            // btnRefreshPng
            // 
            this.btnRefreshPng.Location = new System.Drawing.Point(281, 42);
            this.btnRefreshPng.Name = "btnRefreshPng";
            this.btnRefreshPng.Size = new System.Drawing.Size(66, 37);
            this.btnRefreshPng.TabIndex = 8;
            this.btnRefreshPng.Text = "刷新";
            this.btnRefreshPng.UseVisualStyleBackColor = true;
            this.btnRefreshPng.Click += new System.EventHandler(this.btnRefreshPng_Click);
            // 
            // lstErr
            // 
            this.lstErr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstErr.CausesValidation = false;
            this.lstErr.ForeColor = System.Drawing.Color.Red;
            this.lstErr.FormattingEnabled = true;
            this.lstErr.ItemHeight = 12;
            this.lstErr.Items.AddRange(new object[] {
            "test1",
            "test2",
            "test3",
            "test1",
            "test2",
            "test3",
            "test1",
            "test2",
            "test3",
            "test1",
            "test2",
            "test3",
            "test1",
            "test2",
            "test3",
            "test1",
            "test2",
            "test3"});
            this.lstErr.Location = new System.Drawing.Point(3, 192);
            this.lstErr.Name = "lstErr";
            this.lstErr.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstErr.Size = new System.Drawing.Size(272, 64);
            this.lstErr.TabIndex = 9;
            this.lstErr.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.Location = new System.Drawing.Point(3, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "错误：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlAbout
            // 
            this.pnlAbout.Controls.Add(this.label6);
            this.pnlAbout.Controls.Add(this.linkLabel1);
            this.pnlAbout.Controls.Add(this.lblVersion);
            this.pnlAbout.Controls.Add(this.label5);
            this.pnlAbout.Location = new System.Drawing.Point(0, 600);
            this.pnlAbout.Name = "pnlAbout";
            this.pnlAbout.Size = new System.Drawing.Size(960, 530);
            this.pnlAbout.TabIndex = 14;
            this.pnlAbout.Click += new System.EventHandler(this.pnlAbout_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(312, 75);
            this.label5.TabIndex = 0;
            this.label5.Text = "ArkMedal";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(330, 46);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(143, 37);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "Version";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.Location = new System.Drawing.Point(20, 145);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(580, 30);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "项目地址：https://github.com/omicronyang/ArkMedal";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(18, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(498, 41);
            this.label6.TabIndex = 3;
            this.label6.Text = "明日方舟蚀刻章套组图片合成工具\r\n";
            // 
            // gpbHelp
            // 
            this.gpbHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbHelp.Controls.Add(this.label10);
            this.gpbHelp.Controls.Add(this.label8);
            this.gpbHelp.Controls.Add(this.label9);
            this.gpbHelp.Controls.Add(this.label7);
            this.gpbHelp.Location = new System.Drawing.Point(0, 0);
            this.gpbHelp.Name = "gpbHelp";
            this.gpbHelp.Size = new System.Drawing.Size(604, 529);
            this.gpbHelp.TabIndex = 8;
            this.gpbHelp.TabStop = false;
            this.gpbHelp.Text = "帮助";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(592, 44);
            this.label7.TabIndex = 7;
            this.label7.Text = "设置为 AssetStudio 的导出目录，所需资源在 AssetStudio 中导出后此目录内应有 Sprite 和 MonoBehaviour 两个文件夹";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Location = new System.Drawing.Point(6, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(592, 134);
            this.label9.TabIndex = 9;
            this.label9.Text = "在 AssetStudio 中打开包 Android/ui/medal/groupframe.ab\r\n选择其中的 UIMedalGroupFrame 文件（类型为" +
    "MonoBehaviour）导出（每套组对应一个该文件）\r\n\r\n· 导出后左侧如无变化请手动刷新，此列表文件应在工作目录下 MonoBehaviour 文件夹内" +
    "\r\n· 选择文件后在右侧即可查看预览";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Location = new System.Drawing.Point(6, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(592, 262);
            this.label8.TabIndex = 10;
            this.label8.Text = resources.GetString("label8.Text");
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.Location = new System.Drawing.Point(6, 483);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(592, 40);
            this.label10.TabIndex = 11;
            this.label10.Text = "输入蚀刻章套组名称。默认为背景图名称";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 582);
            this.Controls.Add(this.pnlAbout);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlAbout.ResumeLayout(false);
            this.pnlAbout.PerformLayout();
            this.gpbHelp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lstDef;
        private System.Windows.Forms.CheckBox chkDC;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel1;
        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SaveFileDialog sfd;
        private WK.Libraries.BetterFolderBrowserNS.BetterFolderBrowser bfb;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.Button btnRefreshDef;
        private System.Windows.Forms.Button btnRefreshPng;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstErr;
        private System.Windows.Forms.Panel pnlAbout;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox gpbHelp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

