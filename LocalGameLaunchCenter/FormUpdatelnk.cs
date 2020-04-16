using CCWin;
using IWshRuntimeLibrary;
using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace LocalGameLaunchCenter
{
    public partial class FormUpdatelnk : CCSkinMain
    {
        //获取需创建快捷方式的类型
        public string TypeName = "PC";  //要编辑数据的类型，共PC&Emu两个选项，默认为PC。

        //存放执行日志信息
        public string thisLog = null;

        //临时数据内存表
        public DataTable PCdt = new DataTable();   //PC数据
        public DataTable Emudt = new DataTable();  //模拟器数据

        //存放临时数据显示控件DataGrid
        public DataGridView dataGridViewPC = null;
        public DataGridView dataGridViewEmu = null;

        //文件相关变量
        public string PCName = null;               //PC游戏名称
        public string PCFilePath = null;           //PC游戏路径
        public string PCStartExeName = null;   //PC启动程序文件名

        public string platformName = null;     //模拟器平台名称
        public string EmuFilePath = null;          //模拟器程序路径   
        public string emuName = null;           //模拟器程序文件名

        //窗体显示数值相关变量
        public int sumCount = 0;            //总需操作数据量
        public int yesCount = 0;            //已完成数量
        public int noCount = 0;             //未完成数量

        //快捷方式文件夹相关路径
        public string PCShortcut = null;          //PC游戏快捷方式文件夹路径
        public string EmuShortcut = null;      //模拟器游戏快捷方式文件夹路径


        public FormUpdatelnk()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormUpdatelnk_Load(object sender, EventArgs e)
        {
            //判断需创建快捷方式的类型
            if (TypeName == "PC")
            {
                this.Text = "批量更新快捷方式 ---- 更新类型：PC";
                dataGridViewPC.DataSource = PCdt;   //设置PC临时数据控件数据源
                //初始化填充变量信息
                sumCount = PCdt.Rows.Count;    //设置总数量
                skinTextBoxCount.Text = sumCount.ToString();    //填充显示文本
                noCount = sumCount;     //未完成数量默认等于总数量
                skinTextBoxNo.Text = noCount.ToString();    //填充显示文本
            }
            else if(TypeName == "Emu")
            {
                this.Text = "批量更新快捷方式 ---- 更新类型：Emu";
                dataGridViewEmu.DataSource = Emudt;   //设置PC临时数据控件数据源
                //初始化填充变量信息
                sumCount = Emudt.Rows.Count;    //设置总数量
                skinTextBoxCount.Text = sumCount.ToString();    //填充显示文本
                noCount = sumCount;     //未完成数量默认等于总数量
                skinTextBoxNo.Text = noCount.ToString();    //填充显示文本
            }
            //初始化填充日志信息
            thisLog = rtfRichTextBoxOKLog.Text;
            rtfRichTextBoxOKLog.Text = "";
            rtfRichTextBoxOKLog.Text += DateTime.Now + " ---- 程序待执行\n" + thisLog;
            
            //填充进度条信息
            skinProgressBarState.Maximum = sumCount;
            skinProgressBarState.Minimum = 0;
            skinProgressBarState.Value = 0;
        }

        /// <summary>
        /// 创建快捷方式到指定位置
        /// </summary>
        /// <param name="FilePath">指定的路径</param>
        /// <param name="FileName">文件的名称</param>
        /// <param name="exePath">EXE的路径</param>
        /// <param name="exeName">EXE的路径与名称</param>
        /// <returns>成功或失败</returns>
        public bool CreateFilePathShortcut(string FilePath, string FileName, string exePath, string exeName)
        {
            try
            {
                if (System.IO.File.Exists(FilePath + FileName + ".lnk"))    //判断原始快捷方式是存在
                {
                    System.IO.File.Delete(FilePath + FileName + ".lnk");    //删除原来的快捷方式
                }
                WshShell shell = new WshShell();

                //快捷键方式创建的位置、名称
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(FilePath + FileName + ".lnk");
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

        /// <summary>
        /// 执行程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SkinButtonImplement_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否要一键更新所有游戏启动程序的快捷方式到存放快捷方式的文件夹？？\n提示：此操作会替换掉之前所有已创建的快捷方式。\n(操作时间会持续几分钟，操作过程中请不要退出程序。)\n\n功能：修复更改游戏文件路径后无法启动相应游戏的快捷方式问题。", "确认您的操作", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (dr == DialogResult.OK)
            {
                if (TypeName == "PC")
                {
                    for (int i = 0; i < PCdt.Rows.Count; i++)
                    {
                        PCName = this.dataGridViewPC.Rows[i].Cells[0].Value.ToString(); //游戏名称
                        PCFilePath = this.dataGridViewPC.Rows[i].Cells[2].Value.ToString(); //设置游戏路径
                        PCStartExeName = this.dataGridViewPC.Rows[i].Cells[4].Value.ToString(); //游戏启动程序名称
                        CreateFilePathShortcut(PCShortcut + @"\", PCName, PCFilePath, PCFilePath + PCStartExeName);
                        //更新显示变量信息
                        skinTextBoxAppName.Text = PCName;
                        noCount--;     //未完成数量减一
                        skinTextBoxNo.Text = noCount.ToString();    //填充显示文本
                        yesCount++;     //已完成数量加一
                        skinTextBoxYes.Text = yesCount.ToString();    //填充显示文本
                        //填充进度条信息
                        skinProgressBarState.Value = yesCount;
                        //填充日志信息
                        thisLog = rtfRichTextBoxOKLog.Text;
                        rtfRichTextBoxOKLog.Text = "";
                        rtfRichTextBoxOKLog.Text += DateTime.Now + " ---- ["+ PCName + "] 的快捷方式创建成功!!\n" + thisLog;
                    }
                    MessageBox.Show("快捷方式更新成功!!\n点击确定查看路径", "操作完成", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Process.Start(PCShortcut + @"\");
                }
                else if (TypeName == "Emu")
                {
                    for (int i = 0; i < Emudt.Rows.Count; i++)
                    {
                        platformName = this.dataGridViewEmu.Rows[i].Cells[0].Value.ToString();  //模拟器平台名称
                        emuName = this.dataGridViewEmu.Rows[i].Cells[3].Value.ToString();   //模拟器启动程序名称
                        EmuFilePath = this.dataGridViewEmu.Rows[i].Cells[2].Value.ToString();   //模拟器路径
                        CreateFilePathShortcut(EmuShortcut + @"\", platformName, EmuFilePath, EmuFilePath + emuName);
                        //更新显示变量信息
                        skinTextBoxAppName.Text = platformName;
                        noCount--;     //未完成数量减一
                        skinTextBoxNo.Text = noCount.ToString();    //填充显示文本
                        yesCount++;     //已完成数量加一
                        skinTextBoxYes.Text = yesCount.ToString();    //填充显示文本
                        //填充进度条信息
                        skinProgressBarState.Value = yesCount;
                        //填充日志信息
                        thisLog = rtfRichTextBoxOKLog.Text;
                        rtfRichTextBoxOKLog.Text = "";
                        rtfRichTextBoxOKLog.Text += DateTime.Now + " ---- [" + platformName + "] 的快捷方式创建成功!!\n" + thisLog;
                    }
                    MessageBox.Show("快捷方式更新成功!!\n点击确定查看路径", "操作完成", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Process.Start(EmuShortcut + @"\");
                }
                //禁用操作按钮
                skinButtonImplement.Enabled = false;
                skinButtonImplement.Text = "操作成功!! 请关闭当前窗口...";
            }
        }


    }
}
