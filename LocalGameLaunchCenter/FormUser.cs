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
    public partial class FormUser : CCSkinMain
    {
        public FormUser()
        {
            InitializeComponent();
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
                skinWaterTextBoxRunCount.Text = xm.GetAttribute("runCount");
            }
            xmlDoc.Save("UserConfig.xml");   //保存配置xml文件
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            UserConfigs();
        }

        private void SkinWaterTextBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
