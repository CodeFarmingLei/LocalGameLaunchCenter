using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace LocalGameLaunchCenter
{
    public partial class FormEditEmu : Form
    {
        //获取传递的数据
        public string name;             //模拟器名称
        public string GamePath;     //游戏ROM路径
        public string FilePath;         //模拟器所在路径
        public string EmuName;     //模拟器启动程序名称
        public string Explain;          //模拟器简介

        public FormEditEmu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 初始化加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEditEmu_Load(object sender, EventArgs e)
        {
            //填充数据文本
            textBoxName.Text = name;
            textBoxGamePath.Text = GamePath;
            textBoxFilePath.Text = FilePath;
            textBoxEmuName.Text = EmuName;
            textBoxExplain.Text = Explain;
        }

        /// <summary>
        /// 选择模拟器启动程序路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonFilePath_Click(object sender, EventArgs e)
        {
            folderBrowserDialogPath.ShowDialog();
            textBoxFilePath.Text = folderBrowserDialogPath.SelectedPath + @"\";
        }

        /// <summary>
        /// 选择启动执行程序文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEmuName_Click(object sender, EventArgs e)
        {
            openFileDialogStartName.ShowDialog();
            textBoxEmuName.Text = openFileDialogStartName.SafeFileName;
        }

        /// <summary>
        /// 选择游戏ROM路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonGamePath_Click(object sender, EventArgs e)
        {
            folderBrowserDialogPath.ShowDialog();
            textBoxGamePath.Text = folderBrowserDialogPath.SelectedPath + @"\";
        }

        /// <summary>
        /// 清空控件数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            textBoxName.Text = textBoxFilePath.Text = textBoxEmuName.Text = textBoxEmuName.Text = textBoxExplain.Text = null;
        }

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("EmuPath.xml");   //加载配置xml文件
            XmlNode xNode = xmlDoc.SelectSingleNode("EmuMenu");   //读取配置节点
            foreach (XmlNode node in xNode)
            {
                //保存信息
                XmlElement xm = (XmlElement)node;
                if (xm.GetAttribute("name") == name)
                {
                    xm.SetAttribute("name", textBoxName.Text);
                    xm.SetAttribute("GamePath", textBoxGamePath.Text);
                    xm.SetAttribute("FilePath", textBoxFilePath.Text);
                    xm.SetAttribute("EmuName", textBoxEmuName.Text);
                    xm.SetAttribute("Explain", textBoxExplain.Text);
                    break;
                }
            }
            xmlDoc.Save("EmuPath.xml");   //保存配置xml文件
            MessageBox.Show("数据保存成功!! \n重新打开程序或者刷新数据即可查看更新的内容。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
