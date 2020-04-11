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
    public partial class FormEditPC : Form
    {
        //获取传递的数据
        public string GameName;        //游戏名称
        public string GameType;         //游戏类型
        public string GamePath;         //游戏所在路径
        public string SavePath;           //游戏存档路径
        public string StartName;        //启动程序名称

        public FormEditPC()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 初始化加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEditPC_Load(object sender, EventArgs e)
        {
            //填充数据文本
            textBoxGameName.Text = GameName;
            textBoxGameType.Text = GameType;
            textBoxGamePath.Text = GamePath;
            textBoxSavePath.Text = SavePath;
            textBoxStartName.Text = StartName;
        }

        /// <summary>
        /// 选择游戏启动程序路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonGamePath_Click(object sender, EventArgs e)
        {
            folderBrowserDialogPath.ShowDialog();
            textBoxGamePath.Text = folderBrowserDialogPath.SelectedPath + @"\";
        }

        /// <summary>
        /// 选择游戏存档路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSavePath_Click(object sender, EventArgs e)
        {
            folderBrowserDialogPath.ShowDialog();
            textBoxSavePath.Text = folderBrowserDialogPath.SelectedPath + @"\";
        }

        /// <summary>
        /// 选择启动程序执行文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonStartName_Click(object sender, EventArgs e)
        {
            openFileDialogStartName.ShowDialog();
            textBoxStartName.Text = openFileDialogStartName.SafeFileName;
        }

        /// <summary>
        /// 清空控件数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            textBoxGameName.Text = textBoxGameType.Text = textBoxGamePath.Text = textBoxSavePath.Text = textBoxStartName.Text = null;
        }

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("PCPath.xml");   //加载配置xml文件
            XmlNode xNode = xmlDoc.SelectSingleNode("PCMenu");   //读取配置节点
            foreach (XmlNode node in xNode)
            {
                //保存信息
                XmlElement xm = (XmlElement)node;
                if (xm.GetAttribute("GameName") == GameName)
                {
                    xm.SetAttribute("GameName", textBoxGameName.Text);
                    xm.SetAttribute("GameType", textBoxGameType.Text);
                    xm.SetAttribute("GamePath", textBoxGamePath.Text);
                    xm.SetAttribute("SavePath", textBoxSavePath.Text);
                    xm.SetAttribute("StartName", textBoxStartName.Text);
                    break;
                }
            }
            xmlDoc.Save("PCPath.xml");   //保存配置xml文件
            MessageBox.Show("数据保存成功!! \n重新打开程序或者刷新数据即可查看更新的内容。","提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }

        
    }
}
