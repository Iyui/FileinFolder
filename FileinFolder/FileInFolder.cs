﻿/*
 * 移动文件夹及子文件夹下的指定类型文件至目标目录
 * Iyui
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
    public partial class FileInFolder : Form
    {
        public FileInFolder()
        {
            InitializeComponent();
            Config.messageClass.OnMessageSend += new MessageEventHandler(SubthreadMessageReceive);
            FloderPath = AppDomain.CurrentDomain.BaseDirectory;
            OutputPath = AppDomain.CurrentDomain.BaseDirectory;
            tbFolderPath.Text = FloderPath;
            tbOutputPath.Text = OutputPath;
            this.FormClosing += FileInFolder_FormClosing;
        }

        private void FileInFolder_FormClosing(object sender, FormClosingEventArgs e)
        {
            loop = false;
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
                    if (tsmiIfOpenFolder.Checked)
                        System.Diagnostics.Process.Start("explorer.exe", OutputPath);
                    break;
                case MessageType.Error:
                    btStart.Text = "运行";
                    MessageBox.Show(e.Message);
                    break;
                case MessageType.Progress:
                    
                    if (fMaxProgress < e.iMessage)
                    {
                        diffTime = Environment.TickCount- diffTime;
                        difTime = iSurplus(e.iMessage - fMaxProgress, diffTime);
                        var diftime = $"剩余时间:{difTime.ToString("0.0")}秒";
                        if (difTime != 0)
                        {
                            ldiffTime.Text = diftime;
                            isProgress = true;
                        }
                    }
 
                    fMaxProgress = Math.Max(fMaxProgress, e.iMessage);
                    progressBar.Value = (int)fMaxProgress;
                    lProgress.Text = fMaxProgress.ToString("0.00") + "%";
                    break;
            }
        }
        bool isProgress = false;
        static float diffTime = 0;
        float fMaxProgress = 0;
        float difTime = float.MaxValue;
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
            dialog.Title = hint;
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
            if (!string.IsNullOrWhiteSpace(FloderPath))
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
            var extentions = FileExtension("打开指定拓展名类型的文件来获取拓展名");
            foreach (var extention in extentions)
            {
                if (!lbFileType.Items.Contains(extention))
                {
                    lbFileType.Items.Add(extention);
                    Extention.Add(extention);
                }
            }
        }

        //protected Thread runThread = null; //执行线程
        float starttime = 0; //计时
        private void btStart_Click(object sender, EventArgs e)
        {
            if (btStart.Text == "运行")
            {
                init();
                
                FormView fv = new FormView();
                fv.Show();
                Thread.Sleep(1000);
                starttime = Environment.TickCount;
                ThreadGetFileFolder();
            }
        }

        private void ThreadGetFileFolder()
        {
            AllFolder.Add(FloderPath);
            GetSubFolders(FloderPath);
            var runThread = new Thread(GetAppointTypeFile);
            runThread.Start();
            var copyThread = new Thread(ThreadCopy);
            copyThread.Start();
        }

        static List<string> AllFolder = new List<string>();
        static bool loop = true;
        public bool isSearchFinished { get; set; } = false;

        private void ThreadCopy()
        {
            int count = 0;
            int errorcount = 0;
            isSearchFinished = false;
            loop = true;
            while (loop)
            {
                if (FileDir.Count > 0)
                {
                    Dictionary<string, string> newDir = new Dictionary<string, string>();
                    try { newDir = new Dictionary<string, string>(FileDir); } catch { };
                    foreach (var file in newDir)
                    {
                        if (lbFileType.Items.Count == 0)
                        {
                            Config.messageClass.MessageSend(new MessageEventArgs("文件类型不能为空", MessageType.Error));
                            return;
                        }
                        try
                        {
                            File.Copy(file.Key, OutputPath + "\\" + reName(file.Value), true);
                            FileDir.Remove(file.Key);
                            count++;
                        }
                        catch
                        {
                            FileDir.Remove(file.Key);
                            errorcount++;
                        };
                        if (isProgress)
                            diffTime = Environment.TickCount;
                        isProgress = false;
                        Config.messageClass.MessageSend(new MessageEventArgs(fProgress(count+ errorcount), MessageType.Progress));
                        Config.messageClass.MessageSend(new MessageEventArgs("复制:" + file.Key, MessageType.FilePath));
                    }
                }
                else
                {
                    Thread.Sleep(1);
                    if (isSearchFinished && FileDir.Count < 1)
                        loop = false;
                }
            }           
            Config.messageClass.MessageSend(new MessageEventArgs($"运行完成,共搜索到{isearch}个文件对象,复制成功{count}个文件对象,复制失败{errorcount}个文件对象", MessageType.Message));
            AllFolder.Clear();
            NameHash.Clear();
            errorcount = count = 0;
        }

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
                    }
                }
            }
            catch { };

        }

        static Dictionary<string, string> FileDir = new Dictionary<string, string>();
        static int isearch = 0;
        static int idirsCount = 0;
        static float idirCount = 0;
        static float ifolderIndex = 0;
        /// <summary>
        /// 获取所有指定类型的文件
        /// </summary>
        private void GetAppointTypeFile()
        {
            //var pattern = sTypeFile();
            foreach (var folder in AllFolder)
            {
                ifolderIndex++;
                try
                {
                    DirectoryInfo dicInfo = new DirectoryInfo(folder);
                    FileInfo[] dirs = TypeFile()
     .SelectMany(i => dicInfo.GetFiles(i, SearchOption.TopDirectoryOnly))
     .Distinct().ToArray();
                    idirsCount = dirs.Count();
                    idirCount = 0;
                    foreach (var dir in dirs)
                    {
                        idirCount++;
                        FileDir.Add(dir.FullName, dir.Name);
                        Config.messageClass.MessageSend(new MessageEventArgs("搜索:" + dir.FullName, MessageType.FolderPath));
                        isearch++;
                    }
                }
                catch { };
            }
            isSearchFinished = true;
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

        private void IyuiLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Iyui/FileinFolder");
        }

        HashSet<string> NameHash = new HashSet<string>();
        private string reName(string name)
        {
            string extension = Path.GetExtension(name);//扩展名 “.aspx”
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(name);// 没有扩展名的文件名
            if (!NameHash.Add(name))
            {
                return reName(fileNameWithoutExtension, fileNameWithoutExtension, extension, name);
            }
            return name;         
        }

        /// <summary>
        /// 重命名
        /// </summary>
        /// <param name="fileNameWithoutExtension">无拓展名的文件名</param>
        /// <param name="original">原始无拓展名的文件名</param>
        /// <param name="extension">拓展名</param>
        /// <param name="name">有拓展名的文件名</param>
        /// <param name="serialNum">序号</param>
        /// <returns></returns>
        private string reName(string fileNameWithoutExtension, string original, string extension, string name, int serialNum = 1)
        {
            name = original + $"({serialNum.ToString()})" + extension;
            serialNum++;
            if (!NameHash.Add(name))
                return reName(fileNameWithoutExtension, original, extension, name, serialNum);
            return name;
        }

        private void tsmiView_Click(object sender, EventArgs e)
        {
            FormView fv = new FormView();
            fv.Show();
        }

        /// <summary>
        /// 进度条
        /// </summary>
        /// <param name="icopy"></param>
        /// <returns></returns>
        private float fProgress(float icopy)
        {
            float progress = 0;
            if (isearch != 0)
            {
                if (idirsCount == 0)
                {
                    idirsCount = 1;
                    idirCount = 1;
                }
                //(当前已复制文件数/已搜索到的指定类型文件数)*(当前文件夹中已搜索到的指定类型文件数/当前文件夹中文件总数)*(已搜索的文件夹数/文件夹总数) * 100 + %
                progress = (icopy / isearch) * (idirCount / idirsCount) * (ifolderIndex / AllFolder.Count()) * (float)100.0;   
            }
            return progress;
        }

        /// <summary>
        /// 间隔时间
        /// </summary>
        /// <param name="diffProgress"></param>
        /// <param name="diffTime"></param>
        /// <returns></returns>
        private float iSurplus(float diffProgress,float diffTime)
        {
            float iSurplusTime = 100 - fMaxProgress;
            float difftime = diffProgress / diffTime;
            return (iSurplusTime / difftime)/1000000000;
        }

        private void init()
        {
            isProgress = false;
            diffTime = 0;
            fMaxProgress = 0;
            difTime = float.MaxValue;
            progressBar.Value = 0;
            lProgress.Text = fMaxProgress.ToString("0.00") + "%";
            btStart.Text = "运行中";
            FileDir.Clear();
        }
    }
}