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
using System.Xml;

namespace LocalGameLaunchCenter
{
    public partial class FormEdit : CCSkinMain
    {
        #region 此窗体控制变量
        public string Pattern = "编辑数据";      //当前窗口操作模式，共编辑数据和新建数据两个选项，默认为编辑数据。
        public string TypeName = "PC";      //要编辑数据的类型，共PC&Emu两个选项，默认为PC。
        public string ImgFilePath = null;         //存储原始图片数据路径
        public string TxtFilePath = null;         //存储原始简介文本数据路径
        public string TextContent = null;         //存储简介文本内容数据
        public string OpenFileStr = null;         //记录打开的文件路径，文件名，扩展名
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
            //判断当前窗体操作模式，编辑或新建
            if (Pattern == "编辑数据")
            {
                this.Text = "编辑数据 ---- ";     //更新标题栏文本

                //判断传递的数据类型，分别填充数据文本
                if (TypeName == "PC")
                {
                    this.Text += "【" + TypeName + "】";     //更新标题栏文本
                    skinTabControlType.SelectedTab = skinTabPagePC;
                    skinTabControlType.TabPages.Remove(skinTabPageEmu); //禁用Emu选项卡
                    textBoxGameName.Text = PCGameName;
                    textBoxGameType.Text = PCGameType;
                    textBoxGamePath.Text = PCGamePath;
                    textBoxSavePath.Text = PCSavePath;
                    textBoxStartName.Text = PCStartName;
                    if (!(System.IO.Directory.Exists(ImgFilePath)))
                    {
                        skinPictureBoxPCImg.Load(ImgFilePath);
                    }
                    skinTextBoxPCTip.Text = TextContent;
                }
                else if (TypeName == "Emu")
                {
                    this.Text += "【" + TypeName + "】";     //更新标题栏文本
                    skinTabControlType.SelectedTab = skinTabPageEmu;
                    skinTabControlType.TabPages.Remove(skinTabPagePC); //禁用PC选项卡
                    textBoxName.Text = EmuName;
                    textBoxRomPath.Text = EmuGamePath;
                    textBoxFilePath.Text = EmuFilePath;
                    textBoxEmuName.Text = EmuStartName;
                    textBoxExplain.Text = EmuExplain;
                    if (!(System.IO.Directory.Exists(ImgFilePath)))
                    {
                        skinPictureBoxEmuImg.Load(ImgFilePath);
                    }
                    skinTextBoxEmuTip.Text = TextContent;
                }
            }
            else if (Pattern == "新增数据")
            {
                this.Text = "新增数据 ---- ";     //更新标题栏文本
                //判断传递的数据类型，分别填充数据文本
                if (TypeName == "PC")
                {
                    this.Text += "【" + TypeName + "】";     //更新标题栏文本
                    skinTabControlType.SelectedTab = skinTabPagePC;
                    skinTabControlType.TabPages.Remove(skinTabPageEmu); //禁用Emu选项卡
                }
                else if (TypeName == "Emu")
                {
                    this.Text += "【" + TypeName + "】";     //更新标题栏文本
                    skinTabControlType.SelectedTab = skinTabPageEmu;
                    skinTabControlType.TabPages.Remove(skinTabPagePC); //禁用PC选项卡
                }
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
            //判断当前窗体操作模式，编辑或新建
            if (Pattern == "编辑数据")
            {
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

                    //创建文件流
                    FileStream myFs = new FileStream(TxtFilePath, FileMode.Create);

                    //创建写入器
                    StreamWriter mySw = new StreamWriter(myFs);
                    mySw.Write("");  //清空原始文本
                    mySw.Write(skinTextBoxPCTip.Text);  //将控件文本写入文件
                    mySw.Close();   //关闭写入器
                    myFs.Close();   //关闭文件流

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

                    //创建文件流
                    FileStream myFs = new FileStream(TxtFilePath, FileMode.Create);

                    //创建写入器
                    StreamWriter mySw = new StreamWriter(myFs);
                    mySw.Write("");  //清空原始文本
                    mySw.Write(skinTextBoxEmuTip.Text);  //将控件文本写入文件
                    mySw.Close();   //关闭写入器
                    myFs.Close();   //关闭文件流
                }
                MessageBox.Show("数据保存成功!! \n重新打开程序或者刷新数据即可查看更新的内容。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();   //关闭此窗口
            }
            else if (Pattern == "新增数据")
            {
                if (TypeName == "PC")
                {
                    xmlDoc.Load("PCPath.xml");   //加载配置xml文件
                    XmlNode xNode = xmlDoc.SelectSingleNode("PCMenu");   //读取配置节点
                    XmlElement xm = xmlDoc.CreateElement("PCPath");   //新建节点
                    xm.SetAttribute("GameName", textBoxGameName.Text);
                    xm.SetAttribute("GameType", textBoxGameType.Text);
                    xm.SetAttribute("GamePath", textBoxGamePath.Text);
                    xm.SetAttribute("SavePath", textBoxSavePath.Text);
                    xm.SetAttribute("StartName", textBoxStartName.Text);
                    xNode.InsertBefore(xm,xNode.FirstChild);  //插入到第一个位置
                    xmlDoc.Save("PCPath.xml");   //保存配置xml文件

                    //保存文本
                    FileStream myFs = new FileStream(TxtFilePath + textBoxGameName.Text+@".txt", FileMode.Create);
                    StreamWriter mySw = new StreamWriter(myFs);
                    mySw.Write(skinTextBoxPCTip.Text);  //将控件文本写入文件
                    mySw.Close();   //关闭写入器
                    myFs.Close();   //关闭文件流

                    //保存图片
                    File.Copy(OpenFileStr, ImgFilePath + textBoxGameName.Text + @".jpg", true);
                }
                else if (TypeName == "Emu")
                {
                    xmlDoc.Load("EmuPath.xml");   //加载配置xml文件
                    XmlNode xNode = xmlDoc.SelectSingleNode("EmuMenu");   //读取配置节点
                    XmlElement xm = xmlDoc.CreateElement("EmuPath");   //新建节点
                    xm.SetAttribute("name", textBoxName.Text);
                    xm.SetAttribute("GamePath", textBoxRomPath.Text);
                    xm.SetAttribute("FilePath", textBoxFilePath.Text);
                    xm.SetAttribute("EmuName", textBoxEmuName.Text);
                    xm.SetAttribute("Explain", textBoxExplain.Text);
                    xNode.InsertBefore(xm, xNode.FirstChild);  //插入到第一个位置
                    xmlDoc.Save("EmuPath.xml");   //保存配置xml文件

                    //保存文本
                    FileStream myFs = new FileStream(TxtFilePath + textBoxName.Text + @".txt", FileMode.Create);
                    StreamWriter mySw = new StreamWriter(myFs);
                    mySw.Write(skinTextBoxEmuTip.Text);  //将控件文本写入文件
                    mySw.Close();   //关闭写入器
                    myFs.Close();   //关闭文件流

                    //保存图片
                    File.Copy(OpenFileStr, ImgFilePath + textBoxName.Text + @".jpg", true);
                }
                MessageBox.Show("数据新增成功!! \n重新打开程序或者刷新数据即可查看更新的内容。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();   //关闭此窗口
            }
            
        }

        /// <summary>
        /// 更改PC封面图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SkinButtonUpdatePCImg_Click(object sender, EventArgs e)
        {
            //按下确定选择的按钮
            if (openFileDialogImg.ShowDialog() == DialogResult.OK)
            {
                //记录选中的目录
                OpenFileStr = Path.GetDirectoryName(openFileDialogImg.FileName) + @"\" + openFileDialogImg.SafeFileName;    //保存位置字符串
                skinPictureBoxPCImg.Load(OpenFileStr);
            }
        }

        /// <summary>
        /// 更改模拟器封面图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SkinButtonUpdateEmuImg_Click(object sender, EventArgs e)
        {
            //按下确定选择的按钮
            if (openFileDialogImg.ShowDialog() == DialogResult.OK)
            {
                //记录选中的目录
                OpenFileStr = Path.GetDirectoryName(openFileDialogImg.FileName) + @"\" + openFileDialogImg.SafeFileName;    //保存位置字符串
                skinPictureBoxEmuImg.Load(OpenFileStr);
            }
        }
    }
}
