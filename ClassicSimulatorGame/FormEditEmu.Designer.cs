namespace LocalGameLaunchCenter
{
    partial class FormEditEmu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditEmu));
            this.openFileDialogStartName = new System.Windows.Forms.OpenFileDialog();
            this.textBoxEmuName = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelEmuName = new System.Windows.Forms.Label();
            this.textBoxGamePath = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelGamePath = new System.Windows.Forms.Label();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.buttonEmuName = new System.Windows.Forms.Button();
            this.labelFilePath = new System.Windows.Forms.Label();
            this.buttonGamePath = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonFilePath = new System.Windows.Forms.Button();
            this.folderBrowserDialogPath = new System.Windows.Forms.FolderBrowserDialog();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxExplain = new System.Windows.Forms.TextBox();
            this.labelExplain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialogStartName
            // 
            this.openFileDialogStartName.Title = "请选择执行应用启动程序";
            // 
            // textBoxEmuName
            // 
            this.textBoxEmuName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxEmuName.Location = new System.Drawing.Point(140, 123);
            this.textBoxEmuName.Name = "textBoxEmuName";
            this.textBoxEmuName.Size = new System.Drawing.Size(397, 26);
            this.textBoxEmuName.TabIndex = 29;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSave.Location = new System.Drawing.Point(568, 275);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 30);
            this.buttonSave.TabIndex = 28;
            this.buttonSave.Text = "保 存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // labelEmuName
            // 
            this.labelEmuName.AutoSize = true;
            this.labelEmuName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelEmuName.Location = new System.Drawing.Point(31, 128);
            this.labelEmuName.Name = "labelEmuName";
            this.labelEmuName.Size = new System.Drawing.Size(120, 16);
            this.labelEmuName.TabIndex = 27;
            this.labelEmuName.Text = "启动程序名称：";
            // 
            // textBoxGamePath
            // 
            this.textBoxGamePath.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxGamePath.Location = new System.Drawing.Point(140, 155);
            this.textBoxGamePath.Name = "textBoxGamePath";
            this.textBoxGamePath.Size = new System.Drawing.Size(397, 26);
            this.textBoxGamePath.TabIndex = 26;
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonClear.Location = new System.Drawing.Point(462, 275);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(100, 30);
            this.buttonClear.TabIndex = 25;
            this.buttonClear.Text = "重 置";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // labelGamePath
            // 
            this.labelGamePath.AutoSize = true;
            this.labelGamePath.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelGamePath.Location = new System.Drawing.Point(39, 160);
            this.labelGamePath.Name = "labelGamePath";
            this.labelGamePath.Size = new System.Drawing.Size(112, 16);
            this.labelGamePath.TabIndex = 24;
            this.labelGamePath.Text = "游戏ROM路径：";
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxFilePath.Location = new System.Drawing.Point(140, 91);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(397, 26);
            this.textBoxFilePath.TabIndex = 23;
            // 
            // buttonEmuName
            // 
            this.buttonEmuName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonEmuName.Location = new System.Drawing.Point(543, 123);
            this.buttonEmuName.Name = "buttonEmuName";
            this.buttonEmuName.Size = new System.Drawing.Size(111, 26);
            this.buttonEmuName.TabIndex = 22;
            this.buttonEmuName.Text = "选择文件";
            this.buttonEmuName.UseVisualStyleBackColor = true;
            this.buttonEmuName.Click += new System.EventHandler(this.ButtonEmuName_Click);
            // 
            // labelFilePath
            // 
            this.labelFilePath.AutoSize = true;
            this.labelFilePath.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelFilePath.Location = new System.Drawing.Point(31, 96);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(120, 16);
            this.labelFilePath.TabIndex = 21;
            this.labelFilePath.Text = "启动程序路径：";
            // 
            // buttonGamePath
            // 
            this.buttonGamePath.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonGamePath.Location = new System.Drawing.Point(543, 155);
            this.buttonGamePath.Name = "buttonGamePath";
            this.buttonGamePath.Size = new System.Drawing.Size(111, 26);
            this.buttonGamePath.TabIndex = 19;
            this.buttonGamePath.Text = "选择位置";
            this.buttonGamePath.UseVisualStyleBackColor = true;
            this.buttonGamePath.Click += new System.EventHandler(this.ButtonGamePath_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxName.Location = new System.Drawing.Point(140, 59);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(397, 26);
            this.textBoxName.TabIndex = 17;
            // 
            // buttonFilePath
            // 
            this.buttonFilePath.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonFilePath.Location = new System.Drawing.Point(543, 91);
            this.buttonFilePath.Name = "buttonFilePath";
            this.buttonFilePath.Size = new System.Drawing.Size(111, 26);
            this.buttonFilePath.TabIndex = 16;
            this.buttonFilePath.Text = "选择位置";
            this.buttonFilePath.UseVisualStyleBackColor = true;
            this.buttonFilePath.Click += new System.EventHandler(this.ButtonFilePath_Click);
            // 
            // folderBrowserDialogPath
            // 
            this.folderBrowserDialogPath.Description = "请选择文件路径";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelName.Location = new System.Drawing.Point(31, 62);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(120, 16);
            this.labelName.TabIndex = 15;
            this.labelName.Text = "模拟平台名称：";
            // 
            // textBoxExplain
            // 
            this.textBoxExplain.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxExplain.Location = new System.Drawing.Point(140, 187);
            this.textBoxExplain.Name = "textBoxExplain";
            this.textBoxExplain.Size = new System.Drawing.Size(397, 26);
            this.textBoxExplain.TabIndex = 31;
            // 
            // labelExplain
            // 
            this.labelExplain.AutoSize = true;
            this.labelExplain.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelExplain.Location = new System.Drawing.Point(63, 192);
            this.labelExplain.Name = "labelExplain";
            this.labelExplain.Size = new System.Drawing.Size(88, 16);
            this.labelExplain.TabIndex = 30;
            this.labelExplain.Text = "平台简介：";
            // 
            // FormEditEmu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(680, 317);
            this.Controls.Add(this.textBoxExplain);
            this.Controls.Add(this.labelExplain);
            this.Controls.Add(this.textBoxEmuName);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelEmuName);
            this.Controls.Add(this.textBoxGamePath);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelGamePath);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.buttonEmuName);
            this.Controls.Add(this.labelFilePath);
            this.Controls.Add(this.buttonGamePath);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonFilePath);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormEditEmu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑数据 ---- Emu";
            this.Load += new System.EventHandler(this.FormEditEmu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialogStartName;
        private System.Windows.Forms.TextBox textBoxEmuName;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelEmuName;
        private System.Windows.Forms.TextBox textBoxGamePath;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelGamePath;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Button buttonEmuName;
        private System.Windows.Forms.Label labelFilePath;
        private System.Windows.Forms.Button buttonGamePath;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonFilePath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogPath;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxExplain;
        private System.Windows.Forms.Label labelExplain;
    }
}