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
            listBoxShow.SelectedIndex = 0;
            index = listBoxShow.FindString(tbTargetString.Text, index + 1);
            if (index != -1)
            {
                TargetIndex.Add(index);
                SearchTarget();
            }
        }

        //private void Search()
        //{
        //    Thread.Sleep(500);
        //    MethodInvoker ln = new MethodInvoker(SearchTarget);
        //    this.BeginInvoke(ln);
        //}

        private void tsmiSortString_Click(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = splitContainer1.Size.Height - 25;
        }

        bool firstClick = true;
        protected Thread runThread = null; //执行线程
        int SelectIndex = -1;
        private void btSortNext_Click(object sender, EventArgs e)
        {
            if(firstClick)
            {
                //runThread = new Thread(Search);
                //runThread.Start();
                SearchTarget();
            }
            firstClick = false;
            if (TargetIndex.Count > 1)
            {
                listBoxShow.SelectedIndex = TargetIndex[++SelectIndex];
            }
        }

        private void btSortLast_Click(object sender, EventArgs e)
        {
            if (firstClick)
            {
                //runThread = new Thread(Search);
                SearchTarget();
                //runThread.Start();
            }
            firstClick = false;
            if (TargetIndex.Count > 1 && SelectIndex > 0)
            {
                listBoxShow.SelectedIndex = TargetIndex[--SelectIndex];
            }
            else
            {
                SelectIndex = 0;
                listBoxShow.SelectedIndex = TargetIndex[SelectIndex];
            }
        }

        private void btCloseStatusStrip_Click(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = splitContainer1.Size.Height + 25;
        }

        private void tsmiOpenFileLocation_Click(object sender, EventArgs e)
        {
            if (listBoxShow.SelectedItems.Count < 1)
            {
                return;
            }
            for (int i = 0; i < listBoxShow.SelectedItems.Count; i++)
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

        }
    }
}
