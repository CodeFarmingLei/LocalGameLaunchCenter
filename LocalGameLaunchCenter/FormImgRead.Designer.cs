namespace LocalGameLaunchCenter
{
    partial class FormImgRead
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImgRead));
            this.skinTabControlImgType = new CCWin.SkinControl.SkinTabControl();
            this.skinTabPagePC = new CCWin.SkinControl.SkinTabPage();
            this.skinPictureBoxPCImg = new CCWin.SkinControl.SkinPictureBox();
            this.skinTabPageEmu = new CCWin.SkinControl.SkinTabPage();
            this.skinPictureBoxEmuImg = new CCWin.SkinControl.SkinPictureBox();
            this.skinTabControlImgType.SuspendLayout();
            this.skinTabPagePC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBoxPCImg)).BeginInit();
            this.skinTabPageEmu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBoxEmuImg)).BeginInit();
            this.SuspendLayout();
            // 
            // skinTabControlImgType
            // 
            this.skinTabControlImgType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinTabControlImgType.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.skinTabControlImgType.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.skinTabControlImgType.Controls.Add(this.skinTabPagePC);
            this.skinTabControlImgType.Controls.Add(this.skinTabPageEmu);
            this.skinTabControlImgType.DrawType = CCWin.SkinControl.DrawStyle.Draw;
            this.skinTabControlImgType.HeadBack = null;
            this.skinTabControlImgType.ImeMode = System.Windows.Forms.ImeMode.On;
            this.skinTabControlImgType.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.skinTabControlImgType.ItemSize = new System.Drawing.Size(70, 36);
            this.skinTabControlImgType.Location = new System.Drawing.Point(8, 31);
            this.skinTabControlImgType.Name = "skinTabControlImgType";
            this.skinTabControlImgType.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("skinTabControlImgType.PageArrowDown")));
            this.skinTabControlImgType.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("skinTabControlImgType.PageArrowHover")));
            this.skinTabControlImgType.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("skinTabControlImgType.PageCloseHover")));
            this.skinTabControlImgType.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("skinTabControlImgType.PageCloseNormal")));
            this.skinTabControlImgType.PageDown = ((System.Drawing.Image)(resources.GetObject("skinTabControlImgType.PageDown")));
            this.skinTabControlImgType.PageHover = ((System.Drawing.Image)(resources.GetObject("skinTabControlImgType.PageHover")));
            this.skinTabControlImgType.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.skinTabControlImgType.PageNorml = null;
            this.skinTabControlImgType.SelectedIndex = 0;
            this.skinTabControlImgType.Size = new System.Drawing.Size(584, 762);
            this.skinTabControlImgType.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.skinTabControlImgType.TabIndex = 16;
            // 
            // skinTabPagePC
            // 
            this.skinTabPagePC.BackColor = System.Drawing.Color.White;
            this.skinTabPagePC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.skinTabPagePC.Controls.Add(this.skinPictureBoxPCImg);
            this.skinTabPagePC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPagePC.Location = new System.Drawing.Point(0, 36);
            this.skinTabPagePC.Name = "skinTabPagePC";
            this.skinTabPagePC.Size = new System.Drawing.Size(584, 726);
            this.skinTabPagePC.TabIndex = 0;
            this.skinTabPagePC.TabItemImage = null;
            this.skinTabPagePC.Text = "Windows电脑游戏封面图片";
            this.skinTabPagePC.Click += new System.EventHandler(this.SkinTabPagePC_Click);
            // 
            // skinPictureBoxPCImg
            // 
            this.skinPictureBoxPCImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.skinPictureBoxPCImg.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBoxPCImg.Location = new System.Drawing.Point(40, 3);
            this.skinPictureBoxPCImg.Name = "skinPictureBoxPCImg";
            this.skinPictureBoxPCImg.Size = new System.Drawing.Size(500, 716);
            this.skinPictureBoxPCImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.skinPictureBoxPCImg.TabIndex = 0;
            this.skinPictureBoxPCImg.TabStop = false;
            // 
            // skinTabPageEmu
            // 
            this.skinTabPageEmu.BackColor = System.Drawing.Color.White;
            this.skinTabPageEmu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.skinTabPageEmu.Controls.Add(this.skinPictureBoxEmuImg);
            this.skinTabPageEmu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPageEmu.Location = new System.Drawing.Point(0, 36);
            this.skinTabPageEmu.Name = "skinTabPageEmu";
            this.skinTabPageEmu.Size = new System.Drawing.Size(584, 726);
            this.skinTabPageEmu.TabIndex = 1;
            this.skinTabPageEmu.TabItemImage = null;
            this.skinTabPageEmu.Text = "模拟器软件封面图片";
            // 
            // skinPictureBoxEmuImg
            // 
            this.skinPictureBoxEmuImg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinPictureBoxEmuImg.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBoxEmuImg.Location = new System.Drawing.Point(40, 111);
            this.skinPictureBoxEmuImg.Name = "skinPictureBoxEmuImg";
            this.skinPictureBoxEmuImg.Size = new System.Drawing.Size(500, 500);
            this.skinPictureBoxEmuImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.skinPictureBoxEmuImg.TabIndex = 1;
            this.skinPictureBoxEmuImg.TabStop = false;
            // 
            // FormImgRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(600, 800);
            this.CloseBoxSize = new System.Drawing.Size(40, 20);
            this.Controls.Add(this.skinTabControlImgType);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaxSize = new System.Drawing.Size(40, 20);
            this.MinimizeBox = false;
            this.MiniSize = new System.Drawing.Size(40, 20);
            this.Name = "FormImgRead";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图片预览";
            this.Load += new System.EventHandler(this.FormImgRead_Load);
            this.skinTabControlImgType.ResumeLayout(false);
            this.skinTabPagePC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBoxPCImg)).EndInit();
            this.skinTabPageEmu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBoxEmuImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinTabControl skinTabControlImgType;
        private CCWin.SkinControl.SkinTabPage skinTabPagePC;
        private CCWin.SkinControl.SkinTabPage skinTabPageEmu;
        private CCWin.SkinControl.SkinPictureBox skinPictureBoxPCImg;
        private CCWin.SkinControl.SkinPictureBox skinPictureBoxEmuImg;
    }
}