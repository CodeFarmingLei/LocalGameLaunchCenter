namespace LocalGameLaunchCenter
{
    partial class FormUpdatelnk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpdatelnk));
            this.skinButtonImplement = new CCWin.SkinControl.SkinButton();
            this.skinGroupBoxPathTip = new CCWin.SkinControl.SkinGroupBox();
            this.rtfRichTextBoxTip = new CCWin.SkinControl.RtfRichTextBox();
            this.skinGroupBoxLog = new CCWin.SkinControl.SkinGroupBox();
            this.skinGroupBoxOKLog = new CCWin.SkinControl.SkinGroupBox();
            this.rtfRichTextBoxOKLog = new CCWin.SkinControl.RtfRichTextBox();
            this.skinTextBoxAppName = new CCWin.SkinControl.SkinTextBox();
            this.skinTextBoxNo = new CCWin.SkinControl.SkinTextBox();
            this.skinTextBoxYes = new CCWin.SkinControl.SkinTextBox();
            this.skinTextBoxCount = new CCWin.SkinControl.SkinTextBox();
            this.skinLabelNo = new CCWin.SkinControl.SkinLabel();
            this.skinLabelYes = new CCWin.SkinControl.SkinLabel();
            this.skinLabelCount = new CCWin.SkinControl.SkinLabel();
            this.skinLabelAppName = new CCWin.SkinControl.SkinLabel();
            this.skinProgressBarState = new CCWin.SkinControl.SkinProgressBar();
            this.skinGroupBoxPathTip.SuspendLayout();
            this.skinGroupBoxLog.SuspendLayout();
            this.skinGroupBoxOKLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinButtonImplement
            // 
            this.skinButtonImplement.BackColor = System.Drawing.Color.Transparent;
            this.skinButtonImplement.BaseColor = System.Drawing.Color.SkyBlue;
            this.skinButtonImplement.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButtonImplement.DownBack = null;
            this.skinButtonImplement.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButtonImplement.Location = new System.Drawing.Point(7, 348);
            this.skinButtonImplement.MouseBack = null;
            this.skinButtonImplement.Name = "skinButtonImplement";
            this.skinButtonImplement.NormlBack = null;
            this.skinButtonImplement.Size = new System.Drawing.Size(565, 30);
            this.skinButtonImplement.TabIndex = 72;
            this.skinButtonImplement.Text = "立即更新全部快捷方式";
            this.skinButtonImplement.UseVisualStyleBackColor = false;
            this.skinButtonImplement.Click += new System.EventHandler(this.SkinButtonImplement_Click);
            // 
            // skinGroupBoxPathTip
            // 
            this.skinGroupBoxPathTip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinGroupBoxPathTip.BackColor = System.Drawing.Color.Snow;
            this.skinGroupBoxPathTip.BorderColor = System.Drawing.Color.Gray;
            this.skinGroupBoxPathTip.Controls.Add(this.rtfRichTextBoxTip);
            this.skinGroupBoxPathTip.ForeColor = System.Drawing.Color.Black;
            this.skinGroupBoxPathTip.Location = new System.Drawing.Point(7, 384);
            this.skinGroupBoxPathTip.Name = "skinGroupBoxPathTip";
            this.skinGroupBoxPathTip.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBoxPathTip.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBoxPathTip.Size = new System.Drawing.Size(565, 138);
            this.skinGroupBoxPathTip.TabIndex = 73;
            this.skinGroupBoxPathTip.TabStop = false;
            this.skinGroupBoxPathTip.Text = "功能说明";
            this.skinGroupBoxPathTip.TitleBorderColor = System.Drawing.Color.Transparent;
            this.skinGroupBoxPathTip.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBoxPathTip.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // rtfRichTextBoxTip
            // 
            this.rtfRichTextBoxTip.BackColor = System.Drawing.Color.Snow;
            this.rtfRichTextBoxTip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtfRichTextBoxTip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtfRichTextBoxTip.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtfRichTextBoxTip.HiglightColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.White;
            this.rtfRichTextBoxTip.Location = new System.Drawing.Point(3, 17);
            this.rtfRichTextBoxTip.Name = "rtfRichTextBoxTip";
            this.rtfRichTextBoxTip.ReadOnly = true;
            this.rtfRichTextBoxTip.Size = new System.Drawing.Size(559, 118);
            this.rtfRichTextBoxTip.TabIndex = 1;
            this.rtfRichTextBoxTip.Text = "当您修改游戏文件路径后，之前创建的快捷方式会失效。\n\n此功能用于修复更改游戏文件路径后无法启动相应游戏的快捷方式问题。\n\n程序会自动将全部程序的快捷方式统一添加到" +
    "程序运行目录里存放快捷方式的文件夹内。\n\n此操作会持续几分钟...... 具体时间根据程序的数量及电脑的性能来决定。";
            this.rtfRichTextBoxTip.TextColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.Black;
            // 
            // skinGroupBoxLog
            // 
            this.skinGroupBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinGroupBoxLog.BackColor = System.Drawing.Color.Snow;
            this.skinGroupBoxLog.BorderColor = System.Drawing.Color.Gray;
            this.skinGroupBoxLog.Controls.Add(this.skinGroupBoxOKLog);
            this.skinGroupBoxLog.Controls.Add(this.skinTextBoxAppName);
            this.skinGroupBoxLog.Controls.Add(this.skinTextBoxNo);
            this.skinGroupBoxLog.Controls.Add(this.skinTextBoxYes);
            this.skinGroupBoxLog.Controls.Add(this.skinTextBoxCount);
            this.skinGroupBoxLog.Controls.Add(this.skinLabelNo);
            this.skinGroupBoxLog.Controls.Add(this.skinLabelYes);
            this.skinGroupBoxLog.Controls.Add(this.skinLabelCount);
            this.skinGroupBoxLog.Controls.Add(this.skinLabelAppName);
            this.skinGroupBoxLog.Controls.Add(this.skinProgressBarState);
            this.skinGroupBoxLog.ForeColor = System.Drawing.Color.Black;
            this.skinGroupBoxLog.Location = new System.Drawing.Point(7, 31);
            this.skinGroupBoxLog.Name = "skinGroupBoxLog";
            this.skinGroupBoxLog.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBoxLog.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBoxLog.Size = new System.Drawing.Size(565, 311);
            this.skinGroupBoxLog.TabIndex = 74;
            this.skinGroupBoxLog.TabStop = false;
            this.skinGroupBoxLog.Text = "执行状态";
            this.skinGroupBoxLog.TitleBorderColor = System.Drawing.Color.Transparent;
            this.skinGroupBoxLog.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBoxLog.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // skinGroupBoxOKLog
            // 
            this.skinGroupBoxOKLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinGroupBoxOKLog.BackColor = System.Drawing.Color.Snow;
            this.skinGroupBoxOKLog.BorderColor = System.Drawing.Color.Gray;
            this.skinGroupBoxOKLog.Controls.Add(this.rtfRichTextBoxOKLog);
            this.skinGroupBoxOKLog.ForeColor = System.Drawing.Color.Black;
            this.skinGroupBoxOKLog.Location = new System.Drawing.Point(6, 77);
            this.skinGroupBoxOKLog.Name = "skinGroupBoxOKLog";
            this.skinGroupBoxOKLog.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBoxOKLog.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBoxOKLog.Size = new System.Drawing.Size(553, 200);
            this.skinGroupBoxOKLog.TabIndex = 74;
            this.skinGroupBoxOKLog.TabStop = false;
            this.skinGroupBoxOKLog.Text = "执行日志信息";
            this.skinGroupBoxOKLog.TitleBorderColor = System.Drawing.Color.Transparent;
            this.skinGroupBoxOKLog.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBoxOKLog.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // rtfRichTextBoxOKLog
            // 
            this.rtfRichTextBoxOKLog.BackColor = System.Drawing.Color.Snow;
            this.rtfRichTextBoxOKLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtfRichTextBoxOKLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtfRichTextBoxOKLog.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtfRichTextBoxOKLog.HiglightColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.White;
            this.rtfRichTextBoxOKLog.Location = new System.Drawing.Point(3, 17);
            this.rtfRichTextBoxOKLog.Name = "rtfRichTextBoxOKLog";
            this.rtfRichTextBoxOKLog.ReadOnly = true;
            this.rtfRichTextBoxOKLog.Size = new System.Drawing.Size(547, 180);
            this.rtfRichTextBoxOKLog.TabIndex = 1;
            this.rtfRichTextBoxOKLog.Text = "";
            this.rtfRichTextBoxOKLog.TextColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.Black;
            // 
            // skinTextBoxAppName
            // 
            this.skinTextBoxAppName.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBoxAppName.DownBack = null;
            this.skinTextBoxAppName.Icon = null;
            this.skinTextBoxAppName.IconIsButton = false;
            this.skinTextBoxAppName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxAppName.IsPasswordChat = '\0';
            this.skinTextBoxAppName.IsSystemPasswordChar = false;
            this.skinTextBoxAppName.Lines = new string[] {
        "等待程序执行"};
            this.skinTextBoxAppName.Location = new System.Drawing.Point(201, 17);
            this.skinTextBoxAppName.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBoxAppName.MaxLength = 32767;
            this.skinTextBoxAppName.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBoxAppName.MouseBack = null;
            this.skinTextBoxAppName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxAppName.Multiline = false;
            this.skinTextBoxAppName.Name = "skinTextBoxAppName";
            this.skinTextBoxAppName.NormlBack = null;
            this.skinTextBoxAppName.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBoxAppName.ReadOnly = false;
            this.skinTextBoxAppName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBoxAppName.Size = new System.Drawing.Size(358, 28);
            // 
            // 
            // 
            this.skinTextBoxAppName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBoxAppName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBoxAppName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinTextBoxAppName.SkinTxt.ForeColor = System.Drawing.Color.DarkGreen;
            this.skinTextBoxAppName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBoxAppName.SkinTxt.Name = "BaseText";
            this.skinTextBoxAppName.SkinTxt.Size = new System.Drawing.Size(348, 18);
            this.skinTextBoxAppName.SkinTxt.TabIndex = 0;
            this.skinTextBoxAppName.SkinTxt.Text = "等待程序执行";
            this.skinTextBoxAppName.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.skinTextBoxAppName.SkinTxt.WaterColor = System.Drawing.Color.White;
            this.skinTextBoxAppName.SkinTxt.WaterText = "";
            this.skinTextBoxAppName.TabIndex = 73;
            this.skinTextBoxAppName.Text = "等待程序执行";
            this.skinTextBoxAppName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.skinTextBoxAppName.WaterColor = System.Drawing.Color.White;
            this.skinTextBoxAppName.WaterText = "";
            this.skinTextBoxAppName.WordWrap = true;
            // 
            // skinTextBoxNo
            // 
            this.skinTextBoxNo.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBoxNo.DownBack = null;
            this.skinTextBoxNo.Icon = null;
            this.skinTextBoxNo.IconIsButton = false;
            this.skinTextBoxNo.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxNo.IsPasswordChat = '\0';
            this.skinTextBoxNo.IsSystemPasswordChar = false;
            this.skinTextBoxNo.Lines = new string[] {
        "0"};
            this.skinTextBoxNo.Location = new System.Drawing.Point(470, 280);
            this.skinTextBoxNo.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBoxNo.MaxLength = 32767;
            this.skinTextBoxNo.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBoxNo.MouseBack = null;
            this.skinTextBoxNo.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxNo.Multiline = false;
            this.skinTextBoxNo.Name = "skinTextBoxNo";
            this.skinTextBoxNo.NormlBack = null;
            this.skinTextBoxNo.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBoxNo.ReadOnly = false;
            this.skinTextBoxNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBoxNo.Size = new System.Drawing.Size(89, 28);
            // 
            // 
            // 
            this.skinTextBoxNo.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBoxNo.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBoxNo.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinTextBoxNo.SkinTxt.ForeColor = System.Drawing.Color.Red;
            this.skinTextBoxNo.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBoxNo.SkinTxt.Name = "BaseText";
            this.skinTextBoxNo.SkinTxt.Size = new System.Drawing.Size(79, 18);
            this.skinTextBoxNo.SkinTxt.TabIndex = 0;
            this.skinTextBoxNo.SkinTxt.Text = "0";
            this.skinTextBoxNo.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.skinTextBoxNo.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxNo.SkinTxt.WaterText = "";
            this.skinTextBoxNo.TabIndex = 72;
            this.skinTextBoxNo.Text = "0";
            this.skinTextBoxNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.skinTextBoxNo.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxNo.WaterText = "";
            this.skinTextBoxNo.WordWrap = true;
            // 
            // skinTextBoxYes
            // 
            this.skinTextBoxYes.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBoxYes.DownBack = null;
            this.skinTextBoxYes.Icon = null;
            this.skinTextBoxYes.IconIsButton = false;
            this.skinTextBoxYes.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxYes.IsPasswordChat = '\0';
            this.skinTextBoxYes.IsSystemPasswordChar = false;
            this.skinTextBoxYes.Lines = new string[] {
        "0"};
            this.skinTextBoxYes.Location = new System.Drawing.Point(281, 280);
            this.skinTextBoxYes.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBoxYes.MaxLength = 32767;
            this.skinTextBoxYes.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBoxYes.MouseBack = null;
            this.skinTextBoxYes.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxYes.Multiline = false;
            this.skinTextBoxYes.Name = "skinTextBoxYes";
            this.skinTextBoxYes.NormlBack = null;
            this.skinTextBoxYes.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBoxYes.ReadOnly = false;
            this.skinTextBoxYes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBoxYes.Size = new System.Drawing.Size(89, 28);
            // 
            // 
            // 
            this.skinTextBoxYes.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBoxYes.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBoxYes.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinTextBoxYes.SkinTxt.ForeColor = System.Drawing.Color.Green;
            this.skinTextBoxYes.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBoxYes.SkinTxt.Name = "BaseText";
            this.skinTextBoxYes.SkinTxt.Size = new System.Drawing.Size(79, 18);
            this.skinTextBoxYes.SkinTxt.TabIndex = 0;
            this.skinTextBoxYes.SkinTxt.Text = "0";
            this.skinTextBoxYes.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.skinTextBoxYes.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxYes.SkinTxt.WaterText = "";
            this.skinTextBoxYes.TabIndex = 71;
            this.skinTextBoxYes.Text = "0";
            this.skinTextBoxYes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.skinTextBoxYes.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxYes.WaterText = "";
            this.skinTextBoxYes.WordWrap = true;
            // 
            // skinTextBoxCount
            // 
            this.skinTextBoxCount.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBoxCount.DownBack = null;
            this.skinTextBoxCount.Icon = null;
            this.skinTextBoxCount.IconIsButton = false;
            this.skinTextBoxCount.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxCount.IsPasswordChat = '\0';
            this.skinTextBoxCount.IsSystemPasswordChar = false;
            this.skinTextBoxCount.Lines = new string[] {
        "0"};
            this.skinTextBoxCount.Location = new System.Drawing.Point(90, 280);
            this.skinTextBoxCount.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBoxCount.MaxLength = 32767;
            this.skinTextBoxCount.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBoxCount.MouseBack = null;
            this.skinTextBoxCount.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxCount.Multiline = false;
            this.skinTextBoxCount.Name = "skinTextBoxCount";
            this.skinTextBoxCount.NormlBack = null;
            this.skinTextBoxCount.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBoxCount.ReadOnly = false;
            this.skinTextBoxCount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBoxCount.Size = new System.Drawing.Size(89, 28);
            // 
            // 
            // 
            this.skinTextBoxCount.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBoxCount.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBoxCount.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinTextBoxCount.SkinTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.skinTextBoxCount.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBoxCount.SkinTxt.Name = "BaseText";
            this.skinTextBoxCount.SkinTxt.Size = new System.Drawing.Size(79, 18);
            this.skinTextBoxCount.SkinTxt.TabIndex = 0;
            this.skinTextBoxCount.SkinTxt.Text = "0";
            this.skinTextBoxCount.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.skinTextBoxCount.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxCount.SkinTxt.WaterText = "";
            this.skinTextBoxCount.TabIndex = 70;
            this.skinTextBoxCount.Text = "0";
            this.skinTextBoxCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.skinTextBoxCount.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxCount.WaterText = "";
            this.skinTextBoxCount.WordWrap = true;
            // 
            // skinLabelNo
            // 
            this.skinLabelNo.AutoSize = true;
            this.skinLabelNo.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelNo.BorderColor = System.Drawing.Color.White;
            this.skinLabelNo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelNo.Location = new System.Drawing.Point(386, 284);
            this.skinLabelNo.Name = "skinLabelNo";
            this.skinLabelNo.Size = new System.Drawing.Size(93, 20);
            this.skinLabelNo.TabIndex = 65;
            this.skinLabelNo.Text = "未创建数量：";
            // 
            // skinLabelYes
            // 
            this.skinLabelYes.AutoSize = true;
            this.skinLabelYes.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelYes.BorderColor = System.Drawing.Color.White;
            this.skinLabelYes.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelYes.Location = new System.Drawing.Point(197, 284);
            this.skinLabelYes.Name = "skinLabelYes";
            this.skinLabelYes.Size = new System.Drawing.Size(93, 20);
            this.skinLabelYes.TabIndex = 64;
            this.skinLabelYes.Text = "已创建数量：";
            // 
            // skinLabelCount
            // 
            this.skinLabelCount.AutoSize = true;
            this.skinLabelCount.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelCount.BorderColor = System.Drawing.Color.White;
            this.skinLabelCount.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelCount.Location = new System.Drawing.Point(6, 284);
            this.skinLabelCount.Name = "skinLabelCount";
            this.skinLabelCount.Size = new System.Drawing.Size(93, 20);
            this.skinLabelCount.TabIndex = 63;
            this.skinLabelCount.Text = "总程序数量：";
            // 
            // skinLabelAppName
            // 
            this.skinLabelAppName.AutoSize = true;
            this.skinLabelAppName.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelAppName.BorderColor = System.Drawing.Color.White;
            this.skinLabelAppName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelAppName.Location = new System.Drawing.Point(7, 21);
            this.skinLabelAppName.Name = "skinLabelAppName";
            this.skinLabelAppName.Size = new System.Drawing.Size(191, 20);
            this.skinLabelAppName.TabIndex = 62;
            this.skinLabelAppName.Text = "当前创建快捷方式的程序名：";
            // 
            // skinProgressBarState
            // 
            this.skinProgressBarState.Back = null;
            this.skinProgressBarState.BackColor = System.Drawing.Color.Transparent;
            this.skinProgressBarState.BarBack = null;
            this.skinProgressBarState.BarRadius = 5;
            this.skinProgressBarState.BarRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinProgressBarState.Border = System.Drawing.Color.Green;
            this.skinProgressBarState.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinProgressBarState.ForeColor = System.Drawing.Color.Red;
            this.skinProgressBarState.Location = new System.Drawing.Point(6, 48);
            this.skinProgressBarState.Name = "skinProgressBarState";
            this.skinProgressBarState.Radius = 5;
            this.skinProgressBarState.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinProgressBarState.Size = new System.Drawing.Size(553, 23);
            this.skinProgressBarState.Step = 1;
            this.skinProgressBarState.TabIndex = 0;
            this.skinProgressBarState.TrackBack = System.Drawing.Color.WhiteSmoke;
            // 
            // FormUpdatelnk
            // 
            this.AcceptButton = this.skinButtonImplement;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(579, 529);
            this.CloseBoxSize = new System.Drawing.Size(40, 20);
            this.Controls.Add(this.skinGroupBoxLog);
            this.Controls.Add(this.skinGroupBoxPathTip);
            this.Controls.Add(this.skinButtonImplement);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaxSize = new System.Drawing.Size(40, 20);
            this.MiniSize = new System.Drawing.Size(40, 20);
            this.Name = "FormUpdatelnk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "批量更新快捷方式";
            this.Load += new System.EventHandler(this.FormUpdatelnk_Load);
            this.skinGroupBoxPathTip.ResumeLayout(false);
            this.skinGroupBoxLog.ResumeLayout(false);
            this.skinGroupBoxLog.PerformLayout();
            this.skinGroupBoxOKLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinButton skinButtonImplement;
        private CCWin.SkinControl.SkinGroupBox skinGroupBoxPathTip;
        private CCWin.SkinControl.RtfRichTextBox rtfRichTextBoxTip;
        private CCWin.SkinControl.SkinGroupBox skinGroupBoxLog;
        private CCWin.SkinControl.SkinProgressBar skinProgressBarState;
        private CCWin.SkinControl.SkinLabel skinLabelNo;
        private CCWin.SkinControl.SkinLabel skinLabelYes;
        private CCWin.SkinControl.SkinLabel skinLabelCount;
        private CCWin.SkinControl.SkinLabel skinLabelAppName;
        private CCWin.SkinControl.SkinTextBox skinTextBoxCount;
        private CCWin.SkinControl.SkinTextBox skinTextBoxNo;
        private CCWin.SkinControl.SkinTextBox skinTextBoxYes;
        private CCWin.SkinControl.SkinGroupBox skinGroupBoxOKLog;
        private CCWin.SkinControl.RtfRichTextBox rtfRichTextBoxOKLog;
        private CCWin.SkinControl.SkinTextBox skinTextBoxAppName;
    }
}