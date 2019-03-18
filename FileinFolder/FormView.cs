using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
namespace FileinFolder
{
    public partial class FormView : Form
    {
        public FormView()
        {
            InitializeComponent();
            Config.messageClass.OnMessageSend += new MessageEventHandler(SubthreadMessageReceive);
            splitContainer1.SplitterDistance = splitContainer1.Size.Height + 25;
        }

        private void FormView_Load(object sender, EventArgs e)
        {

        }

        private void MessageManage(MessageEventArgs e)
        {
            switch (e.messageType)
            {
                case MessageType.RunTime:
                    break;
                case MessageType.FolderPath:
                    listBoxShow.Items.Add(e.Message);
                    break;
                case MessageType.FilePath:
                    listBoxShow.Items.Add(e.Message);
                    break;
                case MessageType.Message:
                    break;
                case MessageType.Error:
                    listBoxShow.Items.Add(e.Message);
                    break;

            }
            listBoxShow.TopIndex = listBoxShow.Items.Count - 1;
        }

        private void SubthreadMessageReceive(MessageEventArgs e)
        {
            try
            {
                if (this.IsHandleCreated && !this.IsDisposed)
                {
                    MessageEventHandler handler = new MessageEventHandler(MessageManage);
                    this.Invoke(handler, new object[] { e });
                }
            }
            catch (Exception)
            {
                //throw new Exception("", ex);
            }
        }

        List<int> TargetIndex = new List<int>();
        static int index = -1;
        private void SearchTarget()
        {
            for (int i = 0; i < listBoxShow.Items.Count; i++)
            {
                string s = listBoxShow.Items[i].ToString();
                if (s.Contains(tbTargetString.Text.Trim()))
                {
                    TargetIndex.Add(i);
                }
            }
        }


        private void tsmiSortString_Click(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = splitContainer1.Size.Height - 25;
        }

        bool firstClick = true;
        private void btSortNext_Click(object sender, EventArgs e)
        {
            if(firstClick)
            {
                SearchTarget();
            }
            firstClick = false;
            for(int i = 0;i<TargetIndex.Count;i++)
            {
                listBoxShow.SelectedIndex= TargetIndex[i];
            }
        }

        private void btCloseStatusStrip_Click(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = splitContainer1.Size.Height + 25;
        }

        private void tsmiOpenFileLocation_Click(object sender, EventArgs e)
        {
            var count = listBoxShow.SelectedItems.Count;
            if (count < 1)
            {
                return;
            }
            else if(count > 10)
            {
                if (MessageBox.Show($"当前选中{count}个文件/文件夹,可能会导致打开过程中内存占用过大,是否继续?", "消息提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
                    return;
            }
            for (int i = 0; i < count; i++)
            {
                var Filelocation = listBoxShow.SelectedItems[i].ToString().Substring(3);
                ClickOpenLocation(Filelocation);
            }   
        }

        public void ClickOpenLocation(string location)
        {
            System.Diagnostics.Process.Start("Explorer", "/select," + @location);
        }

        private void CopySelectedText_Click(object sender, EventArgs e)
        {
            string str = "";
            if (listBoxShow.SelectedItems.Count < 1)
            {
                return;
            }
            for (int i = 0; i < listBoxShow.SelectedItems.Count; i++)
            {
                str += listBoxShow.SelectedItems[i].ToString() + "\r\n";
            }
            Clipboard.SetText(str);
        }

        private void CopyAllText_Click(object sender, EventArgs e)
        {
            string str = "";
            if (listBoxShow.Items.Count < 1)
            {
                return;
            }
            for (int i = 0; i < listBoxShow.Items.Count; i++)
            {
                str += listBoxShow.Items[i].ToString() + "\r\n";
            }
            Clipboard.SetText(str);
        }

        private void SaveTextAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "(文本)*.txt|*.txt"
            };
            if (DialogResult.OK == sfd.ShowDialog())
            {
                try
                {
                    string str = "";
                    if (listBoxShow.Items.Count < 1)
                    {
                        return;
                    }
                    for (int i = 0; i < listBoxShow.Items.Count; i++)
                    {
                        str += listBoxShow.Items[i].ToString() + "\r\n";
                    }
                    StreamWriter sw = new StreamWriter(sfd.FileName, true);
                    sw.WriteLine(str);
                    sw.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"保存日志文件[{sfd.FileName}]失败,异常信息:[{ex.Message}]");
                }
            }
        }

        private void ClearAllText_Click(object sender, EventArgs e)
        {
            listBoxShow.Items.Clear();
        }

        private void tbTargetString_TextChanged(object sender, EventArgs e)
        {
            firstClick = true;
        }
    }
}
