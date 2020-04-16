namespace LocalGameLaunchCenter
{
    partial class FormLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLog));
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStripTip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelRC = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelRowsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripMenu.SuspendLayout();
            this.statusStripTip.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.BackColor = System.Drawing.Color.White;
            this.richTextBoxLog.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBoxLog.Location = new System.Drawing.Point(0, 28);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.ReadOnly = true;
            this.richTextBoxLog.Size = new System.Drawing.Size(780, 504);
            this.richTextBoxLog.TabIndex = 0;
            this.richTextBoxLog.Text = "";
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonRefresh,
            this.toolStripSeparator1,
            this.toolStripButtonClear,
            this.toolStripSeparator2});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(780, 25);
            this.toolStripMenu.TabIndex = 1;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.Image = global::LocalGameLaunchCenter.ResourceApp.刷新;
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(52, 22);
            this.toolStripButtonRefresh.Text = "刷新";
            this.toolStripButtonRefresh.Click += new System.EventHandler(this.ToolStripButtonRefresh_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonClear
            // 
            this.toolStripButtonClear.Image = global::LocalGameLaunchCenter.ResourceApp.清空;
            this.toolStripButtonClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClear.Name = "toolStripButtonClear";
            this.toolStripButtonClear.Size = new System.Drawing.Size(76, 22);
            this.toolStripButtonClear.Text = "清空日志";
            this.toolStripButtonClear.Click += new System.EventHandler(this.ToolStripButtonClear_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // statusStripTip
            // 
            this.statusStripTip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelRC,
            this.toolStripStatusLabelRowsCount});
            this.statusStripTip.Location = new System.Drawing.Point(0, 535);
            this.statusStripTip.Name = "statusStripTip";
            this.statusStripTip.Size = new System.Drawing.Size(780, 22);
            this.statusStripTip.TabIndex = 2;
            this.statusStripTip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelRC
            // 
            this.toolStripStatusLabelRC.Name = "toolStripStatusLabelRC";
            this.toolStripStatusLabelRC.Size = new System.Drawing.Size(71, 17);
            this.toolStripStatusLabelRC.Text = "文本总行数:";
            // 
            // toolStripStatusLabelRowsCount
            // 
            this.toolStripStatusLabelRowsCount.Name = "toolStripStatusLabelRowsCount";
            this.toolStripStatusLabelRowsCount.Size = new System.Drawing.Size(15, 17);
            this.toolStripStatusLabelRowsCount.Text = "0";
            // 
            // FormLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 557);
            this.Controls.Add(this.statusStripTip);
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.richTextBoxLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "历史日志信息";
            this.Load += new System.EventHandler(this.FormLog_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.statusStripTip.ResumeLayout(false);
            this.statusStripTip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonClear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.StatusStrip statusStripTip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelRC;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelRowsCount;
    }
}