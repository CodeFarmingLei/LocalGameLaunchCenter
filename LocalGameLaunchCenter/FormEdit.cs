using CCWin;
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
    public partial class FormEdit : CCSkinMain
    {
        #region 此窗体控制变量
        public string TypeName = "PC";      //要编辑数据的类型，共PC&Emu两个选项，默认为PC。
        #endregion

        #region PC相关变量
        //获取传递的数据
        public string PCGameName;        //游戏名称
        public string PCGameType;         //游戏类型
        public string PCGamePath;         //游戏所在路径
        public string PCSavePath;           //游戏存档路径
        public string PCStartName;        //启动程序名称
        #endregion

        #region Emu相关变量
        //获取传递的数据
        public string EmuName;             //模拟器名称
        public string EmuGamePath;     //游戏ROM路径
        public string EmuFilePath;         //模拟器所在路径
        public string EmuStartName;     //模拟器启动程序名称
        public string EmuExplain;          //模拟器简介
        #endregion

        public FormEdit()
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
            //优先验证要更改的Xml文件是否存在
            if (!(System.IO.File.Exists("PCPath.xml") || System.IO.File.Exists("EmuPath.xml")))
            {
                MessageBox.Show("用于存储数据的Xml文件丢失!!\n请使用主程序的修复功能来修复此文件。\n点击确定关闭此窗口。", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            //判断传递的数据类型，分别填充数据文本
            if (TypeName == "PC")
            {
                this.Text = "编辑数据 ---- 【"+TypeName+"】";     //更新标题栏文本
                skinTabControlType.SelectedTab = skinTabPagePC;
                skinTabControlType.TabPages.Remove(skinTabPageEmu); //禁用Emu选项卡
                textBoxGameName.Text = PCGameName;
                textBoxGameType.Text = PCGameType;
                textBoxGamePath.Text = PCGamePath;
                textBoxSavePath.Text = PCSavePath;
                textBoxStartName.Text = PCStartName;
            }
            else if (TypeName == "Emu")
            {
                this.Text = "编辑数据 ---- 【" + TypeName + "】";     //更新标题栏文本
                skinTabControlType.SelectedTab = skinTabPageEmu;
                skinTabControlType.TabPages.Remove(skinTabPagePC); //禁用PC选项卡
                textBoxName.Text = EmuName;
                textBoxRomPath.Text = EmuGamePath;
                textBoxFilePath.Text = EmuFilePath;
                textBoxEmuName.Text = EmuStartName;
                textBoxExplain.Text = EmuExplain;
            }
        }

        /// <summary>
        /// 选择PC游戏启动程序路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonGamePath_Click(object sender, EventArgs e)
        {
            //按下确定选择的按钮
            if (folderBrowserDialogPath.ShowDialog() == DialogResult.OK)
            {
                //记录选中的目录
                textBoxGamePath.Text = folderBrowserDialogPath.SelectedPath + @"\";
            }
        }

        /// <summary>
        /// 选择PC游戏存档路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSavePath_Click(object sender, EventArgs e)
        {
            //按下确定选择的按钮
            if (folderBrowserDialogPath.ShowDialog() == DialogResult.OK)
            {
                //记录选中的目录
                textBoxSavePath.Text = folderBrowserDialogPath.SelectedPath + @"\";
            }
        }

        /// <summary>
        /// 选择PC启动程序执行文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonStartName_Click(object sender, EventArgs e)
        {
            //按下确定选择的按钮
            if (openFileDialogStartName.ShowDialog() == DialogResult.OK)
            {
                //记录选中的目录
                textBoxStartName.Text = openFileDialogStartName.SafeFileName;
            }
        }

        /// <summary>
        /// 选择模拟器启动程序路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEmuFilePath_Click(object sender, EventArgs e)
        {
            //按下确定选择的按钮
            if (folderBrowserDialogPath.ShowDialog() == DialogResult.OK)
            {
                //记录选中的目录
                textBoxFilePath.Text = folderBrowserDialogPath.SelectedPath + @"\";
            }
        }

        /// <summary>
        /// 选择模拟器启动执行程序文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEmuName_Click(object sender, EventArgs e)
        {
            //按下确定选择的按钮
            if (openFileDialogStartName.ShowDialog() == DialogResult.OK)
            {
                //记录选中的目录
                textBoxEmuName.Text = openFileDialogStartName.SafeFileName;
            }
        }

        /// <summary>
        /// 选择模拟器游戏ROM路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEmuGamePath_Click(object sender, EventArgs e)
        {
            //按下确定选择的按钮
            if (folderBrowserDialogPath.ShowDialog() == DialogResult.OK)
            {
                //记录选中的目录
                textBoxGamePath.Text = folderBrowserDialogPath.SelectedPath + @"\";
            }
        }

        /// <summary>
        /// 清空控件数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            if (TypeName == "PC")
            {
                textBoxGameName.Text = textBoxGameType.Text = textBoxGamePath.Text = textBoxSavePath.Text = textBoxStartName.Text = null;
            }
            else if (TypeName == "Emu")
            {
                textBoxName.Text = textBoxFilePath.Text = textBoxEmuName.Text = textBoxRomPath.Text = textBoxExplain.Text = null;
            }
        }

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            //判断类型，对每个类型进行单独的保存操作
            XmlDocument xmlDoc = new XmlDocument();
            if (TypeName == "PC")
            {
                xmlDoc.Load("PCPath.xml");   //加载配置xml文件
                XmlNode xNode = xmlDoc.SelectSingleNode("PCMenu");   //读取配置节点
                foreach (XmlNode node in xNode)
                {
                    //保存信息
                    XmlElement xm = (XmlElement)node;
                    if (xm.GetAttribute("GameName") == PCGameName)
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
            }
            else if (TypeName == "Emu")
            {
                xmlDoc.Load("EmuPath.xml");   //加载配置xml文件
                XmlNode xNode = xmlDoc.SelectSingleNode("EmuMenu");   //读取配置节点
                foreach (XmlNode node in xNode)
                {
                    //保存信息
                    XmlElement xm = (XmlElement)node;
                    if (xm.GetAttribute("name") == EmuName)
                    {
                        xm.SetAttribute("name", textBoxName.Text);
                        xm.SetAttribute("GamePath", textBoxRomPath.Text);
                        xm.SetAttribute("FilePath", textBoxFilePath.Text);
                        xm.SetAttribute("EmuName", textBoxEmuName.Text);
                        xm.SetAttribute("Explain", textBoxExplain.Text);
                        break;
                    }
                }
                xmlDoc.Save("EmuPath.xml");   //保存配置xml文件
            }
            MessageBox.Show("数据保存成功!! \n重新打开程序或者刷新数据即可查看更新的内容。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();   //关闭此窗口
        }

        
    }
}
