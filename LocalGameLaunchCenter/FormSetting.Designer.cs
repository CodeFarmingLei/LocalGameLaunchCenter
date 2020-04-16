namespace LocalGameLaunchCenter
{
    partial class FormSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSetting));
            this.buttonSave = new CCWin.SkinControl.SkinButton();
            this.buttonClear = new CCWin.SkinControl.SkinButton();
            this.skinTabControlSelect = new CCWin.SkinControl.SkinTabControl();
            this.skinTabPageSetting = new CCWin.SkinControl.SkinTabPage();
            this.skinGroupBoxBackup = new CCWin.SkinControl.SkinGroupBox();
            this.skinButtonRecovery = new CCWin.SkinControl.SkinButton();
            this.skinButtonBackup = new CCWin.SkinControl.SkinButton();
            this.skinTabPageRepair = new CCWin.SkinControl.SkinTabPage();
            this.skinButtonInspect = new CCWin.SkinControl.SkinButton();
            this.skinButtonRepair = new CCWin.SkinControl.SkinButton();
            this.skinGroupBoxPathTip = new CCWin.SkinControl.SkinGroupBox();
            this.skinTextBoxPCPath = new CCWin.SkinControl.SkinTextBox();
            this.skinTextBoxEmuPath = new CCWin.SkinControl.SkinTextBox();
            this.skinTextBoxUserConfig = new CCWin.SkinControl.SkinTextBox();
            this.skinTextBoxAppConfig = new CCWin.SkinControl.SkinTextBox();
            this.skinLabelAppConfig = new CCWin.SkinControl.SkinLabel();
            this.skinLabelPCPath = new CCWin.SkinControl.SkinLabel();
            this.skinLabelUserConfig = new CCWin.SkinControl.SkinLabel();
            this.skinLabelEmuPath = new CCWin.SkinControl.SkinLabel();
            this.skinLabelBr1 = new CCWin.SkinControl.SkinLabel();
            this.skinTabControlSelect.SuspendLayout();
            this.skinTabPageSetting.SuspendLayout();
            this.skinGroupBoxBackup.SuspendLayout();
            this.skinTabPageRepair.SuspendLayout();
            this.skinGroupBoxPathTip.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Transparent;
            this.buttonSave.BaseColor = System.Drawing.Color.CornflowerBlue;
            this.buttonSave.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.buttonSave.DownBack = null;
            this.buttonSave.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSave.Location = new System.Drawing.Point(396, 502);
            this.buttonSave.MouseBack = null;
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.NormlBack = null;
            this.buttonSave.Size = new System.Drawing.Size(111, 31);
            this.buttonSave.TabIndex = 44;
            this.buttonSave.Text = "保 存";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Transparent;
            this.buttonClear.BaseColor = System.Drawing.Color.Salmon;
            this.buttonClear.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.buttonClear.DownBack = null;
            this.buttonClear.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonClear.Location = new System.Drawing.Point(513, 502);
            this.buttonClear.MouseBack = null;
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.NormlBack = null;
            this.buttonClear.Size = new System.Drawing.Size(111, 31);
            this.buttonClear.TabIndex = 43;
            this.buttonClear.Text = "取 消";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // skinTabControlSelect
            // 
            this.skinTabControlSelect.AnimationStart = true;
            this.skinTabControlSelect.AnimatorType = CCWin.SkinControl.AnimationType.HorizBlind;
            this.skinTabControlSelect.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.skinTabControlSelect.Controls.Add(this.skinTabPageSetting);
            this.skinTabControlSelect.Controls.Add(this.skinTabPageRepair);
            this.skinTabControlSelect.DrawType = CCWin.SkinControl.DrawStyle.Draw;
            this.skinTabControlSelect.HeadBack = null;
            this.skinTabControlSelect.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.skinTabControlSelect.ItemSize = new System.Drawing.Size(70, 36);
            this.skinTabControlSelect.Location = new System.Drawing.Point(7, 31);
            this.skinTabControlSelect.Name = "skinTabControlSelect";
            this.skinTabControlSelect.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("skinTabControlSelect.PageArrowDown")));
            this.skinTabControlSelect.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("skinTabControlSelect.PageArrowHover")));
            this.skinTabControlSelect.PageBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.skinTabControlSelect.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("skinTabControlSelect.PageCloseHover")));
            this.skinTabControlSelect.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("skinTabControlSelect.PageCloseNormal")));
            this.skinTabControlSelect.PageDown = ((System.Drawing.Image)(resources.GetObject("skinTabControlSelect.PageDown")));
            this.skinTabControlSelect.PageHover = ((System.Drawing.Image)(resources.GetObject("skinTabControlSelect.PageHover")));
            this.skinTabControlSelect.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.skinTabControlSelect.PageNorml = null;
            this.skinTabControlSelect.SelectedIndex = 1;
            this.skinTabControlSelect.Size = new System.Drawing.Size(617, 442);
            this.skinTabControlSelect.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.skinTabControlSelect.TabIndex = 45;
            // 
            // skinTabPageSetting
            // 
            this.skinTabPageSetting.AutoScroll = true;
            this.skinTabPageSetting.BackColor = System.Drawing.Color.White;
            this.skinTabPageSetting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skinTabPageSetting.Controls.Add(this.skinGroupBoxBackup);
            this.skinTabPageSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPageSetting.Location = new System.Drawing.Point(0, 36);
            this.skinTabPageSetting.Name = "skinTabPageSetting";
            this.skinTabPageSetting.Size = new System.Drawing.Size(617, 406);
            this.skinTabPageSetting.TabIndex = 0;
            this.skinTabPageSetting.TabItemImage = null;
            this.skinTabPageSetting.Text = "程序设置";
            // 
            // skinGroupBoxBackup
            // 
            this.skinGroupBoxBackup.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBoxBackup.BorderColor = System.Drawing.Color.Gray;
            this.skinGroupBoxBackup.Controls.Add(this.skinButtonRecovery);
            this.skinGroupBoxBackup.Controls.Add(this.skinButtonBackup);
            this.skinGroupBoxBackup.ForeColor = System.Drawing.Color.Black;
            this.skinGroupBoxBackup.Location = new System.Drawing.Point(3, 342);
            this.skinGroupBoxBackup.Name = "skinGroupBoxBackup";
            this.skinGroupBoxBackup.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBoxBackup.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBoxBackup.Size = new System.Drawing.Size(609, 59);
            this.skinGroupBoxBackup.TabIndex = 71;
            this.skinGroupBoxBackup.TabStop = false;
            this.skinGroupBoxBackup.Text = "数据备份/恢复";
            this.skinGroupBoxBackup.TitleBorderColor = System.Drawing.Color.Transparent;
            this.skinGroupBoxBackup.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBoxBackup.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // skinButtonRecovery
            // 
            this.skinButtonRecovery.BackColor = System.Drawing.Color.Transparent;
            this.skinButtonRecovery.BaseColor = System.Drawing.Color.DeepSkyBlue;
            this.skinButtonRecovery.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButtonRecovery.DownBack = null;
            this.skinButtonRecovery.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButtonRecovery.Location = new System.Drawing.Point(308, 20);
            this.skinButtonRecovery.MouseBack = null;
            this.skinButtonRecovery.Name = "skinButtonRecovery";
            this.skinButtonRecovery.NormlBack = null;
            this.skinButtonRecovery.Size = new System.Drawing.Size(295, 30);
            this.skinButtonRecovery.TabIndex = 76;
            this.skinButtonRecovery.Text = "一键恢复数据";
            this.skinButtonRecovery.UseVisualStyleBackColor = false;
            this.skinButtonRecovery.Click += new System.EventHandler(this.SkinButtonRecovery_Click);
            // 
            // skinButtonBackup
            // 
            this.skinButtonBackup.BackColor = System.Drawing.Color.Transparent;
            this.skinButtonBackup.BaseColor = System.Drawing.Color.GreenYellow;
            this.skinButtonBackup.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButtonBackup.DownBack = null;
            this.skinButtonBackup.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButtonBackup.Location = new System.Drawing.Point(7, 20);
            this.skinButtonBackup.MouseBack = null;
            this.skinButtonBackup.Name = "skinButtonBackup";
            this.skinButtonBackup.NormlBack = null;
            this.skinButtonBackup.Size = new System.Drawing.Size(295, 30);
            this.skinButtonBackup.TabIndex = 75;
            this.skinButtonBackup.Text = "一键备份数据";
            this.skinButtonBackup.UseVisualStyleBackColor = false;
            this.skinButtonBackup.Click += new System.EventHandler(this.SkinButtonBackup_Click);
            // 
            // skinTabPageRepair
            // 
            this.skinTabPageRepair.AutoScroll = true;
            this.skinTabPageRepair.BackColor = System.Drawing.Color.White;
            this.skinTabPageRepair.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skinTabPageRepair.Controls.Add(this.skinButtonInspect);
            this.skinTabPageRepair.Controls.Add(this.skinButtonRepair);
            this.skinTabPageRepair.Controls.Add(this.skinGroupBoxPathTip);
            this.skinTabPageRepair.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPageRepair.Location = new System.Drawing.Point(0, 36);
            this.skinTabPageRepair.Name = "skinTabPageRepair";
            this.skinTabPageRepair.Size = new System.Drawing.Size(617, 406);
            this.skinTabPageRepair.TabIndex = 1;
            this.skinTabPageRepair.TabItemImage = null;
            this.skinTabPageRepair.Text = "资源修复";
            // 
            // skinButtonInspect
            // 
            this.skinButtonInspect.BackColor = System.Drawing.Color.Transparent;
            this.skinButtonInspect.BaseColor = System.Drawing.Color.Azure;
            this.skinButtonInspect.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButtonInspect.DownBack = null;
            this.skinButtonInspect.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButtonInspect.Location = new System.Drawing.Point(3, 171);
            this.skinButtonInspect.MouseBack = null;
            this.skinButtonInspect.Name = "skinButtonInspect";
            this.skinButtonInspect.NormlBack = null;
            this.skinButtonInspect.Size = new System.Drawing.Size(300, 30);
            this.skinButtonInspect.TabIndex = 72;
            this.skinButtonInspect.Text = "重新检测";
            this.skinButtonInspect.UseVisualStyleBackColor = false;
            this.skinButtonInspect.Click += new System.EventHandler(this.SkinButtonInspect_Click);
            // 
            // skinButtonRepair
            // 
            this.skinButtonRepair.BackColor = System.Drawing.Color.Transparent;
            this.skinButtonRepair.BaseColor = System.Drawing.Color.LimeGreen;
            this.skinButtonRepair.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButtonRepair.DownBack = null;
            this.skinButtonRepair.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButtonRepair.Location = new System.Drawing.Point(309, 171);
            this.skinButtonRepair.MouseBack = null;
            this.skinButtonRepair.Name = "skinButtonRepair";
            this.skinButtonRepair.NormlBack = null;
            this.skinButtonRepair.Size = new System.Drawing.Size(300, 30);
            this.skinButtonRepair.TabIndex = 71;
            this.skinButtonRepair.Text = "一键修复所需文件";
            this.skinButtonRepair.UseVisualStyleBackColor = false;
            this.skinButtonRepair.Click += new System.EventHandler(this.SkinButtonRepair_Click);
            // 
            // skinGroupBoxPathTip
            // 
            this.skinGroupBoxPathTip.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBoxPathTip.BorderColor = System.Drawing.Color.Gray;
            this.skinGroupBoxPathTip.Controls.Add(this.skinTextBoxPCPath);
            this.skinGroupBoxPathTip.Controls.Add(this.skinTextBoxEmuPath);
            this.skinGroupBoxPathTip.Controls.Add(this.skinTextBoxUserConfig);
            this.skinGroupBoxPathTip.Controls.Add(this.skinTextBoxAppConfig);
            this.skinGroupBoxPathTip.Controls.Add(this.skinLabelAppConfig);
            this.skinGroupBoxPathTip.Controls.Add(this.skinLabelPCPath);
            this.skinGroupBoxPathTip.Controls.Add(this.skinLabelUserConfig);
            this.skinGroupBoxPathTip.Controls.Add(this.skinLabelEmuPath);
            this.skinGroupBoxPathTip.ForeColor = System.Drawing.Color.Black;
            this.skinGroupBoxPathTip.Location = new System.Drawing.Point(3, 3);
            this.skinGroupBoxPathTip.Name = "skinGroupBoxPathTip";
            this.skinGroupBoxPathTip.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBoxPathTip.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBoxPathTip.Size = new System.Drawing.Size(606, 162);
            this.skinGroupBoxPathTip.TabIndex = 70;
            this.skinGroupBoxPathTip.TabStop = false;
            this.skinGroupBoxPathTip.Text = "文件状态：";
            this.skinGroupBoxPathTip.TitleBorderColor = System.Drawing.Color.Transparent;
            this.skinGroupBoxPathTip.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBoxPathTip.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // skinTextBoxPCPath
            // 
            this.skinTextBoxPCPath.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBoxPCPath.DownBack = null;
            this.skinTextBoxPCPath.Icon = null;
            this.skinTextBoxPCPath.IconIsButton = false;
            this.skinTextBoxPCPath.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxPCPath.IsPasswordChat = '\0';
            this.skinTextBoxPCPath.IsSystemPasswordChar = false;
            this.skinTextBoxPCPath.Lines = new string[] {
        "已存在"};
            this.skinTextBoxPCPath.Location = new System.Drawing.Point(384, 117);
            this.skinTextBoxPCPath.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBoxPCPath.MaxLength = 32767;
            this.skinTextBoxPCPath.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBoxPCPath.MouseBack = null;
            this.skinTextBoxPCPath.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxPCPath.Multiline = false;
            this.skinTextBoxPCPath.Name = "skinTextBoxPCPath";
            this.skinTextBoxPCPath.NormlBack = null;
            this.skinTextBoxPCPath.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBoxPCPath.ReadOnly = false;
            this.skinTextBoxPCPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBoxPCPath.Size = new System.Drawing.Size(89, 28);
            // 
            // 
            // 
            this.skinTextBoxPCPath.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBoxPCPath.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBoxPCPath.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinTextBoxPCPath.SkinTxt.ForeColor = System.Drawing.Color.Green;
            this.skinTextBoxPCPath.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBoxPCPath.SkinTxt.Name = "BaseText";
            this.skinTextBoxPCPath.SkinTxt.Size = new System.Drawing.Size(79, 18);
            this.skinTextBoxPCPath.SkinTxt.TabIndex = 0;
            this.skinTextBoxPCPath.SkinTxt.Text = "已存在";
            this.skinTextBoxPCPath.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.skinTextBoxPCPath.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxPCPath.SkinTxt.WaterText = "";
            this.skinTextBoxPCPath.TabIndex = 70;
            this.skinTextBoxPCPath.Text = "已存在";
            this.skinTextBoxPCPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.skinTextBoxPCPath.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxPCPath.WaterText = "";
            this.skinTextBoxPCPath.WordWrap = true;
            // 
            // skinTextBoxEmuPath
            // 
            this.skinTextBoxEmuPath.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBoxEmuPath.DownBack = null;
            this.skinTextBoxEmuPath.Icon = null;
            this.skinTextBoxEmuPath.IconIsButton = false;
            this.skinTextBoxEmuPath.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxEmuPath.IsPasswordChat = '\0';
            this.skinTextBoxEmuPath.IsSystemPasswordChar = false;
            this.skinTextBoxEmuPath.Lines = new string[] {
        "已存在"};
            this.skinTextBoxEmuPath.Location = new System.Drawing.Point(384, 86);
            this.skinTextBoxEmuPath.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBoxEmuPath.MaxLength = 32767;
            this.skinTextBoxEmuPath.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBoxEmuPath.MouseBack = null;
            this.skinTextBoxEmuPath.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxEmuPath.Multiline = false;
            this.skinTextBoxEmuPath.Name = "skinTextBoxEmuPath";
            this.skinTextBoxEmuPath.NormlBack = null;
            this.skinTextBoxEmuPath.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBoxEmuPath.ReadOnly = false;
            this.skinTextBoxEmuPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBoxEmuPath.Size = new System.Drawing.Size(89, 28);
            // 
            // 
            // 
            this.skinTextBoxEmuPath.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBoxEmuPath.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBoxEmuPath.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinTextBoxEmuPath.SkinTxt.ForeColor = System.Drawing.Color.Green;
            this.skinTextBoxEmuPath.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBoxEmuPath.SkinTxt.Name = "BaseText";
            this.skinTextBoxEmuPath.SkinTxt.Size = new System.Drawing.Size(79, 18);
            this.skinTextBoxEmuPath.SkinTxt.TabIndex = 0;
            this.skinTextBoxEmuPath.SkinTxt.Text = "已存在";
            this.skinTextBoxEmuPath.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.skinTextBoxEmuPath.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxEmuPath.SkinTxt.WaterText = "";
            this.skinTextBoxEmuPath.TabIndex = 70;
            this.skinTextBoxEmuPath.Text = "已存在";
            this.skinTextBoxEmuPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.skinTextBoxEmuPath.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxEmuPath.WaterText = "";
            this.skinTextBoxEmuPath.WordWrap = true;
            // 
            // skinTextBoxUserConfig
            // 
            this.skinTextBoxUserConfig.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBoxUserConfig.DownBack = null;
            this.skinTextBoxUserConfig.Icon = null;
            this.skinTextBoxUserConfig.IconIsButton = false;
            this.skinTextBoxUserConfig.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxUserConfig.IsPasswordChat = '\0';
            this.skinTextBoxUserConfig.IsSystemPasswordChar = false;
            this.skinTextBoxUserConfig.Lines = new string[] {
        "已存在"};
            this.skinTextBoxUserConfig.Location = new System.Drawing.Point(384, 55);
            this.skinTextBoxUserConfig.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBoxUserConfig.MaxLength = 32767;
            this.skinTextBoxUserConfig.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBoxUserConfig.MouseBack = null;
            this.skinTextBoxUserConfig.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxUserConfig.Multiline = false;
            this.skinTextBoxUserConfig.Name = "skinTextBoxUserConfig";
            this.skinTextBoxUserConfig.NormlBack = null;
            this.skinTextBoxUserConfig.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBoxUserConfig.ReadOnly = false;
            this.skinTextBoxUserConfig.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBoxUserConfig.Size = new System.Drawing.Size(89, 28);
            // 
            // 
            // 
            this.skinTextBoxUserConfig.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBoxUserConfig.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBoxUserConfig.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinTextBoxUserConfig.SkinTxt.ForeColor = System.Drawing.Color.Green;
            this.skinTextBoxUserConfig.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBoxUserConfig.SkinTxt.Name = "BaseText";
            this.skinTextBoxUserConfig.SkinTxt.Size = new System.Drawing.Size(79, 18);
            this.skinTextBoxUserConfig.SkinTxt.TabIndex = 0;
            this.skinTextBoxUserConfig.SkinTxt.Text = "已存在";
            this.skinTextBoxUserConfig.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.skinTextBoxUserConfig.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxUserConfig.SkinTxt.WaterText = "";
            this.skinTextBoxUserConfig.TabIndex = 70;
            this.skinTextBoxUserConfig.Text = "已存在";
            this.skinTextBoxUserConfig.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.skinTextBoxUserConfig.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxUserConfig.WaterText = "";
            this.skinTextBoxUserConfig.WordWrap = true;
            // 
            // skinTextBoxAppConfig
            // 
            this.skinTextBoxAppConfig.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBoxAppConfig.DownBack = null;
            this.skinTextBoxAppConfig.Icon = null;
            this.skinTextBoxAppConfig.IconIsButton = false;
            this.skinTextBoxAppConfig.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxAppConfig.IsPasswordChat = '\0';
            this.skinTextBoxAppConfig.IsSystemPasswordChar = false;
            this.skinTextBoxAppConfig.Lines = new string[] {
        "已存在"};
            this.skinTextBoxAppConfig.Location = new System.Drawing.Point(384, 24);
            this.skinTextBoxAppConfig.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBoxAppConfig.MaxLength = 32767;
            this.skinTextBoxAppConfig.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBoxAppConfig.MouseBack = null;
            this.skinTextBoxAppConfig.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxAppConfig.Multiline = false;
            this.skinTextBoxAppConfig.Name = "skinTextBoxAppConfig";
            this.skinTextBoxAppConfig.NormlBack = null;
            this.skinTextBoxAppConfig.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBoxAppConfig.ReadOnly = false;
            this.skinTextBoxAppConfig.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBoxAppConfig.Size = new System.Drawing.Size(89, 28);
            // 
            // 
            // 
            this.skinTextBoxAppConfig.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBoxAppConfig.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBoxAppConfig.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinTextBoxAppConfig.SkinTxt.ForeColor = System.Drawing.Color.Green;
            this.skinTextBoxAppConfig.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBoxAppConfig.SkinTxt.Name = "BaseText";
            this.skinTextBoxAppConfig.SkinTxt.Size = new System.Drawing.Size(79, 18);
            this.skinTextBoxAppConfig.SkinTxt.TabIndex = 0;
            this.skinTextBoxAppConfig.SkinTxt.Text = "已存在";
            this.skinTextBoxAppConfig.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.skinTextBoxAppConfig.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxAppConfig.SkinTxt.WaterText = "";
            this.skinTextBoxAppConfig.TabIndex = 69;
            this.skinTextBoxAppConfig.Text = "已存在";
            this.skinTextBoxAppConfig.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.skinTextBoxAppConfig.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxAppConfig.WaterText = "";
            this.skinTextBoxAppConfig.WordWrap = true;
            // 
            // skinLabelAppConfig
            // 
            this.skinLabelAppConfig.AutoSize = true;
            this.skinLabelAppConfig.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelAppConfig.BorderColor = System.Drawing.Color.White;
            this.skinLabelAppConfig.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelAppConfig.Location = new System.Drawing.Point(164, 27);
            this.skinLabelAppConfig.Name = "skinLabelAppConfig";
            this.skinLabelAppConfig.Size = new System.Drawing.Size(217, 20);
            this.skinLabelAppConfig.TabIndex = 61;
            this.skinLabelAppConfig.Text = "程序配置文件(AppConfig.xml)：";
            // 
            // skinLabelPCPath
            // 
            this.skinLabelPCPath.AutoSize = true;
            this.skinLabelPCPath.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelPCPath.BorderColor = System.Drawing.Color.White;
            this.skinLabelPCPath.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelPCPath.Location = new System.Drawing.Point(142, 121);
            this.skinLabelPCPath.Name = "skinLabelPCPath";
            this.skinLabelPCPath.Size = new System.Drawing.Size(239, 20);
            this.skinLabelPCPath.TabIndex = 68;
            this.skinLabelPCPath.Text = "PC游戏配置信息文件(PCPath.xml)：";
            // 
            // skinLabelUserConfig
            // 
            this.skinLabelUserConfig.AutoSize = true;
            this.skinLabelUserConfig.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelUserConfig.BorderColor = System.Drawing.Color.White;
            this.skinLabelUserConfig.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelUserConfig.Location = new System.Drawing.Point(163, 59);
            this.skinLabelUserConfig.Name = "skinLabelUserConfig";
            this.skinLabelUserConfig.Size = new System.Drawing.Size(218, 20);
            this.skinLabelUserConfig.TabIndex = 64;
            this.skinLabelUserConfig.Text = "用户信息文件(UserConfig.xml)：";
            // 
            // skinLabelEmuPath
            // 
            this.skinLabelEmuPath.AutoSize = true;
            this.skinLabelEmuPath.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelEmuPath.BorderColor = System.Drawing.Color.White;
            this.skinLabelEmuPath.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelEmuPath.Location = new System.Drawing.Point(106, 90);
            this.skinLabelEmuPath.Name = "skinLabelEmuPath";
            this.skinLabelEmuPath.Size = new System.Drawing.Size(275, 20);
            this.skinLabelEmuPath.TabIndex = 67;
            this.skinLabelEmuPath.Text = "模拟器软件配置信息文件(EmuPath.xml)：";
            // 
            // skinLabelBr1
            // 
            this.skinLabelBr1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelBr1.BorderColor = System.Drawing.Color.White;
            this.skinLabelBr1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.skinLabelBr1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelBr1.Location = new System.Drawing.Point(7, 476);
            this.skinLabelBr1.Name = "skinLabelBr1";
            this.skinLabelBr1.Size = new System.Drawing.Size(617, 23);
            this.skinLabelBr1.TabIndex = 46;
            this.skinLabelBr1.Text = "----- 更多设置敬请期待 -----";
            this.skinLabelBr1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(630, 540);
            this.ControlBoxActive = System.Drawing.Color.Black;
            this.ControlBoxDeactive = System.Drawing.Color.Black;
            this.Controls.Add(this.skinLabelBr1);
            this.Controls.Add(this.skinTabControlSelect);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClear);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置中心";
            this.Load += new System.EventHandler(this.FormSetting_Load);
            this.skinTabControlSelect.ResumeLayout(false);
            this.skinTabPageSetting.ResumeLayout(false);
            this.skinGroupBoxBackup.ResumeLayout(false);
            this.skinTabPageRepair.ResumeLayout(false);
            this.skinGroupBoxPathTip.ResumeLayout(false);
            this.skinGroupBoxPathTip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinButton buttonSave;
        private CCWin.SkinControl.SkinButton buttonClear;
        private CCWin.SkinControl.SkinTabControl skinTabControlSelect;
        private CCWin.SkinControl.SkinTabPage skinTabPageSetting;
        private CCWin.SkinControl.SkinTabPage skinTabPageRepair;
        private CCWin.SkinControl.SkinLabel skinLabelBr1;
        private CCWin.SkinControl.SkinButton skinButtonInspect;
        private CCWin.SkinControl.SkinButton skinButtonRepair;
        private CCWin.SkinControl.SkinGroupBox skinGroupBoxPathTip;
        private CCWin.SkinControl.SkinTextBox skinTextBoxPCPath;
        private CCWin.SkinControl.SkinTextBox skinTextBoxEmuPath;
        private CCWin.SkinControl.SkinTextBox skinTextBoxUserConfig;
        private CCWin.SkinControl.SkinTextBox skinTextBoxAppConfig;
        private CCWin.SkinControl.SkinLabel skinLabelAppConfig;
        private CCWin.SkinControl.SkinLabel skinLabelPCPath;
        private CCWin.SkinControl.SkinLabel skinLabelUserConfig;
        private CCWin.SkinControl.SkinLabel skinLabelEmuPath;
        private CCWin.SkinControl.SkinGroupBox skinGroupBoxBackup;
        private CCWin.SkinControl.SkinButton skinButtonRecovery;
        private CCWin.SkinControl.SkinButton skinButtonBackup;
    }
}