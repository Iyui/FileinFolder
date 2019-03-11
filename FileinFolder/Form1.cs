﻿/*
 * 移动文件夹及子文件夹下的指定类型文件至目标目录
 * 同名文件覆盖
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
namespace FileinFolder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Config.messageClass.OnMessageSend+= new MessageEventHandler(SubthreadMessageReceive);
            FloderPath = AppDomain.CurrentDomain.BaseDirectory;
            OutputPath = AppDomain.CurrentDomain.BaseDirectory;
            tbFolderPath.Text = FloderPath;
            tbOutputPath.Text = OutputPath;
        }

        //输入路径
        public static string FloderPath
        {
            get;
            set;
        }

        //输出路径
        public static string OutputPath
        {
            get;
            set;
        }

        private string SelectFolder(string hint)
        {
            string path = sFolderPath(hint);
            return path;
        }

        /// <summary>
        /// 消息处理
        /// </summary>
        /// <param name="e"></param>
        private void MessageManage(MessageEventArgs e)
        {
            switch (e.messageType)
            {
                case MessageType.RunTime:
                    break;
                case MessageType.FolderPath:
                    tsslFileName.Text = e.Message;
                    break;
                case MessageType.FilePath:
                    tsslFileName.Text = e.Message;
                    break;
                case MessageType.Message:
                    var messageshow = e.Message + $",用时 {(Environment.TickCount - starttime) / 1000} 秒";
                    tsslFileName.Text = messageshow;
                    btStart.Text = "运行";
                    MessageBox.Show(messageshow);
                    System.Diagnostics.Process.Start("explorer.exe", OutputPath);
                    break;
                case MessageType.Error:
                    btStart.Text = "运行";
                    MessageBox.Show(e.Message);
                    break;
            }
            
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
        /// <summary>
        /// 获取文件夹路径
        /// </summary>
        /// <param name="hint"></param>
        /// <returns></returns>
        private string sFolderPath(string hint)
        {

            string Path = "";
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = hint;
            //设置此次默认目录为上一次选中目录
            //string FolderDefaultPath = ScXmlClass.GetSCCTConfigElement("记录设定",
            //    this.TopLevelControl.Name, "路径", "Value");
            //if (FolderDefaultPath != "")
            //    dialog.SelectedPath = FolderDefaultPath;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "提示");
                    return "";
                }
                Path = dialog.SelectedPath;
            }
            return Path;
        }

        /// <summary>
        /// 获取文件路径
        /// </summary>
        /// <param name="hint"></param>
        /// <returns></returns>
        private List<string> FilePath(string hint)
        {
            List<string> Path = new List<string>();
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "所有文件(*.*)|*.*";
            dialog.Multiselect = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string FileName in dialog.FileNames)
                    Path.Add(FileName);
            }
            return Path;
        }

        /// <summary>
        /// 获取文件拓展名
        /// </summary>
        /// <param name="hint"></param>
        /// <returns></returns>
        private List<string> FileExtension(string hint)
        {
            var extentions = FilePath(hint);
            HashSet<string> hs = new HashSet<string>();
            foreach (var extention in extentions)
            {
                hs.Add(Path.GetExtension(extention));
            }
            return hs.ToList();
        }


        private void btSelectFolder_Click(object sender, EventArgs e)
        {
            FloderPath = SelectFolder("选择目标文件夹");
            if(!string.IsNullOrWhiteSpace(FloderPath))
                tbFolderPath.Text = FloderPath;
        }

        private void btOutput_Click(object sender, EventArgs e)
        {
            OutputPath = SelectFolder("选择输出的文件夹路径");
            if (!string.IsNullOrWhiteSpace(FloderPath))
                tbOutputPath.Text = OutputPath;
        }

        static List<string> Extention = new List<string>();
        private void btFileType_Click(object sender, EventArgs e)
        {
            var extentions = FileExtension("选择要提取的拓展名类型");
            foreach (var extention in extentions)
            {
                if (!lbFileType.Items.Contains(extention))
                {
                    lbFileType.Items.Add(extention);
                    Extention.Add(extention);
                }
            }
        }

        protected Thread runThread = null; //执行线程
        float starttime = 0; //计时
        private void btStart_Click(object sender, EventArgs e)
        {
            if (btStart.Text == "运行")
            {
                btStart.Text = "运行中";
                starttime = Environment.TickCount;
                FileDir.Clear();
                runThread = new Thread(Threadrunning);
                runThread.Start();
            }
        }

        private void Threadrunning()
        {
            GetSubFolders(FloderPath);
            GetAppointTypeFile();
            foreach (var file in FileDir)
            {
                if (lbFileType.Items.Count == 0)
                {
                    Config.messageClass.MessageSend(new MessageEventArgs("文件类型不能为空", MessageType.Error));
                    return;
                }
                File.Copy(file.Key, OutputPath + "\\" + file.Value, true);
                Config.messageClass.MessageSend(new MessageEventArgs("复制:" + file.Key, MessageType.FilePath));
                Thread.Sleep(1);
            }
            Config.messageClass.MessageSend(new MessageEventArgs($"运行完成,共复制{FileDir.Count()}个文件对象", MessageType.Message));
        }

        static List<string> AllFolder = new List<string>();

        /// <summary>
        /// 获取所有文件夹及子文件夹
        /// </summary>
        /// <param name="FolderPath"></param>
        private void GetSubFolders(string FolderPath)
        {
            
            try
            {
                DirectoryInfo dicInfo = new DirectoryInfo(FolderPath);
                DirectoryInfo[] dirs = dicInfo.GetDirectories();
            
            
            if (dirs.Count() > 0)
            {
                foreach (var dir in dirs)
                {
                    GetSubFolders(dir.FullName);
                    AllFolder.Add(dir.FullName);
                    Config.messageClass.MessageSend(new MessageEventArgs("搜索:" + dir.FullName, MessageType.FolderPath));
                    Thread.Sleep(1);
                }
            }
            }
            catch { };
        }

        static Dictionary<string, string> FileDir = new Dictionary<string, string>();
        /// <summary>
        /// 获取所有指定类型的文件
        /// </summary>
        private void GetAppointTypeFile()
        {
            //var pattern = sTypeFile();
            foreach (var folder in AllFolder)
            {
                try
                {
                    DirectoryInfo dicInfo = new DirectoryInfo(folder);
                    FileInfo[] dirs = TypeFile()
     .SelectMany(i => dicInfo.GetFiles(i, SearchOption.TopDirectoryOnly))
     .Distinct().ToArray();
                    foreach (var dir in dirs)
                    {
                        FileDir.Add(dir.FullName, dir.Name);
                        Config.messageClass.MessageSend(new MessageEventArgs("搜索:" + dir.FullName, MessageType.FolderPath));
                    }
                }
                catch { };
            }
        }

        private string[] TypeFile()
        {
            List<string> pattern = new List<string>();
            foreach (var extention in Extention)
            {
                pattern.Add('*' + extention);
            }
            return pattern.ToArray();
        }

        private void btRemoveType_Click(object sender, EventArgs e)
        {
            if (lbFileType.SelectedItems.Count < 1)
            {
                return;
            }
            Extention.Remove(lbFileType.SelectedItem.ToString());
            lbFileType.Items.Remove(lbFileType.SelectedItem.ToString());
        }
    }
}