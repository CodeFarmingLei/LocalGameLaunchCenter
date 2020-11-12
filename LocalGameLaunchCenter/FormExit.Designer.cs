namespace LocalGameLaunchCenter
{
    partial class FormExit
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExit));
            this.skinButtonYes = new CCWin.SkinControl.SkinButton();
            this.skinButtonNo = new CCWin.SkinControl.SkinButton();
            this.skinLabelTip = new CCWin.SkinControl.SkinLabel();
            this.skinPictureBoxTitle = new CCWin.SkinControl.SkinPictureBox();
            this.skinLabelRunTime = new CCWin.SkinControl.SkinLabel();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBoxTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // skinButtonYes
            // 
            this.skinButtonYes.BackColor = System.Drawing.Color.Transparent;
            this.skinButtonYes.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButtonYes.DownBack = null;
            this.skinButtonYes.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButtonYes.ForeColor = System.Drawing.SystemColors.Menu;
            this.skinButtonYes.Location = new System.Drawing.Point(7, 187);
            this.skinButtonYes.MouseBack = null;
            this.skinButtonYes.Name = "skinButtonYes";
            this.skinButtonYes.NormlBack = null;
            this.skinButtonYes.Size = new System.Drawing.Size(536, 50);
            this.skinButtonYes.TabIndex = 0;
            this.skinButtonYes.Text = "先到这里吧，有时间再来找你!! ByeBye ヾ(^∀^)ﾉ";
            this.skinButtonYes.UseVisualStyleBackColor = false;
            this.skinButtonYes.Click += new System.EventHandler(this.SkinButtonYes_Click);
            // 
            // skinButtonNo
            // 
            this.skinButtonNo.BackColor = System.Drawing.Color.Transparent;
            this.skinButtonNo.BaseColor = System.Drawing.Color.IndianRed;
            this.skinButtonNo.BorderColor = System.Drawing.Color.Red;
            this.skinButtonNo.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButtonNo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.skinButtonNo.DownBack = null;
            this.skinButtonNo.DownBaseColor = System.Drawing.Color.Red;
            this.skinButtonNo.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButtonNo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.skinButtonNo.Location = new System.Drawing.Point(7, 243);
            this.skinButtonNo.MouseBack = null;
            this.skinButtonNo.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.skinButtonNo.Name = "skinButtonNo";
            this.skinButtonNo.NormlBack = null;
            this.skinButtonNo.Size = new System.Drawing.Size(536, 50);
            this.skinButtonNo.TabIndex = 1;
            this.skinButtonNo.Text = "还有点时间，再陪你玩一会吧... o(^▽^)o";
            this.skinButtonNo.UseVisualStyleBackColor = false;
            this.skinButtonNo.Click += new System.EventHandler(this.SkinButtonNo_Click);
            // 
            // skinLabelTip
            // 
            this.skinLabelTip.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelTip.BorderColor = System.Drawing.Color.White;
            this.skinLabelTip.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelTip.Location = new System.Drawing.Point(163, 28);
            this.skinLabelTip.Name = "skinLabelTip";
            this.skinLabelTip.Size = new System.Drawing.Size(380, 153);
            this.skinLabelTip.TabIndex = 2;
            this.skinLabelTip.Text = "确定要退出了吗？？\r\n\r\n记得有时间的话还来找我玩哦 *^_^*\r\n\r\n我一直都会在这里等你~~";
            this.skinLabelTip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skinPictureBoxTitle
            // 
            this.skinPictureBoxTitle.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBoxTitle.Image = global::LocalGameLaunchCenter.ResourceApp.TitleImg1;
            this.skinPictureBoxTitle.Location = new System.Drawing.Point(7, 31);
            this.skinPictureBoxTitle.Name = "skinPictureBoxTitle";
            this.skinPictureBoxTitle.Size = new System.Drawing.Size(150, 150);
            this.skinPictureBoxTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.skinPictureBoxTitle.TabIndex = 3;
            this.skinPictureBoxTitle.TabStop = false;
            // 
            // skinLabelRunTime
            // 
            this.skinLabelRunTime.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelRunTime.BorderColor = System.Drawing.Color.White;
            this.skinLabelRunTime.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelRunTime.Location = new System.Drawing.Point(7, 296);
            this.skinLabelRunTime.Name = "skinLabelRunTime";
            this.skinLabelRunTime.Size = new System.Drawing.Size(536, 50);
            this.skinLabelRunTime.TabIndex = 4;
            this.skinLabelRunTime.Text = "您本次游玩时间：";
            this.skinLabelRunTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormExit
            // 
            this.AcceptButton = this.skinButtonYes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.CancelButton = this.skinButtonNo;
            this.CaptionBackColorTop = System.Drawing.Color.Snow;
            this.CaptionFont = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClientSize = new System.Drawing.Size(550, 350);
            this.CloseBoxSize = new System.Drawing.Size(40, 20);
            this.ControlBoxActive = System.Drawing.Color.Black;
            this.ControlBoxDeactive = System.Drawing.Color.Black;
            this.Controls.Add(this.skinLabelRunTime);
            this.Controls.Add(this.skinPictureBoxTitle);
            this.Controls.Add(this.skinLabelTip);
            this.Controls.Add(this.skinButtonNo);
            this.Controls.Add(this.skinButtonYes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 350);
            this.MaxSize = new System.Drawing.Size(40, 20);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(550, 350);
            this.MiniSize = new System.Drawing.Size(40, 20);
            this.Name = "FormExit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "确定要退出吗？？";
            this.Load += new System.EventHandler(this.FormExit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBoxTitle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinButton skinButtonYes;
        private CCWin.SkinControl.SkinButton skinButtonNo;
        private CCWin.SkinControl.SkinLabel skinLabelTip;
        private CCWin.SkinControl.SkinPictureBox skinPictureBoxTitle;
        private CCWin.SkinControl.SkinLabel skinLabelRunTime;
    }
}