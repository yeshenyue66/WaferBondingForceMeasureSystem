namespace WaferBondingForceMeasureSystem.UserControls
{
    partial class AnalysisPic
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
            this.LabelTopic = new System.Windows.Forms.Label();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.PanelTopic.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTopic
            // 
            this.PanelTopic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(192)))), ((int)(((byte)(207)))));
            this.PanelTopic.Controls.Add(this.LabelTopic);
            this.PanelTopic.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTopic.Location = new System.Drawing.Point(0, 0);
            this.PanelTopic.Name = "PanelTopic";
            this.PanelTopic.Size = new System.Drawing.Size(426, 29);
            this.PanelTopic.TabIndex = 1;
            // 
            // LabelTopic
            // 
            this.LabelTopic.AutoSize = true;
            this.LabelTopic.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelTopic.Location = new System.Drawing.Point(11, 10);
            this.LabelTopic.Name = "LabelTopic";
            this.LabelTopic.Size = new System.Drawing.Size(41, 12);
            this.LabelTopic.TabIndex = 0;
            this.LabelTopic.Text = "分析图";
            // 
            // PanelMain
            // 
            this.PanelMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(0, 29);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(426, 529);
            this.PanelMain.TabIndex = 2;
            // 
            // AnalysisPic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.PanelTopic);
            this.Name = "AnalysisPic";
            this.Size = new System.Drawing.Size(426, 558);
            this.PanelTopic.ResumeLayout(false);
            this.PanelTopic.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTopic;
        private System.Windows.Forms.Label LabelTopic;
        private System.Windows.Forms.Panel PanelMain;
    }
}
