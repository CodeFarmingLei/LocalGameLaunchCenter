namespace LocalGameLaunchCenter
{
    partial class FormNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNew));
            this.groupBoxTip = new System.Windows.Forms.GroupBox();
            this.labelTip = new System.Windows.Forms.Label();
            this.richTextBoxTip = new System.Windows.Forms.RichTextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxTip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTip
            // 
            this.groupBoxTip.Controls.Add(this.labelTip);
            this.groupBoxTip.Controls.Add(this.richTextBoxTip);
            this.groupBoxTip.Location = new System.Drawing.Point(15, 12);
            this.groupBoxTip.Name = "groupBoxTip";
            this.groupBoxTip.Size = new System.Drawing.Size(553, 200);
            this.groupBoxTip.TabIndex = 1;
            this.groupBoxTip.TabStop = false;
            this.groupBoxTip.Text = "提示信息";
            // 
            // labelTip
            // 
            this.labelTip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTip.Location = new System.Drawing.Point(6, 17);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(541, 80);
            this.labelTip.TabIndex = 2;
            this.labelTip.Text = "检测到程序可能为第一次运行，需要进行程序的初始化配置。\r\n\r\n•点击确定键进行程序初始化部署并启动主程序\r\n\r\n•点击取消键即可退出程序。\r\n";
            this.labelTip.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // richTextBoxTip
            // 
            this.richTextBoxTip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxTip.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBoxTip.Location = new System.Drawing.Point(6, 100);
            this.richTextBoxTip.Name = "richTextBoxTip";
            this.richTextBoxTip.Size = new System.Drawing.Size(541, 89);
            this.richTextBoxTip.TabIndex = 1;
            this.richTextBoxTip.Text = "当前运行日志信息";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(362, 218);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 23);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "确定";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(468, 218);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(100, 23);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "取消";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // FormNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 247);
            this.ControlBox = false;
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxTip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "本地游戏启动中心 (LocalGameLaunchCenter) ---- 程序初始化工具";
            this.Load += new System.EventHandler(this.FormNew_Load);
            this.groupBoxTip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTip;
        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.RichTextBox richTextBoxTip;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonExit;
    }
}