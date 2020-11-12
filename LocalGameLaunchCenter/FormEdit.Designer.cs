namespace LocalGameLaunchCenter
{
    partial class FormEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEdit));
            this.folderBrowserDialogPath = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialogStartName = new System.Windows.Forms.OpenFileDialog();
            this.skinTabControlType = new CCWin.SkinControl.SkinTabControl();
            this.skinTabPagePC = new CCWin.SkinControl.SkinTabPage();
            this.skinButtonUpdatePCImg = new CCWin.SkinControl.SkinButton();
            this.skinLabelPCTip = new CCWin.SkinControl.SkinLabel();
            this.skinTextBoxPCTip = new CCWin.SkinControl.SkinTextBox();
            this.skinPictureBoxPCImg = new CCWin.SkinControl.SkinPictureBox();
            this.skinLabelPCImg = new CCWin.SkinControl.SkinLabel();
            this.buttonStartName = new CCWin.SkinControl.SkinButton();
            this.buttonSavePath = new CCWin.SkinControl.SkinButton();
            this.buttonGamePath = new CCWin.SkinControl.SkinButton();
            this.textBoxStartName = new CCWin.SkinControl.SkinTextBox();
            this.textBoxSavePath = new CCWin.SkinControl.SkinTextBox();
            this.textBoxGameType = new CCWin.SkinControl.SkinTextBox();
            this.textBoxGamePath = new CCWin.SkinControl.SkinTextBox();
            this.textBoxGameName = new CCWin.SkinControl.SkinTextBox();
            this.labelPCStartName = new CCWin.SkinControl.SkinLabel();
            this.labelPCSavePath = new CCWin.SkinControl.SkinLabel();
            this.labelPCGamePath = new CCWin.SkinControl.SkinLabel();
            this.labelPCGameType = new CCWin.SkinControl.SkinLabel();
            this.labelPCGameName = new CCWin.SkinControl.SkinLabel();
            this.skinTabPageEmu = new CCWin.SkinControl.SkinTabPage();
            this.skinButtonUpdateEmuImg = new CCWin.SkinControl.SkinButton();
            this.skinPictureBoxEmuImg = new CCWin.SkinControl.SkinPictureBox();
            this.skinLabelEmuImg = new CCWin.SkinControl.SkinLabel();
            this.skinLabelEmuTip = new CCWin.SkinControl.SkinLabel();
            this.skinTextBoxEmuTip = new CCWin.SkinControl.SkinTextBox();
            this.buttonEmuName = new CCWin.SkinControl.SkinButton();
            this.buttonEmuGamePath = new CCWin.SkinControl.SkinButton();
            this.buttonEmuFilePath = new CCWin.SkinControl.SkinButton();
            this.textBoxExplain = new CCWin.SkinControl.SkinTextBox();
            this.textBoxRomPath = new CCWin.SkinControl.SkinTextBox();
            this.textBoxFilePath = new CCWin.SkinControl.SkinTextBox();
            this.textBoxEmuName = new CCWin.SkinControl.SkinTextBox();
            this.textBoxName = new CCWin.SkinControl.SkinTextBox();
            this.labelExplain = new CCWin.SkinControl.SkinLabel();
            this.labelRomPath = new CCWin.SkinControl.SkinLabel();
            this.labelEmuName = new CCWin.SkinControl.SkinLabel();
            this.labelFilePath = new CCWin.SkinControl.SkinLabel();
            this.labelName = new CCWin.SkinControl.SkinLabel();
            this.buttonSave = new CCWin.SkinControl.SkinButton();
            this.buttonClear = new CCWin.SkinControl.SkinButton();
            this.openFileDialogImg = new System.Windows.Forms.OpenFileDialog();
            this.toolTipThis = new System.Windows.Forms.ToolTip(this.components);
            this.skinTabControlType.SuspendLayout();
            this.skinTabPagePC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBoxPCImg)).BeginInit();
            this.skinTabPageEmu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBoxEmuImg)).BeginInit();
            this.SuspendLayout();
            // 
            // folderBrowserDialogPath
            // 
            this.folderBrowserDialogPath.Description = "请选择文件路径";
            // 
            // openFileDialogStartName
            // 
            this.openFileDialogStartName.Title = "请选择执行游戏启动程序";
            // 
            // skinTabControlType
            // 
            this.skinTabControlType.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.skinTabControlType.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.skinTabControlType.Controls.Add(this.skinTabPagePC);
            this.skinTabControlType.Controls.Add(this.skinTabPageEmu);
            this.skinTabControlType.DrawType = CCWin.SkinControl.DrawStyle.Draw;
            this.skinTabControlType.HeadBack = null;
            this.skinTabControlType.ImeMode = System.Windows.Forms.ImeMode.On;
            this.skinTabControlType.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.skinTabControlType.ItemSize = new System.Drawing.Size(70, 36);
            this.skinTabControlType.Location = new System.Drawing.Point(7, 31);
            this.skinTabControlType.Name = "skinTabControlType";
            this.skinTabControlType.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("skinTabControlType.PageArrowDown")));
            this.skinTabControlType.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("skinTabControlType.PageArrowHover")));
            this.skinTabControlType.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("skinTabControlType.PageCloseHover")));
            this.skinTabControlType.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("skinTabControlType.PageCloseNormal")));
            this.skinTabControlType.PageDown = ((System.Drawing.Image)(resources.GetObject("skinTabControlType.PageDown")));
            this.skinTabControlType.PageHover = ((System.Drawing.Image)(resources.GetObject("skinTabControlType.PageHover")));
            this.skinTabControlType.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.skinTabControlType.PageNorml = null;
            this.skinTabControlType.SelectedIndex = 1;
            this.skinTabControlType.Size = new System.Drawing.Size(666, 435);
            this.skinTabControlType.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.skinTabControlType.TabIndex = 15;
            // 
            // skinTabPagePC
            // 
            this.skinTabPagePC.BackColor = System.Drawing.Color.White;
            this.skinTabPagePC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.skinTabPagePC.Controls.Add(this.skinButtonUpdatePCImg);
            this.skinTabPagePC.Controls.Add(this.skinLabelPCTip);
            this.skinTabPagePC.Controls.Add(this.skinTextBoxPCTip);
            this.skinTabPagePC.Controls.Add(this.skinPictureBoxPCImg);
            this.skinTabPagePC.Controls.Add(this.skinLabelPCImg);
            this.skinTabPagePC.Controls.Add(this.buttonStartName);
            this.skinTabPagePC.Controls.Add(this.buttonSavePath);
            this.skinTabPagePC.Controls.Add(this.buttonGamePath);
            this.skinTabPagePC.Controls.Add(this.textBoxStartName);
            this.skinTabPagePC.Controls.Add(this.textBoxSavePath);
            this.skinTabPagePC.Controls.Add(this.textBoxGameType);
            this.skinTabPagePC.Controls.Add(this.textBoxGamePath);
            this.skinTabPagePC.Controls.Add(this.textBoxGameName);
            this.skinTabPagePC.Controls.Add(this.labelPCStartName);
            this.skinTabPagePC.Controls.Add(this.labelPCSavePath);
            this.skinTabPagePC.Controls.Add(this.labelPCGamePath);
            this.skinTabPagePC.Controls.Add(this.labelPCGameType);
            this.skinTabPagePC.Controls.Add(this.labelPCGameName);
            this.skinTabPagePC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPagePC.Location = new System.Drawing.Point(0, 36);
            this.skinTabPagePC.Name = "skinTabPagePC";
            this.skinTabPagePC.Size = new System.Drawing.Size(666, 399);
            this.skinTabPagePC.TabIndex = 0;
            this.skinTabPagePC.TabItemImage = null;
            this.skinTabPagePC.Text = "编辑Windows电脑游戏数据";
            // 
            // skinButtonUpdatePCImg
            // 
            this.skinButtonUpdatePCImg.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.skinButtonUpdatePCImg.BackColor = System.Drawing.Color.Transparent;
            this.skinButtonUpdatePCImg.BaseColor = System.Drawing.Color.Lavender;
            this.skinButtonUpdatePCImg.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButtonUpdatePCImg.DownBack = null;
            this.skinButtonUpdatePCImg.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButtonUpdatePCImg.Location = new System.Drawing.Point(10, 364);
            this.skinButtonUpdatePCImg.MouseBack = null;
            this.skinButtonUpdatePCImg.Name = "skinButtonUpdatePCImg";
            this.skinButtonUpdatePCImg.NormlBack = null;
            this.skinButtonUpdatePCImg.Size = new System.Drawing.Size(120, 28);
            this.skinButtonUpdatePCImg.TabIndex = 6;
            this.skinButtonUpdatePCImg.Text = "更改图片";
            this.skinButtonUpdatePCImg.UseVisualStyleBackColor = false;
            this.skinButtonUpdatePCImg.Click += new System.EventHandler(this.SkinButtonUpdatePCImg_Click);
            // 
            // skinLabelPCTip
            // 
            this.skinLabelPCTip.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelPCTip.BorderColor = System.Drawing.Color.White;
            this.skinLabelPCTip.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelPCTip.Location = new System.Drawing.Point(139, 178);
            this.skinLabelPCTip.Name = "skinLabelPCTip";
            this.skinLabelPCTip.Size = new System.Drawing.Size(506, 21);
            this.skinLabelPCTip.TabIndex = 67;
            this.skinLabelPCTip.Text = "游戏详细信息文本：";
            // 
            // skinTextBoxPCTip
            // 
            this.skinTextBoxPCTip.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBoxPCTip.DownBack = null;
            this.skinTextBoxPCTip.Icon = null;
            this.skinTextBoxPCTip.IconIsButton = false;
            this.skinTextBoxPCTip.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxPCTip.IsPasswordChat = '\0';
            this.skinTextBoxPCTip.IsSystemPasswordChar = false;
            this.skinTextBoxPCTip.Lines = new string[0];
            this.skinTextBoxPCTip.Location = new System.Drawing.Point(143, 201);
            this.skinTextBoxPCTip.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBoxPCTip.MaxLength = 32767;
            this.skinTextBoxPCTip.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBoxPCTip.MouseBack = null;
            this.skinTextBoxPCTip.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxPCTip.Multiline = true;
            this.skinTextBoxPCTip.Name = "skinTextBoxPCTip";
            this.skinTextBoxPCTip.NormlBack = null;
            this.skinTextBoxPCTip.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBoxPCTip.ReadOnly = false;
            this.skinTextBoxPCTip.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBoxPCTip.Size = new System.Drawing.Size(502, 191);
            // 
            // 
            // 
            this.skinTextBoxPCTip.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBoxPCTip.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBoxPCTip.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBoxPCTip.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBoxPCTip.SkinTxt.Multiline = true;
            this.skinTextBoxPCTip.SkinTxt.Name = "BaseText";
            this.skinTextBoxPCTip.SkinTxt.Size = new System.Drawing.Size(492, 181);
            this.skinTextBoxPCTip.SkinTxt.TabIndex = 0;
            this.skinTextBoxPCTip.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxPCTip.SkinTxt.WaterText = "在这里填写文本内容";
            this.skinTextBoxPCTip.TabIndex = 7;
            this.skinTextBoxPCTip.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBoxPCTip.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxPCTip.WaterText = "在这里填写文本内容";
            this.skinTextBoxPCTip.WordWrap = true;
            // 
            // skinPictureBoxPCImg
            // 
            this.skinPictureBoxPCImg.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBoxPCImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.skinPictureBoxPCImg.Location = new System.Drawing.Point(10, 201);
            this.skinPictureBoxPCImg.Name = "skinPictureBoxPCImg";
            this.skinPictureBoxPCImg.Size = new System.Drawing.Size(120, 160);
            this.skinPictureBoxPCImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.skinPictureBoxPCImg.TabIndex = 65;
            this.skinPictureBoxPCImg.TabStop = false;
            this.toolTipThis.SetToolTip(this.skinPictureBoxPCImg, "建议图像规格：\r\n大小：120 x 160\r\n图片方向：竖屏\r\n图片形状：长方形\r\n");
            // 
            // skinLabelPCImg
            // 
            this.skinLabelPCImg.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelPCImg.BorderColor = System.Drawing.Color.White;
            this.skinLabelPCImg.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelPCImg.Location = new System.Drawing.Point(10, 177);
            this.skinLabelPCImg.Name = "skinLabelPCImg";
            this.skinLabelPCImg.Size = new System.Drawing.Size(130, 21);
            this.skinLabelPCImg.TabIndex = 64;
            this.skinLabelPCImg.Text = "游戏封面图片：";
            // 
            // buttonStartName
            // 
            this.buttonStartName.BackColor = System.Drawing.Color.Transparent;
            this.buttonStartName.BaseColor = System.Drawing.Color.LightBlue;
            this.buttonStartName.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.buttonStartName.DownBack = null;
            this.buttonStartName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonStartName.Location = new System.Drawing.Point(534, 141);
            this.buttonStartName.MouseBack = null;
            this.buttonStartName.Name = "buttonStartName";
            this.buttonStartName.NormlBack = null;
            this.buttonStartName.Size = new System.Drawing.Size(111, 28);
            this.buttonStartName.TabIndex = 5;
            this.buttonStartName.Text = "选择文件";
            this.buttonStartName.UseVisualStyleBackColor = false;
            this.buttonStartName.Click += new System.EventHandler(this.ButtonStartName_Click);
            // 
            // buttonSavePath
            // 
            this.buttonSavePath.BackColor = System.Drawing.Color.Transparent;
            this.buttonSavePath.BaseColor = System.Drawing.Color.LightBlue;
            this.buttonSavePath.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.buttonSavePath.DownBack = null;
            this.buttonSavePath.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSavePath.Location = new System.Drawing.Point(534, 109);
            this.buttonSavePath.MouseBack = null;
            this.buttonSavePath.Name = "buttonSavePath";
            this.buttonSavePath.NormlBack = null;
            this.buttonSavePath.Size = new System.Drawing.Size(111, 28);
            this.buttonSavePath.TabIndex = 4;
            this.buttonSavePath.Text = "选择位置";
            this.buttonSavePath.UseVisualStyleBackColor = false;
            this.buttonSavePath.Click += new System.EventHandler(this.ButtonSavePath_Click);
            // 
            // buttonGamePath
            // 
            this.buttonGamePath.BackColor = System.Drawing.Color.Transparent;
            this.buttonGamePath.BaseColor = System.Drawing.Color.LightBlue;
            this.buttonGamePath.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.buttonGamePath.DownBack = null;
            this.buttonGamePath.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonGamePath.Location = new System.Drawing.Point(534, 76);
            this.buttonGamePath.MouseBack = null;
            this.buttonGamePath.Name = "buttonGamePath";
            this.buttonGamePath.NormlBack = null;
            this.buttonGamePath.Size = new System.Drawing.Size(111, 28);
            this.buttonGamePath.TabIndex = 3;
            this.buttonGamePath.Text = "选择位置";
            this.buttonGamePath.UseVisualStyleBackColor = false;
            this.buttonGamePath.Click += new System.EventHandler(this.ButtonGamePath_Click);
            // 
            // textBoxStartName
            // 
            this.textBoxStartName.BackColor = System.Drawing.Color.Transparent;
            this.textBoxStartName.DownBack = null;
            this.textBoxStartName.Icon = null;
            this.textBoxStartName.IconIsButton = false;
            this.textBoxStartName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBoxStartName.IsPasswordChat = '\0';
            this.textBoxStartName.IsSystemPasswordChar = false;
            this.textBoxStartName.Lines = new string[0];
            this.textBoxStartName.Location = new System.Drawing.Point(124, 141);
            this.textBoxStartName.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxStartName.MaxLength = 32767;
            this.textBoxStartName.MinimumSize = new System.Drawing.Size(28, 28);
            this.textBoxStartName.MouseBack = null;
            this.textBoxStartName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBoxStartName.Multiline = false;
            this.textBoxStartName.Name = "textBoxStartName";
            this.textBoxStartName.NormlBack = null;
            this.textBoxStartName.Padding = new System.Windows.Forms.Padding(5);
            this.textBoxStartName.ReadOnly = false;
            this.textBoxStartName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxStartName.Size = new System.Drawing.Size(407, 28);
            // 
            // 
            // 
            this.textBoxStartName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStartName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxStartName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.textBoxStartName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.textBoxStartName.SkinTxt.Name = "BaseText";
            this.textBoxStartName.SkinTxt.Size = new System.Drawing.Size(397, 18);
            this.textBoxStartName.SkinTxt.TabIndex = 0;
            this.textBoxStartName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBoxStartName.SkinTxt.WaterText = "";
            this.textBoxStartName.TabIndex = 5;
            this.textBoxStartName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxStartName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBoxStartName.WaterText = "";
            this.textBoxStartName.WordWrap = true;
            // 
            // textBoxSavePath
            // 
            this.textBoxSavePath.BackColor = System.Drawing.Color.Transparent;
            this.textBoxSavePath.DownBack = null;
            this.textBoxSavePath.Icon = null;
            this.textBoxSavePath.IconIsButton = false;
            this.textBoxSavePath.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBoxSavePath.IsPasswordChat = '\0';
            this.textBoxSavePath.IsSystemPasswordChar = false;
            this.textBoxSavePath.Lines = new string[0];
            this.textBoxSavePath.Location = new System.Drawing.Point(124, 108);
            this.textBoxSavePath.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxSavePath.MaxLength = 32767;
            this.textBoxSavePath.MinimumSize = new System.Drawing.Size(28, 28);
            this.textBoxSavePath.MouseBack = null;
            this.textBoxSavePath.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBoxSavePath.Multiline = false;
            this.textBoxSavePath.Name = "textBoxSavePath";
            this.textBoxSavePath.NormlBack = null;
            this.textBoxSavePath.Padding = new System.Windows.Forms.Padding(5);
            this.textBoxSavePath.ReadOnly = false;
            this.textBoxSavePath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxSavePath.Size = new System.Drawing.Size(407, 28);
            // 
            // 
            // 
            this.textBoxSavePath.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSavePath.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSavePath.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.textBoxSavePath.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.textBoxSavePath.SkinTxt.Name = "BaseText";
            this.textBoxSavePath.SkinTxt.Size = new System.Drawing.Size(397, 18);
            this.textBoxSavePath.SkinTxt.TabIndex = 0;
            this.textBoxSavePath.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBoxSavePath.SkinTxt.WaterText = "";
            this.textBoxSavePath.TabIndex = 4;
            this.textBoxSavePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxSavePath.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBoxSavePath.WaterText = "";
            this.textBoxSavePath.WordWrap = true;
            // 
            // textBoxGameType
            // 
            this.textBoxGameType.BackColor = System.Drawing.Color.Transparent;
            this.textBoxGameType.DownBack = null;
            this.textBoxGameType.Icon = null;
            this.textBoxGameType.IconIsButton = false;
            this.textBoxGameType.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBoxGameType.IsPasswordChat = '\0';
            this.textBoxGameType.IsSystemPasswordChar = false;
            this.textBoxGameType.Lines = new string[0];
            this.textBoxGameType.Location = new System.Drawing.Point(124, 42);
            this.textBoxGameType.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxGameType.MaxLength = 32767;
            this.textBoxGameType.MinimumSize = new System.Drawing.Size(28, 28);
            this.textBoxGameType.MouseBack = null;
            this.textBoxGameType.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBoxGameType.Multiline = false;
            this.textBoxGameType.Name = "textBoxGameType";
            this.textBoxGameType.NormlBack = null;
            this.textBoxGameType.Padding = new System.Windows.Forms.Padding(5);
            this.textBoxGameType.ReadOnly = false;
            this.textBoxGameType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxGameType.Size = new System.Drawing.Size(407, 28);
            // 
            // 
            // 
            this.textBoxGameType.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxGameType.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxGameType.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.textBoxGameType.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.textBoxGameType.SkinTxt.Name = "BaseText";
            this.textBoxGameType.SkinTxt.Size = new System.Drawing.Size(397, 18);
            this.textBoxGameType.SkinTxt.TabIndex = 0;
            this.textBoxGameType.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBoxGameType.SkinTxt.WaterText = "";
            this.textBoxGameType.TabIndex = 2;
            this.textBoxGameType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxGameType.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBoxGameType.WaterText = "";
            this.textBoxGameType.WordWrap = true;
            // 
            // textBoxGamePath
            // 
            this.textBoxGamePath.BackColor = System.Drawing.Color.Transparent;
            this.textBoxGamePath.DownBack = null;
            this.textBoxGamePath.Icon = null;
            this.textBoxGamePath.IconIsButton = false;
            this.textBoxGamePath.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBoxGamePath.IsPasswordChat = '\0';
            this.textBoxGamePath.IsSystemPasswordChar = false;
            this.textBoxGamePath.Lines = new string[0];
            this.textBoxGamePath.Location = new System.Drawing.Point(124, 75);
            this.textBoxGamePath.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxGamePath.MaxLength = 32767;
            this.textBoxGamePath.MinimumSize = new System.Drawing.Size(28, 28);
            this.textBoxGamePath.MouseBack = null;
            this.textBoxGamePath.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBoxGamePath.Multiline = false;
            this.textBoxGamePath.Name = "textBoxGamePath";
            this.textBoxGamePath.NormlBack = null;
            this.textBoxGamePath.Padding = new System.Windows.Forms.Padding(5);
            this.textBoxGamePath.ReadOnly = false;
            this.textBoxGamePath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxGamePath.Size = new System.Drawing.Size(407, 28);
            // 
            // 
            // 
            this.textBoxGamePath.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxGamePath.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxGamePath.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.textBoxGamePath.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.textBoxGamePath.SkinTxt.Name = "BaseText";
            this.textBoxGamePath.SkinTxt.Size = new System.Drawing.Size(397, 18);
            this.textBoxGamePath.SkinTxt.TabIndex = 0;
            this.textBoxGamePath.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBoxGamePath.SkinTxt.WaterText = "";
            this.textBoxGamePath.TabIndex = 3;
            this.textBoxGamePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxGamePath.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBoxGamePath.WaterText = "";
            this.textBoxGamePath.WordWrap = true;
            // 
            // textBoxGameName
            // 
            this.textBoxGameName.BackColor = System.Drawing.Color.Transparent;
            this.textBoxGameName.DownBack = null;
            this.textBoxGameName.Icon = null;
            this.textBoxGameName.IconIsButton = false;
            this.textBoxGameName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBoxGameName.IsPasswordChat = '\0';
            this.textBoxGameName.IsSystemPasswordChar = false;
            this.textBoxGameName.Lines = new string[0];
            this.textBoxGameName.Location = new System.Drawing.Point(124, 9);
            this.textBoxGameName.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxGameName.MaxLength = 32767;
            this.textBoxGameName.MinimumSize = new System.Drawing.Size(28, 28);
            this.textBoxGameName.MouseBack = null;
            this.textBoxGameName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBoxGameName.Multiline = false;
            this.textBoxGameName.Name = "textBoxGameName";
            this.textBoxGameName.NormlBack = null;
            this.textBoxGameName.Padding = new System.Windows.Forms.Padding(5);
            this.textBoxGameName.ReadOnly = false;
            this.textBoxGameName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxGameName.Size = new System.Drawing.Size(407, 28);
            // 
            // 
            // 
            this.textBoxGameName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxGameName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxGameName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.textBoxGameName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.textBoxGameName.SkinTxt.Name = "BaseText";
            this.textBoxGameName.SkinTxt.Size = new System.Drawing.Size(397, 18);
            this.textBoxGameName.SkinTxt.TabIndex = 0;
            this.textBoxGameName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBoxGameName.SkinTxt.WaterText = "";
            this.textBoxGameName.TabIndex = 1;
            this.textBoxGameName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxGameName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBoxGameName.WaterText = "";
            this.textBoxGameName.WordWrap = true;
            // 
            // labelPCStartName
            // 
            this.labelPCStartName.AutoSize = true;
            this.labelPCStartName.BackColor = System.Drawing.Color.Transparent;
            this.labelPCStartName.BorderColor = System.Drawing.Color.White;
            this.labelPCStartName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPCStartName.Location = new System.Drawing.Point(13, 144);
            this.labelPCStartName.Name = "labelPCStartName";
            this.labelPCStartName.Size = new System.Drawing.Size(122, 21);
            this.labelPCStartName.TabIndex = 34;
            this.labelPCStartName.Text = "启动程序名称：";
            // 
            // labelPCSavePath
            // 
            this.labelPCSavePath.AutoSize = true;
            this.labelPCSavePath.BackColor = System.Drawing.Color.Transparent;
            this.labelPCSavePath.BorderColor = System.Drawing.Color.White;
            this.labelPCSavePath.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPCSavePath.Location = new System.Drawing.Point(13, 111);
            this.labelPCSavePath.Name = "labelPCSavePath";
            this.labelPCSavePath.Size = new System.Drawing.Size(122, 21);
            this.labelPCSavePath.TabIndex = 33;
            this.labelPCSavePath.Text = "游戏存档路径：";
            // 
            // labelPCGamePath
            // 
            this.labelPCGamePath.AutoSize = true;
            this.labelPCGamePath.BackColor = System.Drawing.Color.Transparent;
            this.labelPCGamePath.BorderColor = System.Drawing.Color.White;
            this.labelPCGamePath.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPCGamePath.Location = new System.Drawing.Point(13, 78);
            this.labelPCGamePath.Name = "labelPCGamePath";
            this.labelPCGamePath.Size = new System.Drawing.Size(122, 21);
            this.labelPCGamePath.TabIndex = 32;
            this.labelPCGamePath.Text = "启动程序路径：";
            // 
            // labelPCGameType
            // 
            this.labelPCGameType.AutoSize = true;
            this.labelPCGameType.BackColor = System.Drawing.Color.Transparent;
            this.labelPCGameType.BorderColor = System.Drawing.Color.White;
            this.labelPCGameType.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPCGameType.Location = new System.Drawing.Point(45, 45);
            this.labelPCGameType.Name = "labelPCGameType";
            this.labelPCGameType.Size = new System.Drawing.Size(90, 21);
            this.labelPCGameType.TabIndex = 31;
            this.labelPCGameType.Text = "游戏类型：";
            // 
            // labelPCGameName
            // 
            this.labelPCGameName.AutoSize = true;
            this.labelPCGameName.BackColor = System.Drawing.Color.Transparent;
            this.labelPCGameName.BorderColor = System.Drawing.Color.White;
            this.labelPCGameName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPCGameName.Location = new System.Drawing.Point(45, 12);
            this.labelPCGameName.Name = "labelPCGameName";
            this.labelPCGameName.Size = new System.Drawing.Size(90, 21);
            this.labelPCGameName.TabIndex = 30;
            this.labelPCGameName.Text = "游戏名称：";
            // 
            // skinTabPageEmu
            // 
            this.skinTabPageEmu.BackColor = System.Drawing.Color.White;
            this.skinTabPageEmu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.skinTabPageEmu.Controls.Add(this.skinButtonUpdateEmuImg);
            this.skinTabPageEmu.Controls.Add(this.skinPictureBoxEmuImg);
            this.skinTabPageEmu.Controls.Add(this.skinLabelEmuImg);
            this.skinTabPageEmu.Controls.Add(this.skinLabelEmuTip);
            this.skinTabPageEmu.Controls.Add(this.skinTextBoxEmuTip);
            this.skinTabPageEmu.Controls.Add(this.buttonEmuName);
            this.skinTabPageEmu.Controls.Add(this.buttonEmuGamePath);
            this.skinTabPageEmu.Controls.Add(this.buttonEmuFilePath);
            this.skinTabPageEmu.Controls.Add(this.textBoxExplain);
            this.skinTabPageEmu.Controls.Add(this.textBoxRomPath);
            this.skinTabPageEmu.Controls.Add(this.textBoxFilePath);
            this.skinTabPageEmu.Controls.Add(this.textBoxEmuName);
            this.skinTabPageEmu.Controls.Add(this.textBoxName);
            this.skinTabPageEmu.Controls.Add(this.labelExplain);
            this.skinTabPageEmu.Controls.Add(this.labelRomPath);
            this.skinTabPageEmu.Controls.Add(this.labelEmuName);
            this.skinTabPageEmu.Controls.Add(this.labelFilePath);
            this.skinTabPageEmu.Controls.Add(this.labelName);
            this.skinTabPageEmu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPageEmu.Location = new System.Drawing.Point(0, 36);
            this.skinTabPageEmu.Name = "skinTabPageEmu";
            this.skinTabPageEmu.Size = new System.Drawing.Size(666, 399);
            this.skinTabPageEmu.TabIndex = 1;
            this.skinTabPageEmu.TabItemImage = null;
            this.skinTabPageEmu.Text = "编辑模拟器软件数据";
            // 
            // skinButtonUpdateEmuImg
            // 
            this.skinButtonUpdateEmuImg.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.skinButtonUpdateEmuImg.BackColor = System.Drawing.Color.Transparent;
            this.skinButtonUpdateEmuImg.BaseColor = System.Drawing.Color.Lavender;
            this.skinButtonUpdateEmuImg.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButtonUpdateEmuImg.DownBack = null;
            this.skinButtonUpdateEmuImg.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButtonUpdateEmuImg.Location = new System.Drawing.Point(10, 335);
            this.skinButtonUpdateEmuImg.MouseBack = null;
            this.skinButtonUpdateEmuImg.Name = "skinButtonUpdateEmuImg";
            this.skinButtonUpdateEmuImg.NormlBack = null;
            this.skinButtonUpdateEmuImg.Size = new System.Drawing.Size(130, 44);
            this.skinButtonUpdateEmuImg.TabIndex = 6;
            this.skinButtonUpdateEmuImg.Text = "更改图片";
            this.skinButtonUpdateEmuImg.UseVisualStyleBackColor = false;
            this.skinButtonUpdateEmuImg.Click += new System.EventHandler(this.SkinButtonUpdateEmuImg_Click);
            // 
            // skinPictureBoxEmuImg
            // 
            this.skinPictureBoxEmuImg.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBoxEmuImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.skinPictureBoxEmuImg.Location = new System.Drawing.Point(10, 199);
            this.skinPictureBoxEmuImg.Name = "skinPictureBoxEmuImg";
            this.skinPictureBoxEmuImg.Size = new System.Drawing.Size(130, 130);
            this.skinPictureBoxEmuImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.skinPictureBoxEmuImg.TabIndex = 71;
            this.skinPictureBoxEmuImg.TabStop = false;
            this.toolTipThis.SetToolTip(this.skinPictureBoxEmuImg, "建议图像规格：\r\n大小：130 x 130\r\n图片方向：竖屏\r\n图片形状：正方形\r\n");
            // 
            // skinLabelEmuImg
            // 
            this.skinLabelEmuImg.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelEmuImg.BorderColor = System.Drawing.Color.White;
            this.skinLabelEmuImg.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelEmuImg.Location = new System.Drawing.Point(10, 175);
            this.skinLabelEmuImg.Name = "skinLabelEmuImg";
            this.skinLabelEmuImg.Size = new System.Drawing.Size(130, 21);
            this.skinLabelEmuImg.TabIndex = 70;
            this.skinLabelEmuImg.Text = "平台样式图：";
            // 
            // skinLabelEmuTip
            // 
            this.skinLabelEmuTip.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelEmuTip.BorderColor = System.Drawing.Color.White;
            this.skinLabelEmuTip.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelEmuTip.Location = new System.Drawing.Point(139, 176);
            this.skinLabelEmuTip.Name = "skinLabelEmuTip";
            this.skinLabelEmuTip.Size = new System.Drawing.Size(506, 21);
            this.skinLabelEmuTip.TabIndex = 69;
            this.skinLabelEmuTip.Text = "模拟器详细信息文本：";
            // 
            // skinTextBoxEmuTip
            // 
            this.skinTextBoxEmuTip.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBoxEmuTip.DownBack = null;
            this.skinTextBoxEmuTip.Icon = null;
            this.skinTextBoxEmuTip.IconIsButton = false;
            this.skinTextBoxEmuTip.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxEmuTip.IsPasswordChat = '\0';
            this.skinTextBoxEmuTip.IsSystemPasswordChar = false;
            this.skinTextBoxEmuTip.Lines = new string[0];
            this.skinTextBoxEmuTip.Location = new System.Drawing.Point(143, 199);
            this.skinTextBoxEmuTip.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBoxEmuTip.MaxLength = 32767;
            this.skinTextBoxEmuTip.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBoxEmuTip.MouseBack = null;
            this.skinTextBoxEmuTip.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxEmuTip.Multiline = true;
            this.skinTextBoxEmuTip.Name = "skinTextBoxEmuTip";
            this.skinTextBoxEmuTip.NormlBack = null;
            this.skinTextBoxEmuTip.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBoxEmuTip.ReadOnly = false;
            this.skinTextBoxEmuTip.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBoxEmuTip.Size = new System.Drawing.Size(502, 180);
            // 
            // 
            // 
            this.skinTextBoxEmuTip.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBoxEmuTip.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBoxEmuTip.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBoxEmuTip.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBoxEmuTip.SkinTxt.Multiline = true;
            this.skinTextBoxEmuTip.SkinTxt.Name = "BaseText";
            this.skinTextBoxEmuTip.SkinTxt.Size = new System.Drawing.Size(492, 170);
            this.skinTextBoxEmuTip.SkinTxt.TabIndex = 0;
            this.skinTextBoxEmuTip.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxEmuTip.SkinTxt.WaterText = "在这里填写文本内容";
            this.skinTextBoxEmuTip.TabIndex = 7;
            this.skinTextBoxEmuTip.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBoxEmuTip.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxEmuTip.WaterText = "在这里填写文本内容";
            this.skinTextBoxEmuTip.WordWrap = true;
            // 
            // buttonEmuName
            // 
            this.buttonEmuName.BackColor = System.Drawing.Color.Transparent;
            this.buttonEmuName.BaseColor = System.Drawing.Color.LightBlue;
            this.buttonEmuName.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.buttonEmuName.DownBack = null;
            this.buttonEmuName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonEmuName.Location = new System.Drawing.Point(534, 75);
            this.buttonEmuName.MouseBack = null;
            this.buttonEmuName.Name = "buttonEmuName";
            this.buttonEmuName.NormlBack = null;
            this.buttonEmuName.Size = new System.Drawing.Size(111, 28);
            this.buttonEmuName.TabIndex = 3;
            this.buttonEmuName.Text = "选择文件";
            this.buttonEmuName.UseVisualStyleBackColor = false;
            this.buttonEmuName.Click += new System.EventHandler(this.ButtonEmuName_Click);
            // 
            // buttonEmuGamePath
            // 
            this.buttonEmuGamePath.BackColor = System.Drawing.Color.Transparent;
            this.buttonEmuGamePath.BaseColor = System.Drawing.Color.LightBlue;
            this.buttonEmuGamePath.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.buttonEmuGamePath.DownBack = null;
            this.buttonEmuGamePath.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonEmuGamePath.Location = new System.Drawing.Point(534, 109);
            this.buttonEmuGamePath.MouseBack = null;
            this.buttonEmuGamePath.Name = "buttonEmuGamePath";
            this.buttonEmuGamePath.NormlBack = null;
            this.buttonEmuGamePath.Size = new System.Drawing.Size(111, 28);
            this.buttonEmuGamePath.TabIndex = 4;
            this.buttonEmuGamePath.Text = "选择位置";
            this.buttonEmuGamePath.UseVisualStyleBackColor = false;
            this.buttonEmuGamePath.Click += new System.EventHandler(this.ButtonEmuGamePath_Click);
            // 
            // buttonEmuFilePath
            // 
            this.buttonEmuFilePath.BackColor = System.Drawing.Color.Transparent;
            this.buttonEmuFilePath.BaseColor = System.Drawing.Color.LightBlue;
            this.buttonEmuFilePath.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.buttonEmuFilePath.DownBack = null;
            this.buttonEmuFilePath.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonEmuFilePath.Location = new System.Drawing.Point(534, 42);
            this.buttonEmuFilePath.MouseBack = null;
            this.buttonEmuFilePath.Name = "buttonEmuFilePath";
            this.buttonEmuFilePath.NormlBack = null;
            this.buttonEmuFilePath.Size = new System.Drawing.Size(111, 28);
            this.buttonEmuFilePath.TabIndex = 2;
            this.buttonEmuFilePath.Text = "选择位置";
            this.buttonEmuFilePath.UseVisualStyleBackColor = false;
            this.buttonEmuFilePath.Click += new System.EventHandler(this.ButtonEmuFilePath_Click);
            // 
            // textBoxExplain
            // 
            this.textBoxExplain.BackColor = System.Drawing.Color.Transparent;
            this.textBoxExplain.DownBack = null;
            this.textBoxExplain.Icon = null;
            this.textBoxExplain.IconIsButton = false;
            this.textBoxExplain.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBoxExplain.IsPasswordChat = '\0';
            this.textBoxExplain.IsSystemPasswordChar = false;
            this.textBoxExplain.Lines = new string[0];
            this.textBoxExplain.Location = new System.Drawing.Point(124, 141);
            this.textBoxExplain.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxExplain.MaxLength = 32767;
            this.textBoxExplain.MinimumSize = new System.Drawing.Size(28, 28);
            this.textBoxExplain.MouseBack = null;
            this.textBoxExplain.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBoxExplain.Multiline = false;
            this.textBoxExplain.Name = "textBoxExplain";
            this.textBoxExplain.NormlBack = null;
            this.textBoxExplain.Padding = new System.Windows.Forms.Padding(5);
            this.textBoxExplain.ReadOnly = false;
            this.textBoxExplain.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxExplain.Size = new System.Drawing.Size(407, 28);
            // 
            // 
            // 
            this.textBoxExplain.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExplain.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxExplain.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.textBoxExplain.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.textBoxExplain.SkinTxt.Name = "BaseText";
            this.textBoxExplain.SkinTxt.Size = new System.Drawing.Size(397, 18);
            this.textBoxExplain.SkinTxt.TabIndex = 0;
            this.textBoxExplain.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBoxExplain.SkinTxt.WaterText = "";
            this.textBoxExplain.TabIndex = 5;
            this.textBoxExplain.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxExplain.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBoxExplain.WaterText = "";
            this.textBoxExplain.WordWrap = true;
            // 
            // textBoxRomPath
            // 
            this.textBoxRomPath.BackColor = System.Drawing.Color.Transparent;
            this.textBoxRomPath.DownBack = null;
            this.textBoxRomPath.Icon = null;
            this.textBoxRomPath.IconIsButton = false;
            this.textBoxRomPath.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBoxRomPath.IsPasswordChat = '\0';
            this.textBoxRomPath.IsSystemPasswordChar = false;
            this.textBoxRomPath.Lines = new string[0];
            this.textBoxRomPath.Location = new System.Drawing.Point(124, 108);
            this.textBoxRomPath.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxRomPath.MaxLength = 32767;
            this.textBoxRomPath.MinimumSize = new System.Drawing.Size(28, 28);
            this.textBoxRomPath.MouseBack = null;
            this.textBoxRomPath.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBoxRomPath.Multiline = false;
            this.textBoxRomPath.Name = "textBoxRomPath";
            this.textBoxRomPath.NormlBack = null;
            this.textBoxRomPath.Padding = new System.Windows.Forms.Padding(5);
            this.textBoxRomPath.ReadOnly = false;
            this.textBoxRomPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxRomPath.Size = new System.Drawing.Size(407, 28);
            // 
            // 
            // 
            this.textBoxRomPath.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRomPath.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRomPath.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.textBoxRomPath.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.textBoxRomPath.SkinTxt.Name = "BaseText";
            this.textBoxRomPath.SkinTxt.Size = new System.Drawing.Size(397, 18);
            this.textBoxRomPath.SkinTxt.TabIndex = 0;
            this.textBoxRomPath.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBoxRomPath.SkinTxt.WaterText = "";
            this.textBoxRomPath.TabIndex = 53;
            this.textBoxRomPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxRomPath.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBoxRomPath.WaterText = "";
            this.textBoxRomPath.WordWrap = true;
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.BackColor = System.Drawing.Color.Transparent;
            this.textBoxFilePath.DownBack = null;
            this.textBoxFilePath.Icon = null;
            this.textBoxFilePath.IconIsButton = false;
            this.textBoxFilePath.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBoxFilePath.IsPasswordChat = '\0';
            this.textBoxFilePath.IsSystemPasswordChar = false;
            this.textBoxFilePath.Lines = new string[0];
            this.textBoxFilePath.Location = new System.Drawing.Point(124, 42);
            this.textBoxFilePath.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxFilePath.MaxLength = 32767;
            this.textBoxFilePath.MinimumSize = new System.Drawing.Size(28, 28);
            this.textBoxFilePath.MouseBack = null;
            this.textBoxFilePath.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBoxFilePath.Multiline = false;
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.NormlBack = null;
            this.textBoxFilePath.Padding = new System.Windows.Forms.Padding(5);
            this.textBoxFilePath.ReadOnly = false;
            this.textBoxFilePath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxFilePath.Size = new System.Drawing.Size(407, 28);
            // 
            // 
            // 
            this.textBoxFilePath.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFilePath.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxFilePath.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.textBoxFilePath.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.textBoxFilePath.SkinTxt.Name = "BaseText";
            this.textBoxFilePath.SkinTxt.Size = new System.Drawing.Size(397, 18);
            this.textBoxFilePath.SkinTxt.TabIndex = 0;
            this.textBoxFilePath.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBoxFilePath.SkinTxt.WaterText = "";
            this.textBoxFilePath.TabIndex = 2;
            this.textBoxFilePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxFilePath.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBoxFilePath.WaterText = "";
            this.textBoxFilePath.WordWrap = true;
            // 
            // textBoxEmuName
            // 
            this.textBoxEmuName.BackColor = System.Drawing.Color.Transparent;
            this.textBoxEmuName.DownBack = null;
            this.textBoxEmuName.Icon = null;
            this.textBoxEmuName.IconIsButton = false;
            this.textBoxEmuName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBoxEmuName.IsPasswordChat = '\0';
            this.textBoxEmuName.IsSystemPasswordChar = false;
            this.textBoxEmuName.Lines = new string[0];
            this.textBoxEmuName.Location = new System.Drawing.Point(124, 75);
            this.textBoxEmuName.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxEmuName.MaxLength = 32767;
            this.textBoxEmuName.MinimumSize = new System.Drawing.Size(28, 28);
            this.textBoxEmuName.MouseBack = null;
            this.textBoxEmuName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBoxEmuName.Multiline = false;
            this.textBoxEmuName.Name = "textBoxEmuName";
            this.textBoxEmuName.NormlBack = null;
            this.textBoxEmuName.Padding = new System.Windows.Forms.Padding(5);
            this.textBoxEmuName.ReadOnly = false;
            this.textBoxEmuName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxEmuName.Size = new System.Drawing.Size(407, 28);
            // 
            // 
            // 
            this.textBoxEmuName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmuName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxEmuName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.textBoxEmuName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.textBoxEmuName.SkinTxt.Name = "BaseText";
            this.textBoxEmuName.SkinTxt.Size = new System.Drawing.Size(397, 18);
            this.textBoxEmuName.SkinTxt.TabIndex = 0;
            this.textBoxEmuName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBoxEmuName.SkinTxt.WaterText = "";
            this.textBoxEmuName.TabIndex = 55;
            this.textBoxEmuName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxEmuName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBoxEmuName.WaterText = "";
            this.textBoxEmuName.WordWrap = true;
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.Transparent;
            this.textBoxName.DownBack = null;
            this.textBoxName.Icon = null;
            this.textBoxName.IconIsButton = false;
            this.textBoxName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBoxName.IsPasswordChat = '\0';
            this.textBoxName.IsSystemPasswordChar = false;
            this.textBoxName.Lines = new string[0];
            this.textBoxName.Location = new System.Drawing.Point(124, 9);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxName.MaxLength = 32767;
            this.textBoxName.MinimumSize = new System.Drawing.Size(28, 28);
            this.textBoxName.MouseBack = null;
            this.textBoxName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBoxName.Multiline = false;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.NormlBack = null;
            this.textBoxName.Padding = new System.Windows.Forms.Padding(5);
            this.textBoxName.ReadOnly = false;
            this.textBoxName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxName.Size = new System.Drawing.Size(407, 28);
            // 
            // 
            // 
            this.textBoxName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.textBoxName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.textBoxName.SkinTxt.Name = "BaseText";
            this.textBoxName.SkinTxt.Size = new System.Drawing.Size(397, 18);
            this.textBoxName.SkinTxt.TabIndex = 0;
            this.textBoxName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBoxName.SkinTxt.WaterText = "";
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBoxName.WaterText = "";
            this.textBoxName.WordWrap = true;
            // 
            // labelExplain
            // 
            this.labelExplain.AutoSize = true;
            this.labelExplain.BackColor = System.Drawing.Color.Transparent;
            this.labelExplain.BorderColor = System.Drawing.Color.White;
            this.labelExplain.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelExplain.Location = new System.Drawing.Point(45, 144);
            this.labelExplain.Name = "labelExplain";
            this.labelExplain.Size = new System.Drawing.Size(90, 21);
            this.labelExplain.TabIndex = 51;
            this.labelExplain.Text = "平台简介：";
            // 
            // labelRomPath
            // 
            this.labelRomPath.AutoSize = true;
            this.labelRomPath.BackColor = System.Drawing.Color.Transparent;
            this.labelRomPath.BorderColor = System.Drawing.Color.White;
            this.labelRomPath.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRomPath.Location = new System.Drawing.Point(6, 111);
            this.labelRomPath.Name = "labelRomPath";
            this.labelRomPath.Size = new System.Drawing.Size(129, 21);
            this.labelRomPath.TabIndex = 50;
            this.labelRomPath.Text = "游戏ROM路径：";
            // 
            // labelEmuName
            // 
            this.labelEmuName.AutoSize = true;
            this.labelEmuName.BackColor = System.Drawing.Color.Transparent;
            this.labelEmuName.BorderColor = System.Drawing.Color.White;
            this.labelEmuName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelEmuName.Location = new System.Drawing.Point(13, 78);
            this.labelEmuName.Name = "labelEmuName";
            this.labelEmuName.Size = new System.Drawing.Size(122, 21);
            this.labelEmuName.TabIndex = 49;
            this.labelEmuName.Text = "启动程序名称：";
            // 
            // labelFilePath
            // 
            this.labelFilePath.AutoSize = true;
            this.labelFilePath.BackColor = System.Drawing.Color.Transparent;
            this.labelFilePath.BorderColor = System.Drawing.Color.White;
            this.labelFilePath.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelFilePath.Location = new System.Drawing.Point(13, 45);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(122, 21);
            this.labelFilePath.TabIndex = 48;
            this.labelFilePath.Text = "启动程序路径：";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.BorderColor = System.Drawing.Color.White;
            this.labelName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelName.Location = new System.Drawing.Point(13, 12);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(122, 21);
            this.labelName.TabIndex = 47;
            this.labelName.Text = "模拟平台名称：";
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSave.BackColor = System.Drawing.Color.Transparent;
            this.buttonSave.BaseColor = System.Drawing.Color.CornflowerBlue;
            this.buttonSave.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.buttonSave.DownBack = null;
            this.buttonSave.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSave.Location = new System.Drawing.Point(543, 472);
            this.buttonSave.MouseBack = null;
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.NormlBack = null;
            this.buttonSave.Size = new System.Drawing.Size(111, 28);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "保 存";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonClear.BackColor = System.Drawing.Color.Transparent;
            this.buttonClear.BaseColor = System.Drawing.Color.Salmon;
            this.buttonClear.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.buttonClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClear.DownBack = null;
            this.buttonClear.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonClear.Location = new System.Drawing.Point(426, 472);
            this.buttonClear.MouseBack = null;
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.NormlBack = null;
            this.buttonClear.Size = new System.Drawing.Size(111, 28);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "重 置";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // openFileDialogImg
            // 
            this.openFileDialogImg.DefaultExt = "jpg";
            this.openFileDialogImg.Filter = "图片文件|*.jpg;*.png;";
            this.openFileDialogImg.Title = "请选择图片文件";
            // 
            // FormEdit
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.CancelButton = this.buttonClear;
            this.ClientSize = new System.Drawing.Size(680, 507);
            this.CloseBoxSize = new System.Drawing.Size(40, 20);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.skinTabControlType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaxSize = new System.Drawing.Size(40, 20);
            this.MiniSize = new System.Drawing.Size(40, 20);
            this.Name = "FormEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑数据";
            this.Load += new System.EventHandler(this.FormEditPC_Load);
            this.skinTabControlType.ResumeLayout(false);
            this.skinTabPagePC.ResumeLayout(false);
            this.skinTabPagePC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBoxPCImg)).EndInit();
            this.skinTabPageEmu.ResumeLayout(false);
            this.skinTabPageEmu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBoxEmuImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogPath;
        private System.Windows.Forms.OpenFileDialog openFileDialogStartName;
        private CCWin.SkinControl.SkinTabControl skinTabControlType;
        private CCWin.SkinControl.SkinTabPage skinTabPagePC;
        private CCWin.SkinControl.SkinTabPage skinTabPageEmu;
        private CCWin.SkinControl.SkinLabel labelPCGameName;
        private CCWin.SkinControl.SkinLabel labelPCStartName;
        private CCWin.SkinControl.SkinLabel labelPCSavePath;
        private CCWin.SkinControl.SkinLabel labelPCGamePath;
        private CCWin.SkinControl.SkinLabel labelPCGameType;
        private CCWin.SkinControl.SkinTextBox textBoxStartName;
        private CCWin.SkinControl.SkinTextBox textBoxSavePath;
        private CCWin.SkinControl.SkinTextBox textBoxGameType;
        private CCWin.SkinControl.SkinTextBox textBoxGamePath;
        private CCWin.SkinControl.SkinTextBox textBoxGameName;
        private CCWin.SkinControl.SkinButton buttonGamePath;
        private CCWin.SkinControl.SkinButton buttonSavePath;
        private CCWin.SkinControl.SkinButton buttonStartName;
        private CCWin.SkinControl.SkinButton buttonSave;
        private CCWin.SkinControl.SkinButton buttonClear;
        private CCWin.SkinControl.SkinButton buttonEmuName;
        private CCWin.SkinControl.SkinButton buttonEmuGamePath;
        private CCWin.SkinControl.SkinButton buttonEmuFilePath;
        private CCWin.SkinControl.SkinTextBox textBoxExplain;
        private CCWin.SkinControl.SkinTextBox textBoxRomPath;
        private CCWin.SkinControl.SkinTextBox textBoxFilePath;
        private CCWin.SkinControl.SkinTextBox textBoxEmuName;
        private CCWin.SkinControl.SkinTextBox textBoxName;
        private CCWin.SkinControl.SkinLabel labelExplain;
        private CCWin.SkinControl.SkinLabel labelEmuName;
        private CCWin.SkinControl.SkinLabel labelFilePath;
        private CCWin.SkinControl.SkinLabel labelName;
        private CCWin.SkinControl.SkinLabel labelRomPath;
        private CCWin.SkinControl.SkinLabel skinLabelPCTip;
        private CCWin.SkinControl.SkinTextBox skinTextBoxPCTip;
        private CCWin.SkinControl.SkinPictureBox skinPictureBoxPCImg;
        private CCWin.SkinControl.SkinLabel skinLabelPCImg;
        private CCWin.SkinControl.SkinPictureBox skinPictureBoxEmuImg;
        private CCWin.SkinControl.SkinLabel skinLabelEmuImg;
        private CCWin.SkinControl.SkinLabel skinLabelEmuTip;
        private CCWin.SkinControl.SkinTextBox skinTextBoxEmuTip;
        private CCWin.SkinControl.SkinButton skinButtonUpdatePCImg;
        private CCWin.SkinControl.SkinButton skinButtonUpdateEmuImg;
        private System.Windows.Forms.OpenFileDialog openFileDialogImg;
        private System.Windows.Forms.ToolTip toolTipThis;
    }
}