namespace WaferBondingForceMeasureSystem.UserControls
{
    partial class ErrorLog
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelTopic = new System.Windows.Forms.Panel();
            this.LabelErrorLog = new System.Windows.Forms.Label();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.TextBoxErrorLog = new System.Windows.Forms.TextBox();
            this.BtnCorrection = new System.Windows.Forms.Button();
            this.PanelTopic.SuspendLayout();
            this.PanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTopic
            // 
            this.PanelTopic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(192)))), ((int)(((byte)(207)))));
            this.PanelTopic.Controls.Add(this.LabelErrorLog);
            this.PanelTopic.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTopic.Location = new System.Drawing.Point(0, 0);
            this.PanelTopic.Name = "PanelTopic";
            this.PanelTopic.Size = new System.Drawing.Size(335, 29);
            this.PanelTopic.TabIndex = 0;
            // 
            // LabelErrorLog
            // 
            this.LabelErrorLog.AutoSize = true;
            this.LabelErrorLog.Location = new System.Drawing.Point(11, 10);
            this.LabelErrorLog.Name = "LabelErrorLog";
            this.LabelErrorLog.Size = new System.Drawing.Size(53, 12);
            this.LabelErrorLog.TabIndex = 0;
            this.LabelErrorLog.Text = "错误日志";
            // 
            // PanelMain
            // 
            this.PanelMain.Controls.Add(this.TextBoxErrorLog);
            this.PanelMain.Controls.Add(this.BtnCorrection);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(0, 29);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(335, 489);
            this.PanelMain.TabIndex = 1;
            // 
            // TextBoxErrorLog
            // 
            this.TextBoxErrorLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxErrorLog.Location = new System.Drawing.Point(0, 0);
            this.TextBoxErrorLog.Multiline = true;
            this.TextBoxErrorLog.Name = "TextBoxErrorLog";
            this.TextBoxErrorLog.ReadOnly = true;
            this.TextBoxErrorLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxErrorLog.Size = new System.Drawing.Size(335, 447);
            this.TextBoxErrorLog.TabIndex = 1;
            this.TextBoxErrorLog.Resize += new System.EventHandler(this.TextBoxErrorLog_Resize);
            // 
            // BtnCorrection
            // 
            this.BtnCorrection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(62)))), ((int)(((byte)(77)))));
            this.BtnCorrection.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnCorrection.ForeColor = System.Drawing.Color.White;
            this.BtnCorrection.Location = new System.Drawing.Point(0, 447);
            this.BtnCorrection.Name = "BtnCorrection";
            this.BtnCorrection.Size = new System.Drawing.Size(335, 42);
            this.BtnCorrection.TabIndex = 0;
            this.BtnCorrection.Text = "清错";
            this.BtnCorrection.UseVisualStyleBackColor = false;
            // 
            // ErrorLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.PanelTopic);
            this.Name = "ErrorLog";
            this.Size = new System.Drawing.Size(335, 518);
            this.Load += new System.EventHandler(this.ErrorLog_Load);
            this.PanelTopic.ResumeLayout(false);
            this.PanelTopic.PerformLayout();
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTopic;
        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Label LabelErrorLog;
        private System.Windows.Forms.TextBox TextBoxErrorLog;
        private System.Windows.Forms.Button BtnCorrection;
    }
}
