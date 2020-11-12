namespace LocalGameLaunchCenter
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.groupBoxStaff = new CCWin.SkinControl.SkinGroupBox();
            this.skinPictureBox1 = new CCWin.SkinControl.SkinPictureBox();
            this.skinLabelStaff = new CCWin.SkinControl.SkinLabel();
            this.skinGroupBoxStatement = new CCWin.SkinControl.SkinGroupBox();
            this.rtfRichTextBoxStatement = new CCWin.SkinControl.RtfRichTextBox();
            this.skinGroupBoxUpDateLog = new CCWin.SkinControl.SkinGroupBox();
            this.rtfRichTextBoxUpDateLog = new CCWin.SkinControl.RtfRichTextBox();
            this.groupBoxStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).BeginInit();
            this.skinGroupBoxStatement.SuspendLayout();
            this.skinGroupBoxUpDateLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxStaff
            // 
            this.groupBoxStaff.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxStaff.BorderColor = System.Drawing.Color.Maroon;
            this.groupBoxStaff.Controls.Add(this.skinPictureBox1);
            this.groupBoxStaff.Controls.Add(this.skinLabelStaff);
            this.groupBoxStaff.ForeColor = System.Drawing.Color.Black;
            this.groupBoxStaff.Location = new System.Drawing.Point(7, 540);
            this.groupBoxStaff.Name = "groupBoxStaff";
            this.groupBoxStaff.Radius = 5;
            this.groupBoxStaff.RectBackColor = System.Drawing.Color.White;
            this.groupBoxStaff.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.groupBoxStaff.Size = new System.Drawing.Size(486, 123);
            this.groupBoxStaff.TabIndex = 9;
            this.groupBoxStaff.TabStop = false;
            this.groupBoxStaff.Text = "作者信息";
            this.groupBoxStaff.TitleBorderColor = System.Drawing.Color.Transparent;
            this.groupBoxStaff.TitleRadius = 5;
            this.groupBoxStaff.TitleRectBackColor = System.Drawing.Color.White;
            this.groupBoxStaff.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // skinPictureBox1
            // 
            this.skinPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBox1.Image = global::LocalGameLaunchCenter.ResourceApp.DeveloperImg;
            this.skinPictureBox1.Location = new System.Drawing.Point(6, 17);
            this.skinPictureBox1.Name = "skinPictureBox1";
            this.skinPictureBox1.Size = new System.Drawing.Size(100, 100);
            this.skinPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.skinPictureBox1.TabIndex = 10;
            this.skinPictureBox1.TabStop = false;
            // 
            // skinLabelStaff
            // 
            this.skinLabelStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinLabelStaff.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelStaff.BorderColor = System.Drawing.Color.White;
            this.skinLabelStaff.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelStaff.Location = new System.Drawing.Point(112, 17);
            this.skinLabelStaff.Name = "skinLabelStaff";
            this.skinLabelStaff.Size = new System.Drawing.Size(368, 103);
            this.skinLabelStaff.TabIndex = 0;
            this.skinLabelStaff.Text = "开发者：@热血码农ZL\r\n\r\n联系QQ/WeChat(微信)：2213407066\r\n--------------------------------------" +
    "--------------------\r\n感谢您使用本程序~";
            // 
            // skinGroupBoxStatement
            // 
            this.skinGroupBoxStatement.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBoxStatement.BorderColor = System.Drawing.Color.Maroon;
            this.skinGroupBoxStatement.Controls.Add(this.rtfRichTextBoxStatement);
            this.skinGroupBoxStatement.ForeColor = System.Drawing.Color.Black;
            this.skinGroupBoxStatement.Location = new System.Drawing.Point(7, 31);
            this.skinGroupBoxStatement.Name = "skinGroupBoxStatement";
            this.skinGroupBoxStatement.Radius = 5;
            this.skinGroupBoxStatement.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBoxStatement.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBoxStatement.Size = new System.Drawing.Size(486, 110);
            this.skinGroupBoxStatement.TabIndex = 10;
            this.skinGroupBoxStatement.TabStop = false;
            this.skinGroupBoxStatement.Text = "声明";
            this.skinGroupBoxStatement.TitleBorderColor = System.Drawing.Color.Transparent;
            this.skinGroupBoxStatement.TitleRadius = 5;
            this.skinGroupBoxStatement.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBoxStatement.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // rtfRichTextBoxStatement
            // 
            this.rtfRichTextBoxStatement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtfRichTextBoxStatement.HiglightColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.White;
            this.rtfRichTextBoxStatement.Location = new System.Drawing.Point(3, 17);
            this.rtfRichTextBoxStatement.Name = "rtfRichTextBoxStatement";
            this.rtfRichTextBoxStatement.ReadOnly = true;
            this.rtfRichTextBoxStatement.Size = new System.Drawing.Size(480, 90);
            this.rtfRichTextBoxStatement.TabIndex = 0;
            this.rtfRichTextBoxStatement.Text = "本程序为个人兴趣爱好开发，不以营利为目的。未经作者许可禁止修改本程序!!\n程序内无任何木马病毒及广告插件，请放心使用。\n\n*图片相关素材均来自网络。如果涉及侵权请" +
    "联系我，我会在第一时间进行删除。";
            this.rtfRichTextBoxStatement.TextColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.Black;
            // 
            // skinGroupBoxUpDateLog
            // 
            this.skinGroupBoxUpDateLog.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBoxUpDateLog.BorderColor = System.Drawing.Color.Maroon;
            this.skinGroupBoxUpDateLog.Controls.Add(this.rtfRichTextBoxUpDateLog);
            this.skinGroupBoxUpDateLog.ForeColor = System.Drawing.Color.Black;
            this.skinGroupBoxUpDateLog.Location = new System.Drawing.Point(7, 147);
            this.skinGroupBoxUpDateLog.Name = "skinGroupBoxUpDateLog";
            this.skinGroupBoxUpDateLog.Radius = 5;
            this.skinGroupBoxUpDateLog.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBoxUpDateLog.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBoxUpDateLog.Size = new System.Drawing.Size(486, 387);
            this.skinGroupBoxUpDateLog.TabIndex = 11;
            this.skinGroupBoxUpDateLog.TabStop = false;
            this.skinGroupBoxUpDateLog.Text = "更新日志";
            this.skinGroupBoxUpDateLog.TitleBorderColor = System.Drawing.Color.Transparent;
            this.skinGroupBoxUpDateLog.TitleRadius = 5;
            this.skinGroupBoxUpDateLog.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBoxUpDateLog.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // rtfRichTextBoxUpDateLog
            // 
            this.rtfRichTextBoxUpDateLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtfRichTextBoxUpDateLog.HiglightColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.White;
            this.rtfRichTextBoxUpDateLog.Location = new System.Drawing.Point(3, 17);
            this.rtfRichTextBoxUpDateLog.Name = "rtfRichTextBoxUpDateLog";
            this.rtfRichTextBoxUpDateLog.ReadOnly = true;
            this.rtfRichTextBoxUpDateLog.Size = new System.Drawing.Size(480, 367);
            this.rtfRichTextBoxUpDateLog.TabIndex = 0;
            this.rtfRichTextBoxUpDateLog.Text = resources.GetString("rtfRichTextBoxUpDateLog.Text");
            this.rtfRichTextBoxUpDateLog.TextColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.Black;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(500, 670);
            this.CloseBoxSize = new System.Drawing.Size(40, 20);
            this.Controls.Add(this.skinGroupBoxUpDateLog);
            this.Controls.Add(this.skinGroupBoxStatement);
            this.Controls.Add(this.groupBoxStaff);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaxSize = new System.Drawing.Size(40, 20);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 320);
            this.MiniSize = new System.Drawing.Size(40, 20);
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "关于程序";
            this.Load += new System.EventHandler(this.FormAbout_Load);
            this.groupBoxStaff.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).EndInit();
            this.skinGroupBoxStatement.ResumeLayout(false);
            this.skinGroupBoxUpDateLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinGroupBox groupBoxStaff;
        private CCWin.SkinControl.SkinLabel skinLabelStaff;
        private CCWin.SkinControl.SkinPictureBox skinPictureBox1;
        private CCWin.SkinControl.SkinGroupBox skinGroupBoxStatement;
        private CCWin.SkinControl.RtfRichTextBox rtfRichTextBoxStatement;
        private CCWin.SkinControl.SkinGroupBox skinGroupBoxUpDateLog;
        private CCWin.SkinControl.RtfRichTextBox rtfRichTextBoxUpDateLog;
    }
}