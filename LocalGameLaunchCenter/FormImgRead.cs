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

namespace LocalGameLaunchCenter
{
    public partial class FormImgRead : CCSkinMain
    {
        public string ThisTabSel = "";             //设置需选中的选项卡
        public string LoadimgPath = "";        //所需显示的图片路径

        public FormImgRead()
        {
            InitializeComponent();
        }

        private void FormImgRead_Load(object sender, EventArgs e)
        {
            //判断需显示的图片类型
            if (ThisTabSel == "PC")
            {
                this.skinTabControlImgType.TabPages.Remove(skinTabPageEmu); //禁用Emu选项卡
                this.skinTabControlImgType.SelectedTab = skinTabPagePC;
                this.skinPictureBoxPCImg.Load(LoadimgPath);
            }
            else if (ThisTabSel == "Emu")
            {
                this.skinTabControlImgType.TabPages.Remove(skinTabPagePC); //禁用PC选项卡
                this.skinTabControlImgType.SelectedTab = skinTabPageEmu;
                this.skinPictureBoxEmuImg.Load(LoadimgPath);
            }
        }

        private void SkinTabPagePC_Click(object sender, EventArgs e)
        {

        }
    }
}
