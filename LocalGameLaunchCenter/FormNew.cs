using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace LocalGameLaunchCenter
{
    public partial class FormNew : Form
    {
        //保存临时日志信息
        string thisLog = null;

        public FormNew()
        {
            InitializeComponent();
        }

        private void FormNew_Load(object sender, EventArgs e)
        {
            //判断程序是否需要进行初始化部署
            if (System.IO.File.Exists("AppConfig.xml"))
            {
                //如果文件正常则常规启动程序
                this.Hide();
                new FormMain().ShowDialog();
            }
            else
            {
                //填充日志信息
                richTextBoxTip.Text = "";
                richTextBoxTip.Text += DateTime.Now + " ---- 等待用户确认......\n" + thisLog;
            }
        }

        /// <summary>
        /// 退出程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 执行资源释放方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (buttonOK.Text == "退出程序")
            {
                Application.Exit();
            }
            else
            {
                //初始化填充日志信息
                thisLog = richTextBoxTip.Text;
                richTextBoxTip.Text = "";
                richTextBoxTip.Text += DateTime.Now + " ---- 用户已确认，执行程序所需资源释放进程，请稍等......\n" + thisLog;
                //禁用相关按键
                buttonOK.Enabled = false;
                buttonExit.Enabled = false;
                //执行资源释放方法
                ResourceRelease();
                //执行完成后填充确认信息
                thisLog = richTextBoxTip.Text;
                richTextBoxTip.Text = "";
                richTextBoxTip.Text += DateTime.Now + " ---- 操作已完成!! 请点击退出程序，重新运行程序即可正常使用。\n" + thisLog;
                //启用相关按键
                buttonOK.Text = "退出程序";
                buttonOK.Enabled = true;
            }
        }

        /// <summary>
        /// 资源释放方法
        /// </summary>
        public void ResourceRelease()
        {
            //判断相关文件夹是否存在，如果不存在就创建文件夹
            if (Directory.Exists("MyDateFiles") == false)   //我的数据文件夹
            {
                Directory.CreateDirectory("MyDateFiles");
            }
            if (Directory.Exists(@"Resource\images\PC") == false)       //封面图片相关文件夹
            {
                Directory.CreateDirectory(@"Resource\images\PC");
            }
            if (Directory.Exists(@"Resource\images\Emulator") == false)
            {
                Directory.CreateDirectory(@"Resource\images\Emulator");
            }
            if (Directory.Exists(@"Resource\ExplanatoryText\PC") == false)     //简介文本存放文件夹
            {
                Directory.CreateDirectory(@"Resource\ExplanatoryText\PC");
            }
            if (Directory.Exists(@"Resource\ExplanatoryText\Emulator") == false)
            {
                Directory.CreateDirectory(@"Resource\ExplanatoryText\Emulator");
            }
            if (Directory.Exists(@"Shortcut\PC") == false)     //快捷方式相关文件夹
            {
                Directory.CreateDirectory(@"Shortcut\PC");
            }
            if (Directory.Exists(@"Shortcut\Emulator") == false)
            {
                Directory.CreateDirectory(@"Shortcut\Emulator");
            }
            if (Directory.Exists(@"ProgramData\Backup") == false)      //程序数据，备份文件夹
            {
                Directory.CreateDirectory(@"ProgramData\Backup");
            }
            if (Directory.Exists(@"ProgramData\DefaultData") == false)      //程序数据，默认数据文件夹
            {
                Directory.CreateDirectory(@"ProgramData\DefaultData");
            }
            if (Directory.Exists(@"ProgramData\DefalutImage") == false)      //程序数据，默认显示图片文件夹
            {
                Directory.CreateDirectory(@"ProgramData\DefalutImage");
            }
            if (Directory.Exists(@"Resource\PCModifier") == false)      //资源数据，PC游戏修改存放文件夹
            {
                Directory.CreateDirectory(@"Resource\PCModifier");
            }
            if (Directory.Exists(@"ProgramData\PCSaveBackup") == false)      //程序数据，PC游戏存档备份文件夹
            {
                Directory.CreateDirectory(@"ProgramData\PCSaveBackup");
            }
            if (Directory.Exists(@"Cache") == false)      //缓存文件夹
            {
                Directory.CreateDirectory(@"Cache");
            }

            //判断相关Xml文档是否存在，如果不存在则创建对应的Xml文档
            XmlDocument xmlDoc;
            XmlNode node;
            XmlElement xm;

            if (Directory.Exists("AppConfig.xml") == false)     //创建主程序配置信息
            {
                xmlDoc = new XmlDocument();
                //创建类型声明
                node = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", "");
                xmlDoc.AppendChild(node);
                //创建父节点
                XmlNode MainSettings = xmlDoc.CreateElement("MainSettings");
                xmlDoc.AppendChild(MainSettings);

                //创建子节点，写入值
                XmlElement PathConfig = xmlDoc.CreateElement("PathConfig");
                MainSettings.InsertBefore(PathConfig, MainSettings.LastChild);

                XmlElement MyDateFiles = xmlDoc.CreateElement("MyDateFiles");
                MyDateFiles.InnerText = @"MyDateFiles\";
                PathConfig.InsertBefore(MyDateFiles, PathConfig.LastChild);

                XmlElement PCImg = xmlDoc.CreateElement("PCImg");
                PCImg.InnerText = @"Resource\images\PC\";
                PathConfig.InsertBefore(PCImg, PathConfig.LastChild);

                XmlElement EmuImg = xmlDoc.CreateElement("EmuImg");
                EmuImg.InnerText = @"Resource\images\Emulator\";
                PathConfig.InsertBefore(EmuImg, PathConfig.LastChild);

                XmlElement PCContent = xmlDoc.CreateElement("PCContent");
                PCContent.InnerText = @"Resource\ExplanatoryText\PC\";
                PathConfig.InsertBefore(PCContent, PathConfig.LastChild);

                XmlElement EmuContent = xmlDoc.CreateElement("EmuContent");
                EmuContent.InnerText = @"Resource\ExplanatoryText\Emulator\";
                PathConfig.InsertBefore(EmuContent, PathConfig.LastChild);

                XmlElement PCShortcut = xmlDoc.CreateElement("PCShortcut");
                PCShortcut.InnerText = @"Shortcut\PC\";
                PathConfig.InsertBefore(PCShortcut, PathConfig.LastChild);

                XmlElement EmuShortcut = xmlDoc.CreateElement("EmuShortcut");
                EmuShortcut.InnerText = @"Shortcut\Emulator\";
                PathConfig.InsertBefore(EmuShortcut, PathConfig.LastChild);

                XmlElement BackupData = xmlDoc.CreateElement("BackupData");
                BackupData.InnerText = @"ProgramData\Backup\";
                PathConfig.InsertBefore(BackupData, PathConfig.LastChild);

                XmlElement DefaultData = xmlDoc.CreateElement("DefaultData");
                DefaultData.InnerText = @"ProgramData\DefaultData\";
                PathConfig.InsertBefore(DefaultData, PathConfig.LastChild);

                XmlElement DefaultImage = xmlDoc.CreateElement("DefaultImage");
                DefaultImage.InnerText = @"ProgramData\DefalutImage\";
                PathConfig.InsertBefore(DefaultImage, PathConfig.LastChild);

                XmlElement PCModifier = xmlDoc.CreateElement("PCModifier");
                PCModifier.InnerText = @"Resource\PCModifier\";
                PathConfig.InsertBefore(PCModifier, PathConfig.LastChild);

                XmlElement PCSaveBackup = xmlDoc.CreateElement("PCSaveBackup");
                PCSaveBackup.InnerText = @"ProgramData\PCSaveBackup\";
                PathConfig.InsertBefore(PCSaveBackup, PathConfig.LastChild);

                XmlElement Cache = xmlDoc.CreateElement("Cache");
                Cache.InnerText = @"Cache\";
                PathConfig.InsertBefore(Cache, PathConfig.LastChild);

                xmlDoc.Save("AppConfig.xml");
            }

            if (Directory.Exists("PCPath.xml") == false)     //创建PC数据显示信息
            {
                xmlDoc = new XmlDocument();
                //创建类型声明
                node = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", "");
                xmlDoc.AppendChild(node);
                //创建父节点
                node = xmlDoc.CreateElement("PCMenu");
                xmlDoc.AppendChild(node);
                //创建子节点，写入值
                xm = xmlDoc.CreateElement("PCPath");   //新建节点
                xm.SetAttribute("GameName", "测试数据");
                xm.SetAttribute("GameType", "动作");
                xm.SetAttribute("GamePath", @"E:\PCGame\");
                xm.SetAttribute("SavePath", @"E:\PCGame\Saves\");
                xm.SetAttribute("StartName", "start.exe");
                node.InsertBefore(xm, node.FirstChild);  //插入到第一个位置
                xmlDoc.Save("PCPath.xml");
            }

            if (Directory.Exists("EmuPath.xml") == false)     //创建Emu数据显示信息
            {
                xmlDoc = new XmlDocument();
                //创建类型声明
                node = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", "");
                xmlDoc.AppendChild(node);
                //创建父节点
                node = xmlDoc.CreateElement("EmuMenu");
                xmlDoc.AppendChild(node);
                //创建子节点，写入值
                xm = xmlDoc.CreateElement("EmuPath");   //新建节点
                xm.SetAttribute("name", "测试数据");
                xm.SetAttribute("GamePath", @"E:\EmuGame\");
                xm.SetAttribute("FilePath", @"E:\Emu\");
                xm.SetAttribute("EmuName", @"emuStart.exe");
                xm.SetAttribute("Explain", "模拟器平台信息");
                node.InsertBefore(xm, node.FirstChild);  //插入到第一个位置
                xmlDoc.Save("EmuPath.xml");
            }

            if (Directory.Exists("UserConfig.xml") == false)        //创建用户数据信息
            {
                xmlDoc = new XmlDocument();
                //创建类型声明
                node = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", "");
                xmlDoc.AppendChild(node);
                //创建父节点
                node = xmlDoc.CreateElement("UsersInformation");
                xmlDoc.AppendChild(node);
                //创建子节点，写入值
                xm = xmlDoc.CreateElement("Users");   //新建节点
                xm.SetAttribute("uName", "Admin");
                xm.SetAttribute("uSex", "男");
                xm.SetAttribute("uTitle", "游戏大师");
                xm.SetAttribute("runCount", "0");
                node.InsertBefore(xm, node.FirstChild);  //插入到第一个位置
                xmlDoc.Save("UserConfig.xml");
            }

            //判断程序所需文件是否存在，如果不存在则创建对应的Xml文档
            if (File.Exists(@"ProgramData\DefalutImage\Emu.jpg") == false)     //默认显示的封面图片文件
            {
                ResourceApp.Emu.Save(@"ProgramData\DefalutImage\Emu.jpg");
            }
            if (File.Exists(@"ProgramData\DefalutImage\PC.jpg") == false)
            {
                ResourceApp.PC.Save(@"ProgramData\DefalutImage\PC.jpg");
            }

        }


    }
}
