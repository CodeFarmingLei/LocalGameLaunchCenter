using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocalGameLaunchCenter
{
    public partial class FormExit : CCSkinMain
    {
        public string usedLogText;              //存储历史已生成的临时日志
        public string thisLogText;               //存储当前运行已生成的临时日志
        public DateTime StartDate;             //存储程序启动时间
        public DateTime ExitDate;              //存储程序退出时间

        /// <summary>
        /// 保存程序运行日志信息
        /// </summary>
        public void SaveLog()
        {
            //读取本地日志文件
            FileStream loadFs = new FileStream(Application.StartupPath + @"\Functionlog.txt", FileMode.OpenOrCreate);
            StreamReader loadSr = new StreamReader(loadFs, Encoding.GetEncoding("UTF-8"));
            usedLogText = loadSr.ReadToEnd();  //读取整个文本文档
            loadSr.Close();   //关闭读取器
            loadFs.Close();  //关闭文件流

            FileStream creFs = new FileStream(Application.StartupPath + @"\Functionlog.txt", FileMode.Create);
            StreamWriter creSw = new StreamWriter(creFs);
            creSw.Write("");    //清空一次本地日志文本，避免数据冗余
            creSw.Write(thisLogText + "\n" + usedLogText);  //将控件文本写入文件
            creSw.Close();   //关闭写入器
            creFs.Close();   //关闭文件流

            usedLogText = thisLogText = "";   //清空两个存储日志的字符串内容，避免二次启动后日志信息重复添加
        }

        public FormExit()
        {
            InitializeComponent();
        }

        private void FormExit_Load(object sender, EventArgs e)
        {
            ExitDate = DateTime.Now;     //设置当前启动时间
            string RunTime = (ExitDate - StartDate).Hours.ToString() + "小时" + (ExitDate - StartDate).Minutes.ToString() + "分钟" + (ExitDate - StartDate).Seconds.ToString() + "秒";
            skinLabelRunTime.Text += RunTime;
        }

        private void SkinButtonYes_Click(object sender, EventArgs e)
        {
            SaveLog();
            System.Environment.Exit(0);
        }

        private void SkinButtonNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
