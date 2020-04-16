using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace LocalGameLaunchCenter
{
    public partial class FormSetting : CCSkinMain
    {
        //我的数据文件夹路径
        string MyDateFiles = null;
        //PC游戏快捷方式文件夹路径
        string PCShortcut = null;
        //模拟器游戏快捷方式文件夹路径
        string EmuShortcut = null;
        //数据备份文件夹路径
        string BackupData = null;
        //程序默认文件路径
        string DefaultData = null;

        public FormSetting()
        {
            InitializeComponent();
        }

        private void FormSetting_Load(object sender, EventArgs e)
        {
            skinTabControlSelect.SelectedTab = skinTabPageSetting;  //默认选中第一个选项卡
            XmlConfigLoad();
            XmlFileCheck();
        }

        #region 自定义方法集合

        /// <summary>
        /// 读取Xml配置文件
        /// </summary>
        public void XmlConfigLoad()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("AppConfig.xml");   //加载配置xml文件
            XmlNode xNode = xmlDoc.SelectSingleNode("MainSettings");   //读取配置节点
            foreach (XmlNode node in xNode)
            {
                MyDateFiles = node.SelectSingleNode("MyDateFiles").InnerText.Trim();
                PCShortcut = node.SelectSingleNode("PCShortcut").InnerText.Trim();
                EmuShortcut = node.SelectSingleNode("EmuShortcut").InnerText.Trim();
                BackupData = node.SelectSingleNode("BackupData").InnerText.Trim();
                DefaultData = node.SelectSingleNode("DefaultData").InnerText.Trim();
            }
        }

        /// <summary>
        /// 验证Xml配置文件是否存在
        /// </summary>
        public void XmlFileCheck()
        {
            if (System.IO.File.Exists("AppConfig.xml"))
            {
                skinTextBoxAppConfig.ForeColor = Color.Green;
                skinTextBoxAppConfig.Text = "已存在";
            }
            else
            {
                skinTextBoxAppConfig.ForeColor = Color.Red;
                skinTextBoxAppConfig.Text = "未存在";
            }

            if (System.IO.File.Exists("UserConfig.xml"))
            {
                skinTextBoxUserConfig.ForeColor = Color.Green;
                skinTextBoxUserConfig.Text = "已存在";
            }
            else
            {
                skinTextBoxUserConfig.ForeColor = Color.Red;
                skinTextBoxUserConfig.Text = "未存在";
            }

            if (System.IO.File.Exists("PCPath.xml"))
            {
                skinTextBoxPCPath.ForeColor = Color.Green;
                skinTextBoxPCPath.Text = "已存在";
            }
            else
            {
                skinTextBoxPCPath.ForeColor = Color.Red;
                skinTextBoxPCPath.Text = "未存在";
            }

            if (System.IO.File.Exists("EmuPath.xml"))
            {
                skinTextBoxEmuPath.ForeColor = Color.Green;
                skinTextBoxEmuPath.Text = "已存在";
            }
            else
            {
                skinTextBoxEmuPath.ForeColor = Color.Red;
                skinTextBoxEmuPath.Text = "未存在";
            }

        }

        /// <summary>
        /// 复制目录
        /// </summary>
        /// <param name="SourcePath">源路径</param>
        /// <param name="TargetPath">目标路径</param>
        /// <param name="Overwrite">是否覆盖</param>
        public static bool CopyDirectory(string SourcePath, string TargetPath, bool Overwrite)
        {
            // 如果源目录不存在，则退出
            if (!Directory.Exists(SourcePath))
            {
                return false;
            }
            // 检查目标目录是否以目录分割字符结束如果不是则添加
            if (TargetPath[TargetPath.Length - 1] != System.IO.Path.DirectorySeparatorChar)
            {
                TargetPath += System.IO.Path.DirectorySeparatorChar;
            }
            try
            {
                // 如果目标路径不存在，则创建此文件夹
                if (!Directory.Exists(TargetPath))
                {
                    Directory.CreateDirectory(TargetPath);
                }
            }
            catch (Exception ex)
            {
                string ErrInfo = ex.Message;
                return false;
            }
            if (Directory.Exists(TargetPath))
            {
                // 遍历源路径的文件夹，获取文件名（带路径的）
                foreach (string FileName in Directory.GetFiles(SourcePath))
                {
                    try
                    {
                        //复制文件
                        File.Copy(FileName, Path.Combine(TargetPath, Path.GetFileName(FileName)), Overwrite);
                    }
                    catch (Exception ex)
                    {
                        string ErrInfo = ex.Message;
                    }
                }
                // 子文件夹的遍历
                foreach (string SubPath in Directory.GetDirectories(SourcePath))
                {
                    //复制文件
                    CopyDirectory(SubPath, Path.Combine(TargetPath, Path.GetFileName(SubPath)), Overwrite);
                }
            }
            return true;

        }

        #endregion

        /// <summary>
        /// 重新检测文件状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SkinButtonInspect_Click(object sender, EventArgs e)
        {
            XmlFileCheck();
            MessageBox.Show("检查完成!!","提示",MessageBoxButtons.OK);
        }

        /// <summary>
        /// 一键修复所需文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SkinButtonRepair_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否一键修复所需文件??","确认您的操作",MessageBoxButtons.OKCancel,MessageBoxIcon.Asterisk);
            if (dr == DialogResult.OK)
            {
                //判断是否所有状态文件正常
                if (skinTextBoxAppConfig.Text.Equals("已存在") && skinTextBoxUserConfig.Text.Equals("已存在") && skinTextBoxEmuPath.Text.Equals("已存在") && skinTextBoxPCPath.Text.Equals("已存在"))
                {
                    MessageBox.Show("所有文件状态均为正常，无需进行修复操作。","无需修复",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                }
                else
                {
                    //对已丢失的文件进行添加
                    if (skinTextBoxAppConfig.Text == "未存在")
                    {
                        File.Copy(Path.Combine(DefaultData, "AppConfig.xml"), Path.Combine("", "AppConfig.xml"), true);
                    }
                    else if (skinTextBoxUserConfig.Text == "未存在")
                    {
                        File.Copy(Path.Combine(DefaultData, "UserConfig.xml"), Path.Combine("", "UserConfig.xml"), true);
                    }
                    else if (skinTextBoxEmuPath.Text == "未存在")
                    {
                        File.Copy(Path.Combine(DefaultData, "EmuPath.xml"), Path.Combine("", "EmuPath.xml"), true);
                    }
                    else if (skinTextBoxPCPath.Text == "未存在")
                    {
                        File.Copy(Path.Combine(DefaultData, "PCPath.xml"), Path.Combine("", "PCPath.xml"), true);
                    }
                    MessageBox.Show("资源修复成功!!","修复成功",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                }
                
            }
        }

        /// <summary>
        /// 取消设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 保存设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSave_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 一键备份数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SkinButtonBackup_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否确定备份数据？？\n备份的项目包括：程序所需的Xml配置文件、程序运行日志文件。\n提示：选择备份后会替换掉之前备份的数据","确认备份操作",MessageBoxButtons.OKCancel,MessageBoxIcon.Asterisk);
            if (dr == DialogResult.OK)
            {
                File.Copy(Path.Combine("", "AppConfig.xml"), Path.Combine(BackupData, "AppConfig.xml"), true);
                File.Copy(Path.Combine("", "UserConfig.xml"), Path.Combine(BackupData, "UserConfig.xml"), true);
                File.Copy(Path.Combine("", "EmuPath.xml"), Path.Combine(BackupData, "EmuPath.xml"), true);
                File.Copy(Path.Combine("", "PCPath.xml"), Path.Combine(BackupData, "PCPath.xml"), true);
                File.Copy(Path.Combine("", "Functionlog.txt"), Path.Combine(BackupData, "Functionlog.txt"), true);
                MessageBox.Show("数据备份成功!!\n点击确定查看所在位置", "备份成功", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Process.Start(BackupData);
            }
        }

        /// <summary>
        /// 一键恢复数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SkinButtonRecovery_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否确定恢复备份的数据？？\n恢复的项目包括：程序所需的Xml配置文件、程序运行日志文件。\n提示：选择恢复后会替换掉现有所有已保存的数据。", "确认恢复操作", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (dr == DialogResult.OK)
            {
                File.Copy(Path.Combine(BackupData, "AppConfig.xml"), Path.Combine("", "AppConfig.xml"), true);
                File.Copy(Path.Combine(BackupData, "UserConfig.xml"), Path.Combine("", "UserConfig.xml"), true);
                File.Copy(Path.Combine(BackupData, "EmuPath.xml"), Path.Combine("", "EmuPath.xml"), true);
                File.Copy(Path.Combine(BackupData, "PCPath.xml"), Path.Combine("", "PCPath.xml"), true);
                File.Copy(Path.Combine(BackupData, "Functionlog.txt"), Path.Combine("", "Functionlog.txt"), true);
                MessageBox.Show("数据恢复成功!!\n点击确定查看所在位置", "恢复成功", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Process.Start(Application.StartupPath);
            }
        }


    }
}
