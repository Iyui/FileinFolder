﻿namespace FileinFolder
{
    partial class Form1
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
            this.btSelectFolder = new System.Windows.Forms.Button();
            this.btOutput = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.同名覆盖ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbOutputPath = new System.Windows.Forms.TextBox();
            this.tbFolderPath = new System.Windows.Forms.TextBox();
            this.btStart = new System.Windows.Forms.Button();
            this.btRemoveType = new System.Windows.Forms.Button();
            this.btFileType = new System.Windows.Forms.Button();
            this.lbFileType = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslFileName = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.完成后打开输出文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSelectFolder
            // 
            this.btSelectFolder.Location = new System.Drawing.Point(337, 4);
            this.btSelectFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSelectFolder.Name = "btSelectFolder";
            this.btSelectFolder.Size = new System.Drawing.Size(100, 29);
            this.btSelectFolder.TabIndex = 0;
            this.btSelectFolder.Text = "选择文件夹";
            this.btSelectFolder.UseVisualStyleBackColor = true;
            this.btSelectFolder.Click += new System.EventHandler(this.btSelectFolder_Click);
            // 
            // btOutput
            // 
            this.btOutput.Location = new System.Drawing.Point(337, 49);
            this.btOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btOutput.Name = "btOutput";
            this.btOutput.Size = new System.Drawing.Size(100, 29);
            this.btOutput.TabIndex = 1;
            this.btOutput.Text = "输出至";
            this.btOutput.UseVisualStyleBackColor = true;
            this.btOutput.Click += new System.EventHandler(this.btOutput_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.splitContainer1.Panel2.Controls.Add(this.tbOutputPath);
            this.splitContainer1.Panel2.Controls.Add(this.tbFolderPath);
            this.splitContainer1.Panel2.Controls.Add(this.btStart);
            this.splitContainer1.Panel2.Controls.Add(this.btOutput);
            this.splitContainer1.Panel2.Controls.Add(this.btRemoveType);
            this.splitContainer1.Panel2.Controls.Add(this.btFileType);
            this.splitContainer1.Panel2.Controls.Add(this.lbFileType);
            this.splitContainer1.Panel2.Controls.Add(this.btSelectFolder);
            this.splitContainer1.Size = new System.Drawing.Size(481, 282);
            this.splitContainer1.SplitterDistance = 32;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜单ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(481, 32);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 菜单ToolStripMenuItem
            // 
            this.菜单ToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.菜单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.同名覆盖ToolStripMenuItem,
            this.完成后打开输出文件夹ToolStripMenuItem});
            this.菜单ToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.菜单ToolStripMenuItem.Name = "菜单ToolStripMenuItem";
            this.菜单ToolStripMenuItem.Size = new System.Drawing.Size(51, 28);
            this.菜单ToolStripMenuItem.Text = "选项";
            // 
            // 同名覆盖ToolStripMenuItem
            // 
            this.同名覆盖ToolStripMenuItem.Checked = true;
            this.同名覆盖ToolStripMenuItem.CheckOnClick = true;
            this.同名覆盖ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.同名覆盖ToolStripMenuItem.Enabled = false;
            this.同名覆盖ToolStripMenuItem.Name = "同名覆盖ToolStripMenuItem";
            this.同名覆盖ToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.同名覆盖ToolStripMenuItem.Text = "同名覆盖";
            // 
            // tbOutputPath
            // 
            this.tbOutputPath.Location = new System.Drawing.Point(19, 38);
            this.tbOutputPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbOutputPath.Name = "tbOutputPath";
            this.tbOutputPath.ReadOnly = true;
            this.tbOutputPath.Size = new System.Drawing.Size(295, 25);
            this.tbOutputPath.TabIndex = 8;
            // 
            // tbFolderPath
            // 
            this.tbFolderPath.Location = new System.Drawing.Point(19, 4);
            this.tbFolderPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbFolderPath.Name = "tbFolderPath";
            this.tbFolderPath.ReadOnly = true;
            this.tbFolderPath.Size = new System.Drawing.Size(295, 25);
            this.tbFolderPath.TabIndex = 7;
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(337, 181);
            this.btStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(100, 29);
            this.btStart.TabIndex = 6;
            this.btStart.Text = "运行";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btRemoveType
            // 
            this.btRemoveType.Location = new System.Drawing.Point(127, 185);
            this.btRemoveType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btRemoveType.Name = "btRemoveType";
            this.btRemoveType.Size = new System.Drawing.Size(100, 29);
            this.btRemoveType.TabIndex = 5;
            this.btRemoveType.Text = "移除类型";
            this.btRemoveType.UseVisualStyleBackColor = true;
            this.btRemoveType.Click += new System.EventHandler(this.btRemoveType_Click);
            // 
            // btFileType
            // 
            this.btFileType.Location = new System.Drawing.Point(19, 185);
            this.btFileType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btFileType.Name = "btFileType";
            this.btFileType.Size = new System.Drawing.Size(100, 29);
            this.btFileType.TabIndex = 4;
            this.btFileType.Text = "添加类型";
            this.btFileType.UseVisualStyleBackColor = true;
            this.btFileType.Click += new System.EventHandler(this.btFileType_Click);
            // 
            // lbFileType
            // 
            this.lbFileType.FormattingEnabled = true;
            this.lbFileType.ItemHeight = 15;
            this.lbFileType.Location = new System.Drawing.Point(19, 68);
            this.lbFileType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbFileType.Name = "lbFileType";
            this.lbFileType.Size = new System.Drawing.Size(295, 109);
            this.lbFileType.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslFileName});
            this.statusStrip1.Location = new System.Drawing.Point(0, 260);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(481, 22);
            this.statusStrip1.TabIndex = 3;
            // 
            // tsslFileName
            // 
            this.tsslFileName.Name = "tsslFileName";
            this.tsslFileName.Size = new System.Drawing.Size(0, 17);
            // 
            // 完成后打开输出文件夹ToolStripMenuItem
            // 
            this.完成后打开输出文件夹ToolStripMenuItem.Checked = true;
            this.完成后打开输出文件夹ToolStripMenuItem.CheckOnClick = true;
            this.完成后打开输出文件夹ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.完成后打开输出文件夹ToolStripMenuItem.Enabled = false;
            this.完成后打开输出文件夹ToolStripMenuItem.Name = "完成后打开输出文件夹ToolStripMenuItem";
            this.完成后打开输出文件夹ToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.完成后打开输出文件夹ToolStripMenuItem.Text = "完成后打开输出文件夹";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 282);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
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

        private System.Windows.Forms.Button btSelectFolder;
        private System.Windows.Forms.Button btOutput;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 菜单ToolStripMenuItem;
        private System.Windows.Forms.Button btRemoveType;
        private System.Windows.Forms.Button btFileType;
        private System.Windows.Forms.ListBox lbFileType;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.ToolStripStatusLabel tsslFileName;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox tbOutputPath;
        private System.Windows.Forms.TextBox tbFolderPath;
        private System.Windows.Forms.ToolStripMenuItem 同名覆盖ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 完成后打开输出文件夹ToolStripMenuItem;
    }
}
