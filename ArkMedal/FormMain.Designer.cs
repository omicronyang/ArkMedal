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
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefreshDef = new System.Windows.Forms.Button();
            this.btnRefreshPng = new System.Windows.Forms.Button();
            this.lstErr = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.帮助ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 25);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "关于";
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
            this.lstErr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
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
            this.label4.Location = new System.Drawing.Point(3, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "错误：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 582);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip1;
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
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.Button btnRefreshDef;
        private System.Windows.Forms.Button btnRefreshPng;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstErr;
    }
}

