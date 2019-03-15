namespace FileinFolder
{
    partial class FormView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBoxShow = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CopySelectedText = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyAllText = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearAllText = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveTextAs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSortString = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpenFileLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.btSortLast = new System.Windows.Forms.Button();
            this.btSortNext = new System.Windows.Forms.Button();
            this.btCloseStatusStrip = new System.Windows.Forms.Button();
            this.tbTargetString = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBoxShow);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btSortLast);
            this.splitContainer1.Panel2.Controls.Add(this.btSortNext);
            this.splitContainer1.Panel2.Controls.Add(this.btCloseStatusStrip);
            this.splitContainer1.Panel2.Controls.Add(this.tbTargetString);
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Panel2MinSize = 0;
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 421;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // listBoxShow
            // 
            this.listBoxShow.BackColor = System.Drawing.Color.Black;
            this.listBoxShow.ContextMenuStrip = this.contextMenuStrip1;
            this.listBoxShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxShow.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxShow.ForeColor = System.Drawing.Color.White;
            this.listBoxShow.FormattingEnabled = true;
            this.listBoxShow.HorizontalScrollbar = true;
            this.listBoxShow.ItemHeight = 12;
            this.listBoxShow.Location = new System.Drawing.Point(0, 0);
            this.listBoxShow.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.listBoxShow.Name = "listBoxShow";
            this.listBoxShow.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxShow.Size = new System.Drawing.Size(800, 421);
            this.listBoxShow.TabIndex = 10;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopySelectedText,
            this.CopyAllText,
            this.ClearAllText,
            this.SaveTextAs,
            this.tsmiSortString,
            this.tsmiOpenFileLocation});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(166, 136);
            // 
            // CopySelectedText
            // 
            this.CopySelectedText.Name = "CopySelectedText";
            this.CopySelectedText.Size = new System.Drawing.Size(165, 22);
            this.CopySelectedText.Text = "复制选中行";
            this.CopySelectedText.Click += new System.EventHandler(this.CopySelectedText_Click);
            // 
            // CopyAllText
            // 
            this.CopyAllText.Name = "CopyAllText";
            this.CopyAllText.Size = new System.Drawing.Size(165, 22);
            this.CopyAllText.Text = "复制全部";
            this.CopyAllText.Click += new System.EventHandler(this.CopyAllText_Click);
            // 
            // ClearAllText
            // 
            this.ClearAllText.Name = "ClearAllText";
            this.ClearAllText.Size = new System.Drawing.Size(165, 22);
            this.ClearAllText.Text = "清空全部";
            this.ClearAllText.Click += new System.EventHandler(this.ClearAllText_Click);
            // 
            // SaveTextAs
            // 
            this.SaveTextAs.Name = "SaveTextAs";
            this.SaveTextAs.Size = new System.Drawing.Size(165, 22);
            this.SaveTextAs.Text = "另存为文档";
            this.SaveTextAs.Click += new System.EventHandler(this.SaveTextAs_Click);
            // 
            // tsmiSortString
            // 
            this.tsmiSortString.Name = "tsmiSortString";
            this.tsmiSortString.Size = new System.Drawing.Size(165, 22);
            this.tsmiSortString.Text = "搜索";
            this.tsmiSortString.Click += new System.EventHandler(this.tsmiSortString_Click);
            // 
            // tsmiOpenFileLocation
            // 
            this.tsmiOpenFileLocation.Name = "tsmiOpenFileLocation";
            this.tsmiOpenFileLocation.Size = new System.Drawing.Size(165, 22);
            this.tsmiOpenFileLocation.Text = "打开文件/文件夹";
            this.tsmiOpenFileLocation.Click += new System.EventHandler(this.tsmiOpenFileLocation_Click);
            // 
            // btSortLast
            // 
            this.btSortLast.Location = new System.Drawing.Point(25, 6);
            this.btSortLast.Name = "btSortLast";
            this.btSortLast.Size = new System.Drawing.Size(22, 22);
            this.btSortLast.TabIndex = 4;
            this.btSortLast.Text = "↑";
            this.btSortLast.UseVisualStyleBackColor = true;
            this.btSortLast.Click += new System.EventHandler(this.btSortLast_Click);
            // 
            // btSortNext
            // 
            this.btSortNext.Location = new System.Drawing.Point(48, 6);
            this.btSortNext.Name = "btSortNext";
            this.btSortNext.Size = new System.Drawing.Size(22, 22);
            this.btSortNext.TabIndex = 3;
            this.btSortNext.Text = "↓";
            this.btSortNext.UseVisualStyleBackColor = true;
            this.btSortNext.Click += new System.EventHandler(this.btSortNext_Click);
            // 
            // btCloseStatusStrip
            // 
            this.btCloseStatusStrip.Location = new System.Drawing.Point(2, 6);
            this.btCloseStatusStrip.Name = "btCloseStatusStrip";
            this.btCloseStatusStrip.Size = new System.Drawing.Size(22, 22);
            this.btCloseStatusStrip.TabIndex = 2;
            this.btCloseStatusStrip.Text = "×";
            this.btCloseStatusStrip.UseVisualStyleBackColor = true;
            this.btCloseStatusStrip.Click += new System.EventHandler(this.btCloseStatusStrip_Click);
            // 
            // tbTargetString
            // 
            this.tbTargetString.Location = new System.Drawing.Point(76, 6);
            this.tbTargetString.Name = "tbTargetString";
            this.tbTargetString.Size = new System.Drawing.Size(724, 21);
            this.tbTargetString.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 6);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormView";
            this.Text = "FormView";
            this.Load += new System.EventHandler(this.FormView_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listBoxShow;
        private System.Windows.Forms.Button btSortNext;
        private System.Windows.Forms.Button btCloseStatusStrip;
        private System.Windows.Forms.TextBox tbTargetString;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CopySelectedText;
        private System.Windows.Forms.ToolStripMenuItem CopyAllText;
        private System.Windows.Forms.ToolStripMenuItem ClearAllText;
        private System.Windows.Forms.ToolStripMenuItem SaveTextAs;
        private System.Windows.Forms.ToolStripMenuItem tsmiSortString;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenFileLocation;
        private System.Windows.Forms.Button btSortLast;
    }
}