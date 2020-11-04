using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Threading;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace 文件批量搜索删除工具
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //代理
        private delegate void SetPos(int ipos, string vinfo);
        //文件集合
        private ArrayList fileList = new ArrayList();
        //目录
        private string directory;
        //Ini文件工具
        private IniFile ini = null;
        //计数
        private int num = 0;

        private void PerformTask()
        {
            //设置线程池最大线程数量
            ThreadPool.SetMaxThreads(5, 5);
            ThreadPool.QueueUserWorkItem(delegate { TaskRun(); });
        }
        private void TaskRun()
        {
            try
            {
                if (fileList != null && fileList.Count > 0)
                {
                    for (int i = 0; i < fileList.Count; i++)
                    {
                        string filename = fileList[i].ToString();
                        //MessageBox.Show("删除文件："+filename);
                        DelLicenseFiles(directory, filename);
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.directory = AppDomain.CurrentDomain.BaseDirectory;
            this.txtDirPath.Text = directory;
            //读取config.ini配置文件
            this.ini = new IniFile("config.ini");
            this.ini.ReadSectionValues("file", fileList);
            if (fileList != null && fileList.Count > 0)
            {
                foreach (string item in fileList)
                {
                    //过滤非法字符
                    string str = Unicode2String(item);
                    LoadListView(str);
                }
            }
            // 设置行高
            ImageList imgList = new ImageList();
            // 分别是宽和高
            imgList.ImageSize = new Size(1, 25);
            // 这里设置listView的SmallImageList ,用imgList将其撑大
            listView1.SmallImageList = imgList;
            //在各数据之间形成网格线
            listView1.GridLines = true;
            //显示列名称
            listView1.View = View.Details;
            //不显示滚动条
            listView1.Columns.Add("文件名（拖拽要删除的文件到列表里）", listView1.Width, HorizontalAlignment.Center);
            //listView1.Columns.Add("路径", listView1.Width - 100, HorizontalAlignment.Center);
        }

        private void panelFileBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void LoadListView(string fileName)
        {
            this.labTips.Visible = false;
            ListViewItem lvi = new ListViewItem();
            lvi.Text = fileName;
            //lvi.SubItems.Add(fullPath);
            this.listView1.Items.Add(lvi);
        }
        private void panelFileBox_DragDrop(object sender, DragEventArgs e)
        {
            string fullPath = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            if (!File.Exists(fullPath))
            {
                MessageBox.Show("只能拖入文件");
                return;
            }
            string extension = System.IO.Path.GetExtension(fullPath);//扩展名
            string fileNameWithoutExtension = System.IO.Path.GetFileNameWithoutExtension(fullPath);//文件名
            string fileName = fileNameWithoutExtension.Trim() + extension.Trim();
            //string md5 = GetMD5HashFromFile(fullPath);
            if (fileList.Contains(fileName))
            {
                MessageBox.Show("文件已存在");
                return;
            }
            fileList.Add(fileName);
            LoadListView(fileName);
            this.ini.WriteString("file", fileNameWithoutExtension, String2Unicode(fileName));
        }
        /// <summary>
        /// 删除指定文件夹下指定文件名的文件
        /// </summary>
        /// <param name="url">文件夹地址</param>
        /// <param name="name">要删除的文件名</param>
        /// <returns></returns>
        
        public void DelLicenseFiles(string path, string name)
        {
            try
            {
                DirectoryInfo Folder = new DirectoryInfo(path);
                var files = Folder.GetDirectories();
                
                foreach (FileInfo file in Folder.GetFiles())
                {
                    if (file.Attributes != FileAttributes.Directory)
                    {
                        //Unicode转字符串
                        name=Unicode2String(name);
                        if (name == file.Name)
                        {
                            file.Delete();
                            ++num;
                            SetTextMesssage(0, string.Format("成功删除第[{0}]个文件:{1}", num,file.FullName));
                            SetTextMesssage(0, "\r\n");
                        }
                    }

                }
                foreach (var dicInfo in Folder.GetDirectories())
                {
                    DelLicenseFiles(dicInfo.FullName, name);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          
        }

        /// <summary>
        /// 计算字符串的MD5值
        /// </summary>
        /// <param name="sDataIn">字符串</param>
        /// <returns></returns>
        public string GetStrMd5(string sDataIn)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] bytValue, bytHash;
            bytValue = System.Text.Encoding.UTF8.GetBytes(sDataIn);
            bytHash = md5.ComputeHash(bytValue);
            md5.Clear();
            string sTemp = "";
            for (int i = 0; i < bytHash.Length; i++)
            {
                sTemp += bytHash[i].ToString("X").PadLeft(2, '0');
            }
            return sTemp.ToLower();
        }
        // <summary>
        /// <summary>
        /// 字符串转Unicode
        /// </summary>
        /// <param name="source">源字符串</param>
        /// <returns>Unicode编码后的字符串</returns>
        public static string String2Unicode(string source)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(source);
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i += 2)
            {
                stringBuilder.AppendFormat("\\u{0}{1}", bytes[i + 1].ToString("x").PadLeft(2, '0'), bytes[i].ToString("x").PadLeft(2, '0'));
            }
            return stringBuilder.ToString();
        }

        /// <summary>
        /// Unicode转字符串
        /// </summary>
        /// <param name="source">经过Unicode编码的字符串</param>
        /// <returns>正常字符串</returns>
        public static string Unicode2String(string source)
        {
            return new Regex(@"\\u([0-9A-F]{4})", RegexOptions.IgnoreCase | RegexOptions.Compiled).Replace(source, x => string.Empty + Convert.ToChar(Convert.ToUInt16(x.Result("$1"), 16)));
        }
        /// <summary>
        /// 输出日志信息
        /// </summary>
        /// <param name="ipos"></param>
        /// <param name="vinfo"></param>
        private void SetTextMesssage(int ipos, string vinfo)
        {
            if (this.InvokeRequired)
            {
                SetPos setpos = new SetPos(SetTextMesssage);
                this.Invoke(setpos, new object[] { ipos, vinfo });
            }
            else
            {
                this.txtLog.AppendText(vinfo);
            }
        }

        private void AddPath_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog folder = new System.Windows.Forms.FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                this.directory = folder.SelectedPath;
                this.txtDirPath.Text = this.directory;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (fileList != null && fileList.Count > 0)
            {
                num = 0;
                this.txtLog.Text = "";
                this.panelCopyright.Visible = false;
                //创建线程
                new Thread(new ThreadStart(this.PerformTask)) { IsBackground = true }.Start();
            }
            else
            {
                MessageBox.Show("请先拖拽要删除的文件到软件上");
            }

        }

        private void labelUrl_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.zy13.net");
        }

    }

}
