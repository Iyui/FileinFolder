namespace FileinFolder
{
    partial class FileInFolder
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_SameName = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIfOpenFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiView = new System.Windows.Forms.ToolStripMenuItem();
            this.USBCopyer = new System.Windows.Forms.ToolStripMenuItem();
            this.选择文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.输出至ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsslFileName = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ldiffTime = new System.Windows.Forms.Label();
            this.lProgress = new System.Windows.Forms.Label();
            this.tbOutputPath = new System.Windows.Forms.TextBox();
            this.tbFolderPath = new System.Windows.Forms.TextBox();
            this.btStart = new System.Windows.Forms.Button();
            this.lbFileType = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.IyuiLink = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            this.splitContainer1.Panel1MinSize = 15;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer1.Panel2.Controls.Add(this.tsslFileName);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.ldiffTime);
            this.splitContainer1.Panel2.Controls.Add(this.lProgress);
            this.splitContainer1.Panel2.Controls.Add(this.tbOutputPath);
            this.splitContainer1.Panel2.Controls.Add(this.tbFolderPath);
            this.splitContainer1.Panel2.Controls.Add(this.btStart);
            this.splitContainer1.Panel2.Controls.Add(this.lbFileType);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(245, 193);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜单ToolStripMenuItem,
            this.选择文件夹ToolStripMenuItem,
            this.输出至ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(245, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 菜单ToolStripMenuItem
            // 
            this.菜单ToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.菜单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_SameName,
            this.tsmiIfOpenFolder,
            this.tsmiView,
            this.USBCopyer});
            this.菜单ToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.菜单ToolStripMenuItem.Name = "菜单ToolStripMenuItem";
            this.菜单ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.菜单ToolStripMenuItem.Text = "选项";
            // 
            // tsmi_SameName
            // 
            this.tsmi_SameName.CheckOnClick = true;
            this.tsmi_SameName.Name = "tsmi_SameName";
            this.tsmi_SameName.Size = new System.Drawing.Size(196, 22);
            this.tsmi_SameName.Text = "同名覆盖";
            // 
            // tsmiIfOpenFolder
            // 
            this.tsmiIfOpenFolder.Checked = true;
            this.tsmiIfOpenFolder.CheckOnClick = true;
            this.tsmiIfOpenFolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiIfOpenFolder.Name = "tsmiIfOpenFolder";
            this.tsmiIfOpenFolder.Size = new System.Drawing.Size(196, 22);
            this.tsmiIfOpenFolder.Text = "完成后打开输出文件夹";
            // 
            // tsmiView
            // 
            this.tsmiView.Name = "tsmiView";
            this.tsmiView.Size = new System.Drawing.Size(196, 22);
            this.tsmiView.Text = "查看详细";
            this.tsmiView.Click += new System.EventHandler(this.tsmiView_Click);
            // 
            // USBCopyer
            // 
            this.USBCopyer.CheckOnClick = true;
            this.USBCopyer.Name = "USBCopyer";
            this.USBCopyer.Size = new System.Drawing.Size(196, 22);
            this.USBCopyer.Text = "U盘复制模式";
            this.USBCopyer.Visible = false;
            // 
            // 选择文件夹ToolStripMenuItem
            // 
            this.选择文件夹ToolStripMenuItem.Name = "选择文件夹ToolStripMenuItem";
            this.选择文件夹ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.选择文件夹ToolStripMenuItem.Text = "选择文件夹";
            this.选择文件夹ToolStripMenuItem.Click += new System.EventHandler(this.btSelectFolder_Click);
            // 
            // 输出至ToolStripMenuItem
            // 
            this.输出至ToolStripMenuItem.Name = "输出至ToolStripMenuItem";
            this.输出至ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.输出至ToolStripMenuItem.Text = "输出至";
            this.输出至ToolStripMenuItem.Click += new System.EventHandler(this.btOutput_Click);
            // 
            // tsslFileName
            // 
            this.tsslFileName.AutoSize = true;
            this.tsslFileName.Location = new System.Drawing.Point(12, 115);
            this.tsslFileName.Name = "tsslFileName";
            this.tsslFileName.Size = new System.Drawing.Size(0, 12);
            this.tsslFileName.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(97, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "删除类型";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btRemoveType_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "添加类型";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btFileType_Click);
            // 
            // ldiffTime
            // 
            this.ldiffTime.AutoSize = true;
            this.ldiffTime.Location = new System.Drawing.Point(284, 138);
            this.ldiffTime.Name = "ldiffTime";
            this.ldiffTime.Size = new System.Drawing.Size(0, 12);
            this.ldiffTime.TabIndex = 10;
            // 
            // lProgress
            // 
            this.lProgress.AutoSize = true;
            this.lProgress.Location = new System.Drawing.Point(189, 88);
            this.lProgress.Name = "lProgress";
            this.lProgress.Size = new System.Drawing.Size(17, 12);
            this.lProgress.TabIndex = 9;
            this.lProgress.Text = "0%";
            // 
            // tbOutputPath
            // 
            this.tbOutputPath.AllowDrop = true;
            this.tbOutputPath.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbOutputPath.Location = new System.Drawing.Point(14, 30);
            this.tbOutputPath.Name = "tbOutputPath";
            this.tbOutputPath.ReadOnly = true;
            this.tbOutputPath.Size = new System.Drawing.Size(222, 21);
            this.tbOutputPath.TabIndex = 8;
            this.tbOutputPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel2_DragDrop);
            this.tbOutputPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.Panel_DragEnter);
            // 
            // tbFolderPath
            // 
            this.tbFolderPath.AllowDrop = true;
            this.tbFolderPath.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbFolderPath.Location = new System.Drawing.Point(14, 3);
            this.tbFolderPath.Name = "tbFolderPath";
            this.tbFolderPath.ReadOnly = true;
            this.tbFolderPath.Size = new System.Drawing.Size(222, 21);
            this.tbFolderPath.TabIndex = 7;
            this.tbFolderPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.tbFolderPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.Panel_DragEnter);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(178, 57);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(58, 23);
            this.btStart.TabIndex = 6;
            this.btStart.Text = "运行";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // lbFileType
            // 
            this.lbFileType.AllowDrop = true;
            this.lbFileType.FormattingEnabled = true;
            this.lbFileType.ItemHeight = 12;
            this.lbFileType.Location = new System.Drawing.Point(14, 57);
            this.lbFileType.Name = "lbFileType";
            this.lbFileType.Size = new System.Drawing.Size(77, 52);
            this.lbFileType.TabIndex = 2;
            this.lbFileType.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbFileType_DragDrop);
            this.lbFileType.DragEnter += new System.Windows.Forms.DragEventHandler(this.Panel_DragEnter);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 23);
            this.panel1.TabIndex = 11;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.Panel_DragEnter);
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.Location = new System.Drawing.Point(4, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 21);
            this.panel2.TabIndex = 12;
            this.panel2.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel2_DragDrop);
            this.panel2.DragEnter += new System.Windows.Forms.DragEventHandler(this.Panel_DragEnter);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar,
            this.IyuiLink});
            this.statusStrip1.Location = new System.Drawing.Point(0, 167);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(245, 26);
            this.statusStrip1.TabIndex = 3;
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(180, 20);
            // 
            // IyuiLink
            // 
            this.IyuiLink.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.IyuiLink.Name = "IyuiLink";
            this.IyuiLink.Size = new System.Drawing.Size(44, 21);
            this.IyuiLink.Text = "@Iyui";
            this.IyuiLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IyuiLink.Click += new System.EventHandler(this.IyuiLink_Click);
            // 
            // FileInFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 193);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FileInFolder";
            this.Text = "FileInFolder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FileInFolder_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 菜单ToolStripMenuItem;
        private System.Windows.Forms.ListBox lbFileType;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox tbOutputPath;
        private System.Windows.Forms.TextBox tbFolderPath;
        private System.Windows.Forms.ToolStripMenuItem tsmi_SameName;
        private System.Windows.Forms.ToolStripMenuItem tsmiIfOpenFolder;
        private System.Windows.Forms.ToolStripStatusLabel IyuiLink;
        private System.Windows.Forms.ToolStripMenuItem tsmiView;
        private System.Windows.Forms.Label lProgress;
        private System.Windows.Forms.Label ldiffTime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem USBCopyer;
        private System.Windows.Forms.ToolStripMenuItem 选择文件夹ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 输出至ToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label tsslFileName;
    }
}

