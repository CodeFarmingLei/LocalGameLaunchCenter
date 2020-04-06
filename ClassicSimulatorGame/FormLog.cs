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
    public partial class FormLog : Form
    {
        public FormLog()
        {
            InitializeComponent();
        }

        private void FormLog_Load(object sender, EventArgs e)
        {
            LoadLog();
        }

        /// <summary>
        /// 读取程序运行日志信息
        /// </summary>
        public void LoadLog()
        {
            FileStream myFs = new FileStream(Application.StartupPath + @"\Functionlog.txt", FileMode.OpenOrCreate);
            //创建读取器
            StreamReader mySr = new StreamReader(myFs, Encoding.GetEncoding("UTF-8"));
            richTextBoxLog.Text = mySr.ReadToEnd();  //读取整个文本文档并写入到控件
            toolStripStatusLabelRowsCount.Text = (richTextBoxLog.Lines.Count()).ToString();
            mySr.Close();   //关闭读取器
            myFs.Close();   //关闭文件流
        }

        /// <summary>
        /// 清空程序运行日志信息
        /// </summary>
        public void ClearLog()
        {
            //将当前日志写入本地文本
            FileStream creFs = new FileStream(Application.StartupPath + @"\Functionlog.txt", FileMode.Create);
            StreamWriter creSw = new StreamWriter(creFs);
            creSw.Write("");  //清空文本
            creSw.Close();   //关闭写入器
            creFs.Close();   //关闭文件流
            richTextBoxLog.Text = "";   //清空控件显示
            toolStripStatusLabelRowsCount.Text = (richTextBoxLog.Lines.Count()).ToString();
            MessageBox.Show("清空成功!!","提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }

        /// <summary>
        /// 刷新显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            LoadLog();
            DialogResult dr = MessageBox.Show("刷新成功!!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        /// <summary>
        /// 清空日志操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripButtonClear_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否清除日志数据？？","确认操作",MessageBoxButtons.OKCancel,MessageBoxIcon.Asterisk);
            if (dr == DialogResult.OK)
            {
                ClearLog();
            }
        }
    }
}
