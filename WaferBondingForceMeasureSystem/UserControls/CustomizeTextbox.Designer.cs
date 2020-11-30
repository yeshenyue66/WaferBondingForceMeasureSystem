namespace WaferBondingForceMeasureSystem.UserControls
{
    partial class CustomizeTextbox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomizeTextbox));
            this.PanelMain = new System.Windows.Forms.Panel();
            this.TBox = new System.Windows.Forms.TextBox();
            this.PicBoxUp = new System.Windows.Forms.PictureBox();
            this.PicBoxDown = new System.Windows.Forms.PictureBox();
            this.PanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxDown)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMain
            // 
            this.PanelMain.Controls.Add(this.PicBoxDown);
            this.PanelMain.Controls.Add(this.PicBoxUp);
            this.PanelMain.Controls.Add(this.TBox);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(0, 0);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(167, 33);
            this.PanelMain.TabIndex = 0;
            // 
            // TBox
            // 
            this.TBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.TBox.Font = new System.Drawing.Font("宋体", 17F);
            this.TBox.Location = new System.Drawing.Point(0, 0);
            this.TBox.Multiline = true;
            this.TBox.Name = "TBox";
            this.TBox.Size = new System.Drawing.Size(144, 33);
            this.TBox.TabIndex = 0;
            this.TBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBox_KeyPress);
            // 
            // PicBoxUp
            // 
            this.PicBoxUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.PicBoxUp.Image = ((System.Drawing.Image)(resources.GetObject("PicBoxUp.Image")));
            this.PicBoxUp.Location = new System.Drawing.Point(144, 0);
            this.PicBoxUp.Name = "PicBoxUp";
            this.PicBoxUp.Size = new System.Drawing.Size(23, 16);
            this.PicBoxUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxUp.TabIndex = 1;
            this.PicBoxUp.TabStop = false;
            this.PicBoxUp.Click += new System.EventHandler(this.PicBoxUp_Click);
            // 
            // PicBoxDown
            // 
            this.PicBoxDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicBoxDown.Image = ((System.Drawing.Image)(resources.GetObject("PicBoxDown.Image")));
            this.PicBoxDown.Location = new System.Drawing.Point(144, 16);
            this.PicBoxDown.Name = "PicBoxDown";
            this.PicBoxDown.Size = new System.Drawing.Size(23, 17);
            this.PicBoxDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxDown.TabIndex = 2;
            this.PicBoxDown.TabStop = false;
            this.PicBoxDown.Click += new System.EventHandler(this.PicBoxDown_Click);
            // 
            // CustomizeTextbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelMain);
            this.Name = "CustomizeTextbox";
            this.Size = new System.Drawing.Size(167, 33);
            this.Load += new System.EventHandler(this.CustomizeTextbox_Load);
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.PictureBox PicBoxDown;
        private System.Windows.Forms.PictureBox PicBoxUp;
        private System.Windows.Forms.TextBox TBox;
    }
}
