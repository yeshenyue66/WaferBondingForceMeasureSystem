namespace WaferBondingForceMeasureSystem.UserControls
{
    partial class ControlPanel
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
            this.PanelProcedure = new System.Windows.Forms.Panel();
            this.PanelSetting = new System.Windows.Forms.Panel();
            this.CheckBoxAutoPhoto = new System.Windows.Forms.CheckBox();
            this.LabelSerial = new System.Windows.Forms.Label();
            this.LabelPlan = new System.Windows.Forms.Label();
            this.LabelNum = new System.Windows.Forms.Label();
            this.LabelHandle = new System.Windows.Forms.Label();
            this.PanelTopic.SuspendLayout();
            this.PanelMain.SuspendLayout();
            this.PanelSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTopic
            // 
            this.PanelTopic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(192)))), ((int)(((byte)(207)))));
            this.PanelTopic.Controls.Add(this.LabelTopic);
            this.PanelTopic.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTopic.Location = new System.Drawing.Point(0, 0);
            this.PanelTopic.Name = "PanelTopic";
            this.PanelTopic.Size = new System.Drawing.Size(310, 29);
            this.PanelTopic.TabIndex = 2;
            // 
            // LabelTopic
            // 
            this.LabelTopic.AutoEllipsis = true;
            this.LabelTopic.AutoSize = true;
            this.LabelTopic.Location = new System.Drawing.Point(11, 10);
            this.LabelTopic.Name = "LabelTopic";
            this.LabelTopic.Size = new System.Drawing.Size(53, 12);
            this.LabelTopic.TabIndex = 0;
            this.LabelTopic.Text = "控制面板";
            // 
            // PanelMain
            // 
            this.PanelMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelMain.Controls.Add(this.PanelProcedure);
            this.PanelMain.Controls.Add(this.PanelSetting);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(0, 29);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(310, 545);
            this.PanelMain.TabIndex = 3;
            // 
            // PanelProcedure
            // 
            this.PanelProcedure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelProcedure.Location = new System.Drawing.Point(0, 154);
            this.PanelProcedure.Name = "PanelProcedure";
            this.PanelProcedure.Size = new System.Drawing.Size(306, 387);
            this.PanelProcedure.TabIndex = 1;
            // 
            // PanelSetting
            // 
            this.PanelSetting.Controls.Add(this.CheckBoxAutoPhoto);
            this.PanelSetting.Controls.Add(this.LabelSerial);
            this.PanelSetting.Controls.Add(this.LabelPlan);
            this.PanelSetting.Controls.Add(this.LabelNum);
            this.PanelSetting.Controls.Add(this.LabelHandle);
            this.PanelSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSetting.Location = new System.Drawing.Point(0, 0);
            this.PanelSetting.Name = "PanelSetting";
            this.PanelSetting.Size = new System.Drawing.Size(306, 154);
            this.PanelSetting.TabIndex = 0;
            this.PanelSetting.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelSetting_Paint);
            // 
            // CheckBoxAutoPhoto
            // 
            this.CheckBoxAutoPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBoxAutoPhoto.AutoSize = true;
            this.CheckBoxAutoPhoto.Font = new System.Drawing.Font("宋体", 15F);
            this.CheckBoxAutoPhoto.Location = new System.Drawing.Point(27, 119);
            this.CheckBoxAutoPhoto.Name = "CheckBoxAutoPhoto";
            this.CheckBoxAutoPhoto.Size = new System.Drawing.Size(148, 24);
            this.CheckBoxAutoPhoto.TabIndex = 5;
            this.CheckBoxAutoPhoto.Text = "自动插刀拍照";
            this.CheckBoxAutoPhoto.UseVisualStyleBackColor = true;
            // 
            // LabelSerial
            // 
            this.LabelSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSerial.AutoEllipsis = true;
            this.LabelSerial.AutoSize = true;
            this.LabelSerial.Font = new System.Drawing.Font("宋体", 15F);
            this.LabelSerial.Location = new System.Drawing.Point(171, 120);
            this.LabelSerial.Name = "LabelSerial";
            this.LabelSerial.Size = new System.Drawing.Size(109, 20);
            this.LabelSerial.TabIndex = 4;
            this.LabelSerial.Text = "晶圆序号：";
            // 
            // LabelPlan
            // 
            this.LabelPlan.AutoSize = true;
            this.LabelPlan.Font = new System.Drawing.Font("宋体", 15F);
            this.LabelPlan.Location = new System.Drawing.Point(25, 74);
            this.LabelPlan.Name = "LabelPlan";
            this.LabelPlan.Size = new System.Drawing.Size(109, 20);
            this.LabelPlan.TabIndex = 2;
            this.LabelPlan.Text = "插刀编号：";
            // 
            // LabelNum
            // 
            this.LabelNum.Font = new System.Drawing.Font("宋体", 15F);
            this.LabelNum.Location = new System.Drawing.Point(25, 43);
            this.LabelNum.Name = "LabelNum";
            this.LabelNum.Size = new System.Drawing.Size(109, 20);
            this.LabelNum.TabIndex = 1;
            this.LabelNum.Text = "物料编号：";
            // 
            // LabelHandle
            // 
            this.LabelHandle.AutoSize = true;
            this.LabelHandle.Font = new System.Drawing.Font("宋体", 15F);
            this.LabelHandle.Location = new System.Drawing.Point(23, 14);
            this.LabelHandle.Name = "LabelHandle";
            this.LabelHandle.Size = new System.Drawing.Size(109, 20);
            this.LabelHandle.TabIndex = 0;
            this.LabelHandle.Text = "当前操作：";
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.PanelTopic);
            this.Name = "ControlPanel";
            this.Size = new System.Drawing.Size(310, 574);
            this.Resize += new System.EventHandler(this.ControlPanel_Resize);
            this.PanelTopic.ResumeLayout(false);
            this.PanelTopic.PerformLayout();
            this.PanelMain.ResumeLayout(false);
            this.PanelSetting.ResumeLayout(false);
            this.PanelSetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTopic;
        private System.Windows.Forms.Label LabelTopic;
        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Panel PanelProcedure;
        private System.Windows.Forms.Panel PanelSetting;
        private System.Windows.Forms.CheckBox CheckBoxAutoPhoto;
        private System.Windows.Forms.Label LabelSerial;
        private System.Windows.Forms.Label LabelPlan;
        private System.Windows.Forms.Label LabelNum;
        private System.Windows.Forms.Label LabelHandle;
    }
}
