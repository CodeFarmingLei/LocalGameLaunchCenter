using CCWin;
using LocalGameLaunchCenter;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Text;
using IWshRuntimeLibrary;

namespace ClassicSimulatorGame
{
    public partial class FormMain : CCSkinMain
    {
        //模拟器软件xml文档路径
        string emuPath = @"EmuPath.xml";
        //模拟器平台名称
        string platformName = null;
        //模拟器程序路径
        string EmuFilePath = null;
        //模拟器游戏ROM路径
        string GameFilePath = null;
        //模拟器程序文件名
        string emuName = null;
        //PC游戏xml文档路径
        string PCPath = @"PCPath.xml";
        //PC游戏名称
        string PCName = null;
        //PC游戏路径
        string PCFilePath = null;
        //PC游戏存档路径
        string PCGameFilePath = null;
        //PC启动程序文件名
        string PCStartExeName = null;
        //存储读取的简介文本
        public string content;
        //我的数据文件夹路径
        string MyDateFiles = null;
        //PC游戏快捷方式文件夹路径
        string PCShortcut = null;
        //模拟器游戏快捷方式文件夹路径
        string EmuShortcut = null;
        //临时日志存储字符串
        string thisLog = null;
        //临时内存表
        DataTable dt = new DataTable();

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //默认选中第一个选项卡
            skinTabControlSelect.SelectedTab = skinTabPagePC;
            FileCheck();        //初始化验证磁盘
            //初始化程序信息
            AppConfigs();
            SetEmuData();
            SetPCData();
            UserConfigs();
            //填充日志信息
            thisLog = richTextBoxLog.Text;
            richTextBoxLog.Text += DateTime.Now + " ---- 启动中心程序已运行";
            //测试图片显示
            //this.pictureBoxPC.Load(@"Resource\images\PC\DMC鬼泣.jpg");
        }

        /// <summary>
        /// 配置模拟器信息数据
        /// </summary>
        public void AppConfigs()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("AppConfig.xml");   //加载配置xml文件
            XmlNode xNode = xmlDoc.SelectSingleNode("MainSettings");   //读取配置节点
            foreach (XmlNode node in xNode)
            {
                //获取并设置我的数据文件夹路径
                MyDateFiles = node.SelectSingleNode("MyDateFiles").InnerText.Trim();
                //获取并设置PC游戏快捷方式文件夹路径
                PCShortcut = node.SelectSingleNode("PCShortcut").InnerText.Trim();
                //获取并设置模拟器游戏快捷方式文件夹路径
                EmuShortcut = node.SelectSingleNode("EmuShortcut").InnerText.Trim();
            }
        }

        /// <summary>
        /// 填充用户信息
        /// </summary>
        public void UserConfigs()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("UserConfig.xml");   //加载配置xml文件
            XmlNode xNode = xmlDoc.SelectSingleNode("UsersInformation");   //读取配置节点
            foreach (XmlNode node in xNode)
            {
                //填充用户信息
                XmlElement xm = (XmlElement)node;
                skinWaterTextBoxName.Text = xm.GetAttribute("uName");
                skinWaterTextBoxSex.Text = xm.GetAttribute("uSex");
                skinWaterTextBoxTitle.Text = xm.GetAttribute("uTitle");

                //增加游戏启动次数
                int count = Convert.ToInt32(xm.GetAttribute("runCount"));   //获取子节点项字符串并转换格式
                count++;     //次数加1
                xm.SetAttribute("runCount", count.ToString());  //替换子节点项字符串
                skinWaterTextBoxRunCount.Text = count.ToString();    //最后填充次数信息
            }
            xmlDoc.Save("UserConfig.xml");   //保存配置xml文件
        }

        /// <summary>
        /// 填充模拟器软件数据信息
        /// </summary>
        public void SetEmuData()
        {
            DataSet myds = new DataSet();
            myds.ReadXml(emuPath);
            skinDataGridViewEmu.DataSource = myds.Tables[0];
        }

        /// <summary>
        /// 填充PC软件数据信息
        /// </summary>
        public void SetPCData()
        {
            DataSet myds = new DataSet();
            myds.ReadXml(PCPath);
            dataGridViewPC.DataSource = myds.Tables[0];
        }

        /// <summary>
        /// 读取程序运行日志信息
        /// </summary>
        public void LoadLog()
        {
            FileStream myFs = new FileStream(Application.StartupPath+ @"\Functionlog.txt", FileMode.Open);
            //创建读取器
            StreamReader mySr = new StreamReader(myFs, Encoding.GetEncoding("UTF-8"));
            thisLog = mySr.ReadToEnd();  //读取整个文本文档
            richTextBoxLog.Text = thisLog; //将读取的文本写入到控件
            mySr.Close();   //关闭读取器
            myFs.Close();   //关闭文件流
        }

        /// <summary>
        /// 保存程序运行日志信息
        /// </summary>
        public void SaveLog()
        {
            //读取本地日志文件
            FileStream loadFs = new FileStream(Application.StartupPath + @"\Functionlog.txt", FileMode.OpenOrCreate);
            StreamReader loadSr = new StreamReader(loadFs, Encoding.GetEncoding("UTF-8"));
            thisLog = loadSr.ReadToEnd();  //读取整个文本文档
            loadSr.Close();   //关闭读取器
            loadFs.Close();  //关闭文件流

            //将当前日志写入本地文本
            FileStream creFs = new FileStream(Application.StartupPath + @"\Functionlog.txt", FileMode.Create);
            StreamWriter creSw = new StreamWriter(creFs);
            creSw.Write(richTextBoxLog.Text + "\n" + thisLog);  //将控件文本写入文件
            creSw.Close();   //关闭写入器
            creFs.Close();   //关闭文件流
        }

        /// <summary>
        /// 打开模拟器程序所在路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonFilePath_Click(object sender, EventArgs e)
        {
            EmuFilePath = this.skinDataGridViewEmu.SelectedRows[0].Cells[2].Value.ToString();
            if (Directory.Exists(EmuFilePath))
            {
                System.Diagnostics.Process.Start(EmuFilePath);
            }
            else
            {
                MessageBox.Show("本次打开异常，可能原因如下：\n1.要打开的路径或者文件不存在\n2.可能您修改了文件或文件夹的名称","打开异常",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }

        /// <summary>
        /// 打开相关游戏ROM文件路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRomFilePath_Click(object sender, EventArgs e)
        {
            GameFilePath = this.skinDataGridViewEmu.SelectedRows[0].Cells[1].Value.ToString();
            if (Directory.Exists(GameFilePath))
            {
                Process.Start(GameFilePath);
            }
            else
            {
                MessageBox.Show("本次打开异常，可能原因如下：\n1.要打开的路径或者文件不存在\n2.可能您修改了文件或文件夹的名称", "打开异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        /// <summary>
        /// 运行模拟器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            EmuFilePath = this.skinDataGridViewEmu.SelectedRows[0].Cells[2].Value.ToString();
            emuName = this.skinDataGridViewEmu.SelectedRows[0].Cells[3].Value.ToString();
            if (Directory.Exists(EmuFilePath) && System.IO.File.Exists(EmuFilePath+emuName))
            {
                this.WindowState = FormWindowState.Minimized;   //最小化
                Process.Start(EmuFilePath + @"\" + emuName);
                //填充日志信息
                thisLog = richTextBoxLog.Text;
                richTextBoxLog.Text = "";
                richTextBoxLog.Text += DateTime.Now + " ---- 程序已运行，进程名：" + emuName + "\n" + thisLog;
            }
            else
            {
                MessageBox.Show(@"本次打开异常，可能原因如下：\n1.要打开的路径或者文件不存在\n2.可能您修改了文件或文件夹的名称\n\n路径信息："+ EmuFilePath + ""+ emuName + "", "打开异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        /// <summary>
        /// 模拟器软件数据选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewEmu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            platformName = this.skinDataGridViewEmu.SelectedRows[0].Cells[0].Value.ToString();
            //设置资源文件路径
            string path = @"Resource\ExplanatoryText\Emulator";    //文件地址
            //设置图像路径
            string picName = @"Resource\images\Emulator\" + platformName + ".jpg";
            //设置提示文本路径
            string tipText = path + @"\" + platformName + ".txt";

            //验证所需文件是否存在
            if (System.IO.File.Exists(picName) && System.IO.File.Exists(tipText))
            {
                //填充图像
                this.pictureBoxEmu.Load(picName);
                //创建读取器
                StreamReader mySr = new StreamReader(tipText, Encoding.GetEncoding("UTF-8"));
                content = mySr.ReadToEnd();  //读取整个文本文档
                richTextBoxEmuTip.Text = content; //将读取的文本写入到控件
                mySr.Close();   //关闭读取器
            }
            else
            {
                richTextBoxEmuTip.Text = "读取异常!!! 资源文件可能不存在..."; //将提示的文本写入到控件
            }

        }

        /// <summary>
        /// 验证磁盘文件
        /// </summary>
        public void FileCheck()
        {
            //判断磁盘是否存在
            if (Directory.Exists(@"I:\"))
            {
                this.buttonRomFilePath.Enabled = true;
                this.buttonEmuFilePath.Enabled = true;
                this.buttonEmuStart.Enabled = true;
                this.toolStripStatusLabelResult.ForeColor = Color.Green;
                this.toolStripStatusLabelResult.Text = "已存在,可正常使用!!";
            }
            else
            {
                this.buttonRomFilePath.Enabled = false;
                this.buttonEmuFilePath.Enabled = false;
                this.buttonEmuStart.Enabled = false;
                this.toolStripStatusLabelResult.ForeColor = Color.Red;
                this.toolStripStatusLabelResult.Text = "未存在!! 请重新检测...";
            }
        }

        private void 程序功能ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 磁盘检测ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileCheck();
        }

        /// <summary>
        /// 验证游戏磁盘点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonTesting_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(@"I:\"))
            {
                FileCheck();
                MessageBox.Show("磁盘已插入,请尽情使用吧!!", "检测结果",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            else
            {
                FileCheck();
                MessageBox.Show("未检测到该磁盘，请插入磁盘后重新检测~", "检测结果", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        /// <summary>
        /// 打开我的数据文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMyFile_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(MyDateFiles))
            {
                System.Diagnostics.Process.Start(MyDateFiles);
            }
            else
            {
                MessageBox.Show("本次打开异常，可能原因如下：\n1.要打开的路径或者文件不存在\n2.可能您修改了文件或文件夹的名称 \n\n路径信息："+ MyDateFiles + "", "打开异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// 打开PC游戏快捷方式文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripButtonPC_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(PCShortcut))
            {
                System.Diagnostics.Process.Start(PCShortcut);
            }
            else
            {
                MessageBox.Show("本次打开异常，可能原因如下：\n1.要打开的路径或者文件不存在\n2.可能您修改了文件或文件夹的名称 \n\n路径信息：" + PCShortcut + "", "打开异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// 打开模拟器软件快捷方式文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripButtonEmu_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(EmuShortcut))
            {
                System.Diagnostics.Process.Start(EmuShortcut);
            }
            else
            {
                MessageBox.Show("本次打开异常，可能原因如下：\n1.要打开的路径或者文件不存在\n2.可能您修改了文件或文件夹的名称 \n\n路径信息：" + EmuShortcut + "", "打开异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// 打开PC游戏存档所在路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonPCSaveFilePath_Click(object sender, EventArgs e)
        {
            PCGameFilePath = this.dataGridViewPC.SelectedRows[0].Cells[3].Value.ToString();
            if (Directory.Exists(PCGameFilePath))
            {
                Process.Start(PCGameFilePath);
            }
            else
            {
                MessageBox.Show("本次打开异常，可能原因如下：\n1.要打开的路径或者文件不存在\n2.可能您修改了文件或文件夹的名称", "打开异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// 打开PC游戏文件所在路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonPCFilePath_Click(object sender, EventArgs e)
        {
            PCFilePath = this.dataGridViewPC.SelectedRows[0].Cells[2].Value.ToString();
            if (Directory.Exists(PCFilePath))
            {
                Process.Start(PCFilePath);
            }
            else
            {
                MessageBox.Show("本次打开异常，可能原因如下：\n1.要打开的路径或者文件不存在\n2.可能您修改了文件或文件夹的名称", "打开异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// 运行PC游戏 exe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonPCStart_Click(object sender, EventArgs e)
        {
            PCName = this.dataGridViewPC.SelectedRows[0].Cells[0].Value.ToString();
            PCFilePath = this.dataGridViewPC.SelectedRows[0].Cells[2].Value.ToString();
            PCStartExeName = this.dataGridViewPC.SelectedRows[0].Cells[4].Value.ToString();

            //部分游戏进行单独处理
            if (PCName.Equals("洛克人Zero_ZX遗产合集"))
            {
                MessageBox.Show("由于游戏的独特验证方式(会直接验证启动程序下的游戏目录文件)，通过此程序直接启动会出现异常。\n请在打开的目录下启动 MZZXLC_Start.exe 程序来启动游戏。", "此游戏启动提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                Process.Start(PCFilePath);
                this.WindowState = FormWindowState.Minimized;   //最小化
            }
            else if(PCName.Equals("死或生5：最后一战"))
            {
                MessageBox.Show("由于游戏的独特验证方式(会直接验证启动程序下的游戏目录文件)，通过此程序直接启动会出现异常。\n请在打开的目录下启动 Launcher.exe 程序来启动游戏。", "此游戏启动提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Process.Start(PCFilePath);
                //填充日志信息
                thisLog = richTextBoxLog.Text;
                richTextBoxLog.Text = "";
                richTextBoxLog.Text +=  DateTime.Now + " ---- 程序已运行，进程名：" + PCStartExeName + "\n"+ thisLog;
                this.WindowState = FormWindowState.Minimized;   //最小化
            }
            else    //常规启动
            {
                if (Directory.Exists(PCFilePath) && System.IO.File.Exists(PCFilePath + PCStartExeName))
                {
                    this.WindowState = FormWindowState.Minimized;   //最小化
                    Process.Start(PCFilePath + PCStartExeName);
                    //填充日志信息
                    thisLog = richTextBoxLog.Text;
                    richTextBoxLog.Text = "";
                    richTextBoxLog.Text += DateTime.Now + " ---- 程序已运行，进程名：" + PCStartExeName + "\n" + thisLog;
                }
                else
                {
                    MessageBox.Show("本次打开异常，可能原因如下：\n1.要打开的路径或者文件不存在\n2.可能您修改了文件或文件夹的名称\n\n路径信息：" + PCFilePath + "" + PCStartExeName + "", "打开异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void SkinTabControlSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// PC游戏选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewPC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PCName = this.dataGridViewPC.SelectedRows[0].Cells[0].Value.ToString();
            //设置资源文件路径
            string path = @"Resource\ExplanatoryText\PC";
            //设置图像路径
            string picName = @"Resource\images\PC\" + PCName + ".jpg";
            //设置提示文本路径
            string tipText = path + @"\" + PCName + ".txt";

            //验证所需文件是否存在
            if (System.IO.File.Exists(picName) && System.IO.File.Exists(tipText))
            {
                //填充图像
                this.pictureBoxPC.Load(picName);
                //创建读取器
                StreamReader mySr = new StreamReader(tipText, Encoding.GetEncoding("UTF-8"));
                content = mySr.ReadToEnd();  //读取整个文本文档
                richTextBoxPCTip.Text = content; //将读取的文本写入到控件
                mySr.Close();   //关闭读取器
            }
            else
            {
                richTextBoxPCTip.Text = "读取异常!!! 资源文件可能不存在..."; //将提示的文本写入到控件
            }
        }

        private void 微软常用运行库合集ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //调用IE浏览器  
            System.Diagnostics.Process.Start("iexplore.exe", "http://www.pc6.com/softview/SoftView_104246.html");
        }

        private void DX修复工具ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //调用IE浏览器  
            System.Diagnostics.Process.Start("iexplore.exe", "https://www.onlinedown.net/soft/120082.htm");
        }

        /// <summary>
        /// 获取并持续更新当前时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThisTimer_Tick(object sender, EventArgs e)
        {
            labelThisTime.Text = DateTime.Now.ToString();
        }

        /// <summary>
        /// 窗口最小化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_MinimumSizeChanged(object sender, EventArgs e)
        {
            //最小化时停止事件，避免消耗系统运存
            thisTimer.Enabled = false;
        }

        /// <summary>
        /// 窗口最大化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_MaximumSizeChanged(object sender, EventArgs e)
        {
            //最大化时启动时间显示事件
            thisTimer.Enabled = true;
        }

        /// <summary>
        /// 将此程序添加桌面快捷方式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 将本程序添加到桌面快捷方式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CreateDesktopShortcut(@"C:\Users\ZHANGLEI\Desktop", "本地游戏启动中心", Application.StartupPath+ @"\LocalGameLaunchCenter.exe") == true)
            {
                MessageBox.Show("快捷方式创建成功!!","提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("快捷方式创建失败...", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 创建桌面快捷方式
        /// </summary>
        /// <param name="deskTop">桌面的路径</param>
        /// <param name="FileName">文件的名称</param>
        /// <param name="exePath">EXE的路径</param>
        /// <returns>成功或失败</returns>
        public bool CreateDesktopShortcut(string deskTop, string FileName, string exePath)
        {
            try
            {
                deskTop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
                if (System.IO.File.Exists(deskTop + FileName + ".lnk"))  //
                {
                    System.IO.File.Delete(deskTop + FileName + ".lnk");//删除原来的桌面快捷键方式
                }
                WshShell shell = new WshShell();

                //快捷键方式创建的位置、名称
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(deskTop + FileName + ".lnk");
                shortcut.TargetPath = exePath; //目标文件
                //该属性指定应用程序的工作目录，当用户没有指定一个具体的目录时，快捷方式的目标应用程序将使用该属性所指定的目录来装载或保存文件。
                shortcut.WorkingDirectory = System.Environment.CurrentDirectory;
                shortcut.WindowStyle = 1; //目标应用程序的窗口状态分为普通、最大化、最小化【1,3,7】
                shortcut.Description = FileName; //描述
                shortcut.IconLocation = Application.StartupPath + "\\LocalGameLaunchCenter.ico";  //快捷方式图标
                shortcut.Arguments = "";
                //shortcut.Hotkey = "CTRL+ALT+F11"; // 快捷键
                shortcut.Save(); //必须调用保存快捷才成创建成功
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// 打开PC游戏快捷方式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SkinButtonPClnk_Click(object sender, EventArgs e)
        {
            PCName = this.dataGridViewPC.SelectedRows[0].Cells[0].Value.ToString();
            //设置快捷方式文件路径
            string lnkPath = @"Shortcut\PC\" + PCName + ".lnk";

            //验证所需文件是否存在
            if (System.IO.File.Exists(lnkPath))
            {
                this.WindowState = FormWindowState.Minimized;   //最小化
                Process.Start(lnkPath);
                //填充日志信息
                thisLog = richTextBoxLog.Text;
                richTextBoxLog.Text = "";
                richTextBoxLog.Text += DateTime.Now + " ---- 程序已运行，游戏名称：" + PCName + "\n" + thisLog;
            }
            else
            {
                MessageBox.Show("本次打开异常，可能原因如下：\n1.要打开的路径或者文件不存在\n2.可能您修改了文件或文件夹的名称 \n\n路径文件信息：" + lnkPath + "", "打开异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// 退出程序事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否退出本程序？？", "确认退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (dr == DialogResult.OK)
            {
                SaveLog();
                this.FormClosing -= new FormClosingEventHandler(this.FormMain_FormClosing);
                Application.Exit();
            }
            else if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void ToolStripButtonLog_Click(object sender, EventArgs e)
        {
            //打开历史日志信息窗口
            FormLog FormLog = new FormLog();
            FormLog.Show();
        }

        private void 获取最新版本程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("开发中，敬请期待","温馨提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }

        /// <summary>
        /// 任务栏菜单：退出程序事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 退出程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMain_FormClosing(null,null);
        }

        /// <summary>
        /// 双击任务栏图标事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotifyIconMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;   //隐藏窗口
            }
            else if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;  //显示窗口
            }
            
        }
    }
}
