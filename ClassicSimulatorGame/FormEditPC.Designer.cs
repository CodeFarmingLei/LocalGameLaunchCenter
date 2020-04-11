namespace LocalGameLaunchCenter
{
    partial class FormEditPC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditPC));
            this.labelGameName = new System.Windows.Forms.Label();
            this.buttonGamePath = new System.Windows.Forms.Button();
            this.textBoxGameName = new System.Windows.Forms.TextBox();
            this.textBoxGameType = new System.Windows.Forms.TextBox();
            this.buttonSavePath = new System.Windows.Forms.Button();
            this.labelGameType = new System.Windows.Forms.Label();
            this.textBoxGamePath = new System.Windows.Forms.TextBox();
            this.buttonStartName = new System.Windows.Forms.Button();
            this.labelGamePath = new System.Windows.Forms.Label();
            this.textBoxSavePath = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelSavePath = new System.Windows.Forms.Label();
            this.textBoxStartName = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelStartName = new System.Windows.Forms.Label();
            this.folderBrowserDialogPath = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialogStartName = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // labelGameName
            // 
            this.labelGameName.AutoSize = true;
            this.labelGameName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelGameName.Location = new System.Drawing.Point(63, 64);
            this.labelGameName.Name = "labelGameName";
            this.labelGameName.Size = new System.Drawing.Size(88, 16);
            this.labelGameName.TabIndex = 0;
            this.labelGameName.Text = "游戏名称：";
            // 
            // buttonGamePath
            // 
            this.buttonGamePath.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonGamePath.Location = new System.Drawing.Point(543, 123);
            this.buttonGamePath.Name = "buttonGamePath";
            this.buttonGamePath.Size = new System.Drawing.Size(111, 26);
            this.buttonGamePath.TabIndex = 1;
            this.buttonGamePath.Text = "选择位置";
            this.buttonGamePath.UseVisualStyleBackColor = true;
            this.buttonGamePath.Click += new System.EventHandler(this.ButtonGamePath_Click);
            // 
            // textBoxGameName
            // 
            this.textBoxGameName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxGameName.Location = new System.Drawing.Point(140, 59);
            this.textBoxGameName.Name = "textBoxGameName";
            this.textBoxGameName.Size = new System.Drawing.Size(397, 26);
            this.textBoxGameName.TabIndex = 2;
            // 
            // textBoxGameType
            // 
            this.textBoxGameType.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxGameType.Location = new System.Drawing.Point(140, 91);
            this.textBoxGameType.Name = "textBoxGameType";
            this.textBoxGameType.Size = new System.Drawing.Size(397, 26);
            this.textBoxGameType.TabIndex = 5;
            // 
            // buttonSavePath
            // 
            this.buttonSavePath.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSavePath.Location = new System.Drawing.Point(543, 155);
            this.buttonSavePath.Name = "buttonSavePath";
            this.buttonSavePath.Size = new System.Drawing.Size(111, 26);
            this.buttonSavePath.TabIndex = 4;
            this.buttonSavePath.Text = "选择位置";
            this.buttonSavePath.UseVisualStyleBackColor = true;
            this.buttonSavePath.Click += new System.EventHandler(this.ButtonSavePath_Click);
            // 
            // labelGameType
            // 
            this.labelGameType.AutoSize = true;
            this.labelGameType.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelGameType.Location = new System.Drawing.Point(63, 96);
            this.labelGameType.Name = "labelGameType";
            this.labelGameType.Size = new System.Drawing.Size(88, 16);
            this.labelGameType.TabIndex = 3;
            this.labelGameType.Text = "游戏类型：";
            // 
            // textBoxGamePath
            // 
            this.textBoxGamePath.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxGamePath.Location = new System.Drawing.Point(140, 123);
            this.textBoxGamePath.Name = "textBoxGamePath";
            this.textBoxGamePath.Size = new System.Drawing.Size(397, 26);
            this.textBoxGamePath.TabIndex = 8;
            // 
            // buttonStartName
            // 
            this.buttonStartName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonStartName.Location = new System.Drawing.Point(543, 187);
            this.buttonStartName.Name = "buttonStartName";
            this.buttonStartName.Size = new System.Drawing.Size(111, 26);
            this.buttonStartName.TabIndex = 7;
            this.buttonStartName.Text = "选择文件";
            this.buttonStartName.UseVisualStyleBackColor = true;
            this.buttonStartName.Click += new System.EventHandler(this.ButtonStartName_Click);
            // 
            // labelGamePath
            // 
            this.labelGamePath.AutoSize = true;
            this.labelGamePath.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelGamePath.Location = new System.Drawing.Point(31, 128);
            this.labelGamePath.Name = "labelGamePath";
            this.labelGamePath.Size = new System.Drawing.Size(120, 16);
            this.labelGamePath.TabIndex = 6;
            this.labelGamePath.Text = "启动程序路径：";
            // 
            // textBoxSavePath
            // 
            this.textBoxSavePath.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxSavePath.Location = new System.Drawing.Point(140, 155);
            this.textBoxSavePath.Name = "textBoxSavePath";
            this.textBoxSavePath.Size = new System.Drawing.Size(397, 26);
            this.textBoxSavePath.TabIndex = 11;
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonClear.Location = new System.Drawing.Point(462, 275);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(100, 30);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "重 置";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // labelSavePath
            // 
            this.labelSavePath.AutoSize = true;
            this.labelSavePath.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSavePath.Location = new System.Drawing.Point(31, 160);
            this.labelSavePath.Name = "labelSavePath";
            this.labelSavePath.Size = new System.Drawing.Size(120, 16);
            this.labelSavePath.TabIndex = 9;
            this.labelSavePath.Text = "游戏存档路径：";
            // 
            // textBoxStartName
            // 
            this.textBoxStartName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxStartName.Location = new System.Drawing.Point(140, 187);
            this.textBoxStartName.Name = "textBoxStartName";
            this.textBoxStartName.Size = new System.Drawing.Size(397, 26);
            this.textBoxStartName.TabIndex = 14;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSave.Location = new System.Drawing.Point(568, 275);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 30);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "保 存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // labelStartName
            // 
            this.labelStartName.AutoSize = true;
            this.labelStartName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelStartName.Location = new System.Drawing.Point(31, 192);
            this.labelStartName.Name = "labelStartName";
            this.labelStartName.Size = new System.Drawing.Size(120, 16);
            this.labelStartName.TabIndex = 12;
            this.labelStartName.Text = "启动程序名称：";
            // 
            // folderBrowserDialogPath
            // 
            this.folderBrowserDialogPath.Description = "请选择文件路径";
            // 
            // openFileDialogStartName
            // 
            this.openFileDialogStartName.Title = "请选择执行游戏启动程序";
            // 
            // FormEditPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(680, 317);
            this.Controls.Add(this.textBoxStartName);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelStartName);
            this.Controls.Add(this.textBoxSavePath);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelSavePath);
            this.Controls.Add(this.textBoxGamePath);
            this.Controls.Add(this.buttonStartName);
            this.Controls.Add(this.labelGamePath);
            this.Controls.Add(this.textBoxGameType);
            this.Controls.Add(this.buttonSavePath);
            this.Controls.Add(this.labelGameType);
            this.Controls.Add(this.textBoxGameName);
            this.Controls.Add(this.buttonGamePath);
            this.Controls.Add(this.labelGameName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormEditPC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑数据 ---- PC";
            this.Load += new System.EventHandler(this.FormEditPC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGameName;
        private System.Windows.Forms.Button buttonGamePath;
        private System.Windows.Forms.TextBox textBoxGameName;
        private System.Windows.Forms.TextBox textBoxGameType;
        private System.Windows.Forms.Button buttonSavePath;
        private System.Windows.Forms.Label labelGameType;
        private System.Windows.Forms.TextBox textBoxGamePath;
        private System.Windows.Forms.Button buttonStartName;
        private System.Windows.Forms.Label labelGamePath;
        private System.Windows.Forms.TextBox textBoxSavePath;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelSavePath;
        private System.Windows.Forms.TextBox textBoxStartName;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelStartName;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogPath;
        private System.Windows.Forms.OpenFileDialog openFileDialogStartName;
    }
}