using CCWin;
using IWshRuntimeLibrary;
using LocalGameLaunchCenter;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Speech.Synthesis;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace ClassicSimulatorGame
{
    public partial class FormMain : CCSkinMain
    {
        #region 主窗体相关变量

        public string content;                      //存储读取的简介文本
        string PCImg = null;                       //存储PC图片资源路径
        string EmuImg = null;                     //存储模拟器图片资源路径
        string PCContent = null;                 //PC简介文本资源路径
        string EmuContent = null;               //模拟器简介文本资源路径
        string MyDateFiles = null;               //我的数据文件夹路径
        string PCShortcut = null;                //PC游戏快捷方式文件夹路径
        string EmuShortcut = null;              //模拟器游戏快捷方式文件夹路径
        string Cache = null;                        //缓存文件夹路径
        string DefaultImage = null;             //默认显示图片路径
        string thisLog = null;                       //临时日志存储字符串
        string PCModifier = null;                //PC游戏修改器目录
        string PCSaveBackup = null;          //PC游戏存档备份目录

        string SayText = null;              //需要朗读的文本
        bool state = true;                    //当前播放状态

        //临时数据内存表
        DataTable PCdt = new DataTable();
        DataTable Emudt = new DataTable();

        #endregion

        #region PC相关变量

        string PCPath = @"PCPath.xml";   //PC游戏xml文档路径
        string PCName = null;                   //PC游戏名称
        string PCSaveFilePath = null;         //PC游戏存档路径
        string PCModifierName = null;      //PC游戏xml文档路径
        string PCFilePath = null;                //PC游戏路径
        string PCGameFilePath = null;        //PC游戏存档路径
        string PCStartExeName = null;       //PC启动程序文件名

        #endregion

        #region Emu相关变量

        string emuPath = @"EmuPath.xml";        //模拟器软件xml文档路径
        string platformName = null;                   //模拟器平台名称
        string EmuFilePath = null;                      //模拟器程序路径
        string GameFilePath = null;                   //模拟器游戏ROM路径
        string emuName = null;                        //模拟器程序文件名

        #endregion

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
            UserRunCountConfigs();
            //填充日志信息
            thisLog = richTextBoxLog.Text;
            richTextBoxLog.Text += DateTime.Now + " ---- 启动中心程序已运行";
            //测试图片显示
            //this.pictureBoxPC.Load(@"Resource\images\PC\DMC鬼泣.jpg");
        }

        #region 数据配置读取方法

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
                //获取并设置PC图片资源文件夹路径
                PCImg = node.SelectSingleNode("PCImg").InnerText.Trim();
                //获取并设置模拟器图片资源文件夹路径
                EmuImg = node.SelectSingleNode("EmuImg").InnerText.Trim();
                //获取并设置PC简介文本文件夹路径
                PCContent = node.SelectSingleNode("PCContent").InnerText.Trim();
                //获取并设置模拟器简介文本文件夹路径
                EmuContent = node.SelectSingleNode("EmuContent").InnerText.Trim();
                //获取并设置PC游戏快捷方式文件夹路径
                PCShortcut = node.SelectSingleNode("PCShortcut").InnerText.Trim();
                //获取并设置模拟器游戏快捷方式文件夹路径
                EmuShortcut = node.SelectSingleNode("EmuShortcut").InnerText.Trim();
                //获取并设置缓存文件夹路径
                Cache = node.SelectSingleNode("Cache").InnerText.Trim();
                //获取并默认显示图片文件夹路径
                DefaultImage = node.SelectSingleNode("DefaultImage").InnerText.Trim();
                //获取并设置PC游戏修改器文件夹路径
                PCModifier = node.SelectSingleNode("PCModifier").InnerText.Trim();
                //获取并设置PC游戏存档备份文件夹路径
                PCSaveBackup = node.SelectSingleNode("PCSaveBackup").InnerText.Trim();
            }
        }

        /// <summary>
        /// 增加游戏启动次数并保存到用户信息
        /// </summary>
        public void UserRunCountConfigs()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("UserConfig.xml");   //加载配置xml文件
            XmlNode xNode = xmlDoc.SelectSingleNode("UsersInformation");   //读取配置节点
            foreach (XmlNode node in xNode)
            {
                //增加游戏启动次数
                XmlElement xm = (XmlElement)node;
                int count = Convert.ToInt32(xm.GetAttribute("runCount"));   //获取子节点项字符串并转换格式
                count++;     //次数加1
                xm.SetAttribute("runCount", count.ToString());  //替换子节点项字符串
                toolStripStatusLabelRunCount.Text += count.ToString();    //最后填充次数信息
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
            Emudt = myds.Tables[0];
            skinDataGridViewEmu.DataSource = Emudt;
            pictureBoxEmu.Load(DefaultImage + "Emu.jpg");   //加载本地默认图像文件
        }

        /// <summary>
        /// 填充PC软件数据信息
        /// </summary>
        public void SetPCData()
        {
            DataSet myds = new DataSet();
            myds.ReadXml(PCPath);
            PCdt = myds.Tables[0];
            dataGridViewPC.DataSource = PCdt;
            pictureBoxPC.Load(DefaultImage + "PC.jpg");   //加载本地默认图像文件
        }

        #endregion

        #region 程序运行日志文件操作

        /// <summary>
        /// 读取程序运行日志信息
        /// </summary>
        public void LoadLog()
        {
            FileStream myFs = new FileStream(Application.StartupPath + @"\Functionlog.txt", FileMode.Open);
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

        #endregion

        #region 磁盘验证方法

        /// <summary>
        /// 验证磁盘文件
        /// </summary>
        public void FileCheck()
        {
            //判断磁盘是否存在
            if (Directory.Exists(@"I:\"))
            {
                this.buttonEmuStart.Enabled = true;
                this.toolStripStatusLabelResult.ForeColor = Color.Green;
                this.toolStripStatusLabelResult.Text = "已存在,可正常使用!!";
            }
            else
            {
                this.buttonEmuStart.Enabled = false;
                this.toolStripStatusLabelResult.ForeColor = Color.Red;
                this.toolStripStatusLabelResult.Text = "未存在!! 请重新检测...";
            }
        }

        #endregion

        #region 只读方式打开图片方法

        /// <summary>
        /// 通过FileStream 来打开文件，这样就可以实现不锁定Image文件，到时可以让多用户同时访问Image文件
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static Bitmap ReadImageFile(string path)
        {
            FileStream fs = System.IO.File.OpenRead(path); //OpenRead
            int filelength = 0;
            filelength = (int)fs.Length; //获得文件长度 
            Byte[] image = new Byte[filelength]; //建立一个字节数组 
            fs.Read(image, 0, filelength); //按字节流读取 
            System.Drawing.Image result = System.Drawing.Image.FromStream(fs);
            fs.Close();
            Bitmap bit = new Bitmap(result);
            return bit;
        }

        #endregion

        #region 朗读文本方法

        /// <summary>
        /// 朗读指定的文本方法
        /// </summary>
        /// <param name="SayText">需要朗读的文本</param>
        /// <param name="state">是否播放</param>
        public void spVoice(string SayText,bool state)
        {
            Type type = Type.GetTypeFromProgID("SAPI.SpVoice");
            dynamic spVoice = Activator.CreateInstance(type);
            if (state == true)
            {
                spVoice.Speak(SayText);
            }
            else
            {
                spVoice.Dispose();
            }
            
            //using (SpeechSynthesizer speech = new SpeechSynthesizer())
            //{
            //    speech.Rate = int.Parse("0");   //设置语速  介于-10于10之间
            //    if (state == true)
            //    {
            //        speech.Speak(SayText);
            //    }
            //    else
            //    {
            //        speech.Dispose();
            //    }
            //}

        }

        /// <summary>
        /// 播放指定文本
        /// </summary>
        public void spVoice()
        {
            using (SpeechSynthesizer speech = new SpeechSynthesizer())
            {
                speech.Rate = int.Parse("0");   //设置语速  介于-10于10之间
                if (state == true)
                {
                    speech.Speak(SayText);
                }
                else
                {
                    speech.Dispose();
                }
            }

        }

        #endregion

        #region 创建快捷方式方法

        /// <summary>
        /// 创建桌面快捷方式
        /// </summary>
        /// <param name="deskTop">桌面的路径</param>
        /// <param name="FileName">文件的名称</param>
        /// <param name="exePath">EXE的路径</param>
        /// <returns>成功或失败</returns>
        public bool CreateDesktopShortcut(string deskTop, string FileName, string exePath, string exeName)
        {
            try
            {
                deskTop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
                if (System.IO.File.Exists(deskTop + FileName + ".lnk"))  //判断原始快捷方式是存在
                {
                    System.IO.File.Delete(deskTop + FileName + ".lnk");//删除原来的桌面快捷键方式
                }
                WshShell shell = new WshShell();

                //快捷键方式创建的位置、名称
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(deskTop + FileName + ".lnk");
                //目标文件
                shortcut.TargetPath = exeName;
                //该属性指定应用程序的工作目录，当用户没有指定一个具体的目录时，快捷方式的目标应用程序将使用该属性所指定的目录来装载或保存文件。
                //shortcut.WorkingDirectory = System.Environment.CurrentDirectory;
                shortcut.WorkingDirectory = exePath;
                //目标应用程序的窗口状态分为普通、最大化、最小化【1,3,7】
                shortcut.WindowStyle = 1;
                //快捷方式的描述信息
                shortcut.Description = FileName;
                //shortcut.IconLocation = Application.StartupPath + "\\LocalGameLaunchCenter.ico";  //快捷方式图标
                //快捷方式图标文件路径
                shortcut.IconLocation = exeName;
                shortcut.Arguments = "";
                //启动快捷方式的快捷键
                //shortcut.Hotkey = "CTRL+ALT+F11"; 
                //必须调用保存快捷才成创建成功
                shortcut.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region 运行PC游戏相关方法

        /// <summary>
        /// 运行PC游戏 .exe
        /// </summary>
        public void PCGameStartExe()
        {
            PCModifierName = this.dataGridViewPC.SelectedRows[0].Cells[0].Value.ToString();
            PCFilePath = this.dataGridViewPC.SelectedRows[0].Cells[2].Value.ToString();
            PCStartExeName = this.dataGridViewPC.SelectedRows[0].Cells[4].Value.ToString();

            //部分游戏进行单独处理
            if (PCModifierName.Equals("洛克人Zero_ZX遗产合集"))
            {
                MessageBox.Show("由于游戏的独特验证方式(会直接验证启动程序下的游戏目录文件)，通过此程序直接启动会出现异常。\n请在打开的目录下启动 MZZXLC_Start.exe 程序来启动游戏。", "此游戏启动提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Process.Start(PCFilePath);
                this.WindowState = FormWindowState.Minimized;   //最小化
            }
            else if (PCModifierName.Equals("死或生5：最后一战"))
            {
                MessageBox.Show("由于游戏的独特验证方式(会直接验证启动程序下的游戏目录文件)，通过此程序直接启动会出现异常。\n请在打开的目录下启动 Launcher.exe 程序来启动游戏。", "此游戏启动提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Process.Start(PCFilePath);
                //填充日志信息
                thisLog = richTextBoxLog.Text;
                richTextBoxLog.Text = "";
                richTextBoxLog.Text += DateTime.Now + " ---- 程序已运行，进程名：" + PCStartExeName + "\n" + thisLog;
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

        /// <summary>
        /// 运行PC游戏 .lnk
        /// </summary>
        public void PCGameStartlnk()
        {
            PCModifierName = this.dataGridViewPC.SelectedRows[0].Cells[0].Value.ToString();
            //设置快捷方式文件路径
            string lnkPath = @"Shortcut\PC\" + PCModifierName + ".lnk";

            //验证所需文件是否存在
            if (System.IO.File.Exists(lnkPath))
            {
                this.WindowState = FormWindowState.Minimized;   //最小化
                Process.Start(lnkPath);
                //填充日志信息
                thisLog = richTextBoxLog.Text;
                richTextBoxLog.Text = "";
                richTextBoxLog.Text += DateTime.Now + " ---- 程序已运行，游戏名称：" + PCModifierName + "\n" + thisLog;
            }
            else
            {
                MessageBox.Show("本次打开异常，可能原因如下：\n1.要打开的路径或者文件不存在\n2.可能您修改了文件或文件夹的名称 \n\n路径文件信息：" + lnkPath + "", "打开异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region 运行模拟器应用程序方法

        /// <summary>
        /// 运行模拟器
        /// </summary>
        public void EmuStart()
        {
            EmuFilePath = this.skinDataGridViewEmu.SelectedRows[0].Cells[2].Value.ToString();
            emuName = this.skinDataGridViewEmu.SelectedRows[0].Cells[3].Value.ToString();
            if (Directory.Exists(EmuFilePath) && System.IO.File.Exists(EmuFilePath + emuName))
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
                MessageBox.Show(@"本次打开异常，可能原因如下：\n1.要打开的路径或者文件不存在\n2.可能您修改了文件或文件夹的名称\n\n路径信息：" + EmuFilePath + "" + emuName + "", "打开异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region 编辑数据方法

        /// <summary>
        /// 编辑数据方法
        /// </summary>
        public void EditThisData()
        {
            //对每个选项卡进行分支处理
            if (skinTabControlSelect.SelectedTab == skinTabPagePC)
            {
                PCModifierName = this.dataGridViewPC.SelectedRows[0].Cells[0].Value.ToString();
                //设置图像路径
                string picName = PCImg + PCModifierName + ".jpg";
                //设置提示文本路径
                string tipText = PCContent + PCModifierName + ".txt";

                FormEdit FormEdit = new FormEdit();
                FormEdit.TypeName = "PC";   //传递要编辑的数据类型
                FormEdit.Pattern = "编辑数据";  //设置窗口模式
                FormEdit.PCGameName = this.dataGridViewPC.SelectedRows[0].Cells[0].Value.ToString();
                FormEdit.PCGameType = this.dataGridViewPC.SelectedRows[0].Cells[1].Value.ToString();
                FormEdit.PCGamePath = this.dataGridViewPC.SelectedRows[0].Cells[2].Value.ToString();
                FormEdit.PCSavePath = this.dataGridViewPC.SelectedRows[0].Cells[3].Value.ToString();
                FormEdit.PCStartName = this.dataGridViewPC.SelectedRows[0].Cells[4].Value.ToString();
                FormEdit.ImgFilePath = picName;
                FormEdit.TxtFilePath = tipText;
                FormEdit.TextContent = richTextBoxPCTip.Text;
                FormEdit.Show();
            }
            else if (skinTabControlSelect.SelectedTab == skinTabPageEmu)
            {
                platformName = this.skinDataGridViewEmu.SelectedRows[0].Cells[0].Value.ToString();
                //设置图像路径
                string picName = EmuImg + platformName + ".jpg";
                //设置提示文本路径
                string tipText = EmuContent + platformName + ".txt";

                FormEdit FormEdit = new FormEdit();
                FormEdit.TypeName = "Emu";  //传递要编辑的数据类型
                FormEdit.Pattern = "编辑数据";  //设置窗口模式
                FormEdit.EmuName = this.skinDataGridViewEmu.SelectedRows[0].Cells[0].Value.ToString();
                FormEdit.EmuGamePath = this.skinDataGridViewEmu.SelectedRows[0].Cells[1].Value.ToString();
                FormEdit.EmuFilePath = this.skinDataGridViewEmu.SelectedRows[0].Cells[2].Value.ToString();
                FormEdit.EmuStartName = this.skinDataGridViewEmu.SelectedRows[0].Cells[3].Value.ToString();
                FormEdit.EmuExplain = this.skinDataGridViewEmu.SelectedRows[0].Cells[4].Value.ToString();
                FormEdit.ImgFilePath = picName;
                FormEdit.TxtFilePath = tipText;
                FormEdit.TextContent = richTextBoxEmuTip.Text;
                FormEdit.Show();
            }
        }

        #endregion

        #region 删除数据方法

        /// <summary>
        /// 删除数据方法
        /// </summary>
        public void DelThisData()
        {
            //对每个选项卡进行分支处理
            if (skinTabControlSelect.SelectedTab == skinTabPagePC)
            {
                string PCName = this.dataGridViewPC.SelectedRows[0].Cells[0].Value.ToString();
                DialogResult dr = MessageBox.Show("是否删除此数据？？(包括此数据的封面图片和简介文本文件)\n数据名称：" + PCName + "\n\n(提示：此操作不可逆!!)", "确认操作", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                if (dr == DialogResult.OK)
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load("PCPath.xml");   //加载配置xml文件
                    XmlNode xNode = xmlDoc.SelectSingleNode("PCMenu");   //读取配置节点
                    foreach (XmlNode node in xNode)
                    {
                        //移除数据信息
                        XmlElement xm = (XmlElement)node;
                        if (xm.GetAttribute("GameName") == PCName)
                        {
                            xm.ParentNode.RemoveChild(xm);
                            break;
                        }
                    }
                    xmlDoc.Save("PCPath.xml");   //保存配置xml文件

                    //删除图片文件
                    pictureBoxPC.Load(DefaultImage + "PC.jpg");   //加载默认图像文件
                    System.IO.File.Delete(PCImg + PCName + @".jpg");
                    //删除简介文本文件
                    richTextBoxPCTip.Text = null;
                    System.IO.File.Delete(PCContent + PCName + @".txt");

                    MessageBox.Show("数据移除成功!!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    SetPCData();    //刷新数据
                }
            }
            else if (skinTabControlSelect.SelectedTab == skinTabPageEmu)
            {
                string EmuName = this.skinDataGridViewEmu.SelectedRows[0].Cells[0].Value.ToString();
                DialogResult dr = MessageBox.Show("是否删除此数据？？(包括此数据的封面图片和简介文本文件)\n数据名称：" + EmuName + "\n\n(提示：此操作不可逆!!)", "确认操作", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                if (dr == DialogResult.OK)
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load("EmuPath.xml");   //加载配置xml文件
                    XmlNode xNode = xmlDoc.SelectSingleNode("EmuMenu");   //读取配置节点
                    foreach (XmlNode node in xNode)
                    {
                        //移除数据信息
                        XmlElement xm = (XmlElement)node;
                        if (xm.GetAttribute("name") == EmuName)
                        {
                            xm.ParentNode.RemoveChild(xm);
                            break;
                        }
                    }
                    xmlDoc.Save("EmuPath.xml");   //保存配置xml文件

                    //删除图片文件
                    pictureBoxEmu.Load(DefaultImage + "Emu.jpg");    //加载默认图像文件
                    System.IO.File.Delete(EmuImg + EmuName + @".jpg");
                    //删除简介文本文件
                    richTextBoxEmuTip.Text = null;
                    System.IO.File.Delete(EmuContent + EmuName + @".txt");

                    MessageBox.Show("数据移除成功!!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    SetEmuData();   //刷新数据
                }
            }
        }

        #endregion

        #region 搜索数据方法

        /// <summary>
        /// 搜索数据并填充到dataGridView
        /// </summary>
        public void SearchData()
        {
            //判断当前选中的选项卡
            if (skinTabControlSelect.SelectedTab == skinTabPagePC)
            {
                if (toolStripTextBoxSearch.Text != "")
                {
                    SetPCData();    //默认初始化一遍信息
                    //查询DataTable的行内是否出现指定的字符串，如果没出现则临时删除，否则保留并显示
                    string checkStr;    //存储临时名称信息，用于判断
                    for (int i = PCdt.Rows.Count - 1; i >= 0; i--)
                    {
                        checkStr = this.dataGridViewPC.Rows[i].Cells[0].Value.ToString();
                        if (checkStr.Contains("" + toolStripTextBoxSearch.Text + "") == false)
                        {
                            PCdt.Rows[i].Delete();
                        }
                    }
                    //如果数据行为0则提示
                    if (PCdt.Rows.Count == 0)
                    {
                        MessageBox.Show("未找到此名称的相关数据!!\n请输入完整名称或检查后重试", "数据未找到", MessageBoxButtons.OK);
                    }
                    dataGridViewPC.DataSource = PCdt;
                }
                else
                {
                    SetPCData();
                }
            }
            else if (skinTabControlSelect.SelectedTab == skinTabPageEmu)
            {
                if (toolStripTextBoxSearch.Text != "")
                {
                    SetEmuData();   //默认初始化一遍信息
                    //查询DataTable的行内是否出现指定的字符串，如果没出现则临时删除，否则保留并显示
                    string checkStr;    //存储临时名称信息，用于判断
                    for (int i = Emudt.Rows.Count - 1; i >= 0; i--)
                    {
                        checkStr = this.skinDataGridViewEmu.Rows[i].Cells[0].Value.ToString();
                        if (checkStr.Contains("" + toolStripTextBoxSearch.Text + "") == false)
                        {
                            Emudt.Rows[i].Delete();
                        }
                    }
                    //如果数据行为0则提示
                    if (PCdt.Rows.Count == 0)
                    {
                        MessageBox.Show("未找到此名称的相关数据!!\n请输入完整名称或检查后重试", "数据未找到", MessageBoxButtons.OK);
                    }
                    skinDataGridViewEmu.DataSource = PCdt;
                }
                else
                {
                    SetEmuData();
                }
            }
        }

        #endregion

        #region 复制文件方法

        /// <summary>
        /// 复制文件到指定路径
        /// </summary>
        /// <param name="srcPath">原目录</param>
        /// <param name="aimPath">目标目录</param>
        public void CopyDir(string srcPath, string aimPath)
        {
            try
            {
                //如果不存在目标路径则创建
                if (!System.IO.Directory.Exists(aimPath))
                {
                    System.IO.Directory.CreateDirectory(aimPath);
                }
                //令目标路径为aimPath\srcPath
                string srcdir = System.IO.Path.Combine(aimPath, System.IO.Path.GetFileName(srcPath));
                //如果源路径是文件夹，则令目标目录为aimPath\srcPath\
                if (Directory.Exists(srcPath))
                    srcdir += Path.DirectorySeparatorChar;
                // 如果目标路径不存在,则创建目标路径
                if (!System.IO.Directory.Exists(srcdir))
                {
                    System.IO.Directory.CreateDirectory(srcdir);
                }
                //获取源文件下所有的文件
                String[] files = Directory.GetFileSystemEntries(srcPath);
                foreach (string element in files)
                {
                    //如果是文件夹，循环
                    if (Directory.Exists(element))
                        CopyDir(element, srcdir);
                    else
                        System.IO.File.Copy(element, srcdir + Path.GetFileName(element), true);
                }
            }
            catch
            {
                MessageBox.Show("复制文件失败，可能为以下原因：\n1.源目录及文件或目标目录及文件不存在。\n2.路径名错误\n\n请重试...","复制失败",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        #endregion

        /// <summary>
        /// 运行模拟器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            EmuStart();
        }

        /// <summary>
        /// 模拟器软件数据选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewEmu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            platformName = this.skinDataGridViewEmu.SelectedRows[0].Cells[0].Value.ToString();
            //设置图像路径
            string picName = EmuImg + platformName + ".jpg";
            //设置提示文本路径
            string tipText = EmuContent + platformName + ".txt";

            //验证所需文件是否存在
            if (System.IO.File.Exists(picName) && System.IO.File.Exists(tipText))
            {
                //读取图片文件
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
            PCGameStartlnk();
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
            PCModifierName = this.dataGridViewPC.SelectedRows[0].Cells[0].Value.ToString();
            //设置图像路径
            string picName = PCImg + PCModifierName + ".jpg";
            //设置提示文本路径
            string tipText = PCContent + PCModifierName + ".txt";

            //验证所需文件是否存在
            if (System.IO.File.Exists(picName) && System.IO.File.Exists(tipText))
            {
                //读取图片文件
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
            if (CreateDesktopShortcut(@"C:\Users\~\Desktop", "本地游戏启动中心", Application.StartupPath, Application.StartupPath+ @"\LocalGameLaunchCenter.exe") == true)
            {
                MessageBox.Show("快捷方式创建成功!!","提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("快捷方式创建失败...", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 打开PC游戏快捷方式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SkinButtonPClnk_Click(object sender, EventArgs e)
        {
            PCGameStartlnk();
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

        private void 打开我的数据文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(MyDateFiles))
            {
                System.Diagnostics.Process.Start(MyDateFiles);
            }
            else
            {
                MessageBox.Show("本次打开异常，可能原因如下：\n1.要打开的路径或者文件不存在\n2.可能您修改了文件或文件夹的名称 \n\n路径信息：" + MyDateFiles + "", "打开异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 打开PC游戏快捷方式文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void 打开模拟器软件快捷方式文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
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
        /// 刷新数据显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            //清空临时数据表
            PCdt.Clear();
            Emudt.Clear();
            //重新填充数据
            SetEmuData();
            SetPCData();
            //填充日志信息
            thisLog = richTextBoxLog.Text;
            richTextBoxLog.Text = "";
            richTextBoxLog.Text += DateTime.Now + " ---- 显示数据刷新成功\n" + thisLog;
            //MessageBox.Show("数据刷新成功","提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }

        /// <summary>
        /// 菜单启动事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SkinContextMenuStripEdit_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //对每个选项卡进行分支处理
            if (skinTabControlSelect.SelectedTab == skinTabPagePC)
            {
                if (this.dataGridViewPC.SelectedRows[0].Cells[0].Value.ToString() != "")
                {
                    skinContextMenuPCStrip.Enabled = true;
                }
                else
                {
                    skinContextMenuPCStrip.Enabled = false;
                }
            }
            else if(skinTabControlSelect.SelectedTab == skinTabPageEmu)
            {
                if (this.skinDataGridViewEmu.SelectedRows[0].Cells[0].Value.ToString() != "")
                {
                    skinContextMenuPCStrip.Enabled = true;
                }
                else
                {
                    skinContextMenuPCStrip.Enabled = false;
                }
            }
        }

        #region PC dataGridView右键菜单项

        private void 快捷方式lnkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PCGameStartlnk();
        }

        private void 启动执行程序exeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PCGameStartExe();
        }

        private void 运行此游戏的修改器程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PCModifierName = this.dataGridViewPC.SelectedRows[0].Cells[0].Value.ToString() + @".exe";

            if (Directory.Exists(PCModifier) && System.IO.File.Exists(PCModifier + PCModifierName))
            {
                this.WindowState = FormWindowState.Minimized;   //最小化
                Process.Start(PCModifier + PCModifierName);
                //填充日志信息
                thisLog = richTextBoxLog.Text;
                richTextBoxLog.Text = "";
                richTextBoxLog.Text += DateTime.Now + " ---- 修改器程序已运行，进程名：" + PCModifierName + "\n" + thisLog;
            }
            else
            {
                MessageBox.Show("本次打开异常，可能原因如下：\n1.要打开的路径或者文件不存在\n2.可能您修改了文件或文件夹的名称\n\n路径信息：" + PCModifier + "" + PCModifierName + "", "打开异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 游戏所在位置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ButtonPCFilePath_Click(null, null);
        }

        private void 游戏存档路径ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ButtonPCSaveFilePath_Click(null, null);
        }

        /// <summary>
        /// 备份存档
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 备份存档ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PCName = this.dataGridViewPC.SelectedRows[0].Cells[0].Value.ToString(); //游戏名称
            PCFilePath = this.dataGridViewPC.SelectedRows[0].Cells[2].Value.ToString(); //游戏路径
            PCSaveFilePath = this.dataGridViewPC.SelectedRows[0].Cells[3].Value.ToString(); //游戏存档路径

            //确认用户操作提示框
            DialogResult dr = MessageBox.Show("是否确定备份存档？？\n注意：此操作会覆盖掉已备份的存档数据", "确认备份存档", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (dr == DialogResult.OK)
            {
                //检查相应目录是否存在
                if (System.IO.Directory.Exists(PCSaveBackup) && System.IO.Directory.Exists(PCSaveFilePath))
                {
                    CopyDir(PCSaveFilePath, PCSaveBackup + PCName + @"\");
                    MessageBox.Show("存档备份成功!!\n点击确定查看存档备份目录", "备份完成", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Process.Start(PCSaveBackup + PCName);  //打开目录
                }
                else
                {
                    MessageBox.Show("存档备份失败，可能为以下原因：\n1.游戏存档位置或者备份存档位置不存在。\n2.游戏存档路径设置有误。\n\n请检查后重试...", "无法备份存档", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
                
        }

        /// <summary>
        /// 恢复存档
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 恢复存档ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PCName = this.dataGridViewPC.SelectedRows[0].Cells[0].Value.ToString(); //游戏名称
            PCFilePath = this.dataGridViewPC.SelectedRows[0].Cells[2].Value.ToString(); //游戏路径
            PCSaveFilePath = this.dataGridViewPC.SelectedRows[0].Cells[3].Value.ToString(); //游戏存档路径

            //确认用户操作提示框
            DialogResult dr = MessageBox.Show("是否确定恢复存档？？\n注意：此操作会覆盖掉原始存档数据","确认恢复存档",MessageBoxButtons.OKCancel,MessageBoxIcon.Asterisk);
            if (dr == DialogResult.OK)
            {
                //检查相应目录是否存在
                if (System.IO.Directory.Exists(PCSaveBackup) && System.IO.Directory.Exists(PCSaveFilePath))
                {
                    CopyDir(PCSaveBackup + PCName + @"\", PCSaveFilePath);
                    MessageBox.Show("存档恢复成功!!\n点击确定查看存档恢复目录", "恢复完成", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Process.Start(PCSaveFilePath);  //打开目录
                }
                else
                {
                    MessageBox.Show("存档恢复失败，可能为以下原因：\n1.游戏存档位置或者备份存档位置不存在。\n2.游戏存档路径设置有误(或者您未设置游戏存档路径)。\n\n请检查后重试...", "无法备份存档", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        /// <summary>
        /// 删除已备份的存档
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除已备份的存档ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PCName = this.dataGridViewPC.SelectedRows[0].Cells[0].Value.ToString(); //游戏名称
            PCSaveFilePath = this.dataGridViewPC.SelectedRows[0].Cells[3].Value.ToString(); //游戏存档路径

            //确认用户操作提示框
            DialogResult dr = MessageBox.Show("是否确定删除已备份的存档？？\n注意：此操作不可逆，一经删除无法还原！！", "确认删除已备份的存档", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (dr == DialogResult.OK)
            {
                System.IO.File.Delete(PCSaveBackup + PCName);
                MessageBox.Show("存档删除成功!!", "删除完成", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        /// <summary>
        /// 添加快捷方式到桌面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 添加快捷方式到桌面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PCName = this.dataGridViewPC.SelectedRows[0].Cells[0].Value.ToString(); //游戏名称
            PCFilePath = this.dataGridViewPC.SelectedRows[0].Cells[2].Value.ToString(); //设置游戏路径
            PCStartExeName = this.dataGridViewPC.SelectedRows[0].Cells[4].Value.ToString(); //游戏启动程序名称

            if (CreateDesktopShortcut(@"C:\Users\~\Desktop", PCName, PCFilePath, PCFilePath + PCStartExeName) == true)
            {
                MessageBox.Show("快捷方式创建成功!!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("快捷方式创建失败...", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// 编辑数据菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditThisData();
        }

        /// <summary>
        /// 删除数据信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelThisData();
        }

        #endregion

        private void 程序资源修复ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //打开设置中心
            FormSetting FormSetting = new FormSetting();
            FormSetting.Show();
        }

        /// <summary>
        /// 一键批量更新快捷方式：Windows电脑游戏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Windows电脑游戏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUpdatelnk FormUpdatelnk = new FormUpdatelnk();
            FormUpdatelnk.TypeName = "PC";     //传递需要更新的平台类型名称
            FormUpdatelnk.PCdt = this.PCdt;     //传递临时内存表数据
            FormUpdatelnk.dataGridViewPC = this.dataGridViewPC;     //传递dataGridView数据
            FormUpdatelnk.PCShortcut = PCShortcut;      //传递快捷方式路径
            FormUpdatelnk.Show();
        }

        /// <summary>
        /// 一键批量更新快捷方式：模拟器软件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 模拟器软件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUpdatelnk FormUpdatelnk = new FormUpdatelnk();
            FormUpdatelnk.TypeName = "Emu";     //传递需要更新的平台类型名称
            FormUpdatelnk.Emudt = this.Emudt;     //传递临时内存表数据
            FormUpdatelnk.dataGridViewEmu = this.skinDataGridViewEmu;     //传递dataGridView数据
            FormUpdatelnk.EmuShortcut = EmuShortcut;      //传递快捷方式路径
            FormUpdatelnk.Show();
        }

        /// <summary>
        /// 新增PC游戏数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PC游戏数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //设置图像路径
            string picName = PCImg;
            //设置提示文本路径
            string tipText = PCContent;

            FormEdit FormEdit = new FormEdit();
            FormEdit.TypeName = "PC";   //传递要编辑的数据类型
            FormEdit.Pattern = "新增数据";  //设置窗口模式
            FormEdit.ImgFilePath = picName;
            FormEdit.TxtFilePath = tipText;
            FormEdit.Show();
        }

        /// <summary>
        /// 新增模拟器软件数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 模拟器软件数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //设置图像路径
            string picName = EmuImg;
            //设置提示文本路径
            string tipText = EmuContent;

            FormEdit FormEdit = new FormEdit();
            FormEdit.TypeName = "Emu";  //传递要编辑的数据类型
            FormEdit.Pattern = "新增数据";  //设置窗口模式
            FormEdit.ImgFilePath = picName;
            FormEdit.TxtFilePath = tipText;
            FormEdit.Show();
        }

        /// <summary>
        /// 搜索项目事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripButtonRunSearch_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        /// <summary>
        /// 朗读PC游戏简介文本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        SpeechSynthesizer speech = new SpeechSynthesizer();

        private void LinkLabelSay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabelPCSay.Text == "点击朗读此文本")
            {
                linkLabelPCSay.Text = "点击停止朗读";
                speech = new SpeechSynthesizer();
                speech.Rate = int.Parse("0");   //设置语速  介于-10于10之间
                speech.SpeakAsync(richTextBoxPCTip.Text);
            }
            else if (linkLabelPCSay.Text == "点击停止朗读")
            {
                linkLabelPCSay.Text = "点击朗读此文本";
                speech.Dispose();
            }
        }

        /// <summary>
        /// 朗读模拟器简介文本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LinkLabelEmuSay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabelEmuSay.Text == "点击朗读此文本")
            {
                linkLabelEmuSay.Text = "点击停止朗读";
                speech = new SpeechSynthesizer();
                speech.Rate = int.Parse("0");   //设置语速  介于-10于10之间
                speech.SpeakAsync(richTextBoxEmuTip.Text);
            }
            else if (linkLabelEmuSay.Text == "点击停止朗读")
            {
                linkLabelEmuSay.Text = "点击朗读此文本";
                speech.Dispose();
            }
        }

        /// <summary>
        /// 用户信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripDropDownButtonUser_Click(object sender, EventArgs e)
        {
            //打开用户信息窗口
            FormUser FormUser = new FormUser();
            FormUser.Show();
        }

        /// <summary>
        /// 弹出PC相关菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SkinButtonMenu_Click(object sender, EventArgs e)
        {
            skinContextMenuPCStrip.Show(MousePosition.X, MousePosition.Y);    //弹出PC相关菜单
        }

        /// <summary>
        /// 打开相关ROM文件路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemRomFilePath_Click(object sender, EventArgs e)
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
        /// 打开模拟器所在路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemEmuFilePath_Click(object sender, EventArgs e)
        {
            EmuFilePath = this.skinDataGridViewEmu.SelectedRows[0].Cells[2].Value.ToString();
            if (Directory.Exists(EmuFilePath))
            {
                System.Diagnostics.Process.Start(EmuFilePath);
            }
            else
            {
                MessageBox.Show("本次打开异常，可能原因如下：\n1.要打开的路径或者文件不存在\n2.可能您修改了文件或文件夹的名称", "打开异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// 弹出模拟器相关菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SkinButtonEmuMenu_Click(object sender, EventArgs e)
        {
            skinContextMenuEmuStrip.Show(MousePosition.X, MousePosition.Y);    //弹出PC相关菜单
        }

        private void ToolStripMenuItem13_Click(object sender, EventArgs e)
        {
            EditThisData();
        }

        private void ToolStripMenuItem14_Click(object sender, EventArgs e)
        {
            DelThisData();
        }

        
    }
}
