namespace WaferBondingForceMeasureSystem.SettingForms
{
    partial class DataManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataManage));
            this.PanelTopic = new System.Windows.Forms.Panel();
            this.PicBoxClose = new System.Windows.Forms.PictureBox();
            this.LabelTopic = new System.Windows.Forms.Label();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.PanelBody = new System.Windows.Forms.Panel();
            this.PanelPic = new System.Windows.Forms.Panel();
            this.PanelDatagrid = new System.Windows.Forms.Panel();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.DGVTextBoxGoodsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTextBoxWaferID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTextBoxSpec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTextBoxSites = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTextBoxCheckTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTextBoxForce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTextBoxResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelClose = new System.Windows.Forms.Panel();
            this.BtnClose = new System.Windows.Forms.Button();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.PanelMenuOpenFile = new System.Windows.Forms.Panel();
            this.PicBoxOpenFile = new System.Windows.Forms.PictureBox();
            this.LabelOpenFile = new System.Windows.Forms.Label();
            this.PanelMenuCleanUp = new System.Windows.Forms.Panel();
            this.PicBoxCleanUp = new System.Windows.Forms.PictureBox();
            this.LabelCleanUp = new System.Windows.Forms.Label();
            this.PanelMenuDeleteGoods = new System.Windows.Forms.Panel();
            this.PicBoxDeleteGoods = new System.Windows.Forms.PictureBox();
            this.LabelDeleteGoods = new System.Windows.Forms.Label();
            this.PanelMenuDeleteRow = new System.Windows.Forms.Panel();
            this.PicBoxDeleteRow = new System.Windows.Forms.PictureBox();
            this.LabelDeleteRow = new System.Windows.Forms.Label();
            this.PanelMenuOutput = new System.Windows.Forms.Panel();
            this.PicBoxOutput = new System.Windows.Forms.PictureBox();
            this.LabelOutput = new System.Windows.Forms.Label();
            this.PanelTopic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxClose)).BeginInit();
            this.PanelMain.SuspendLayout();
            this.PanelBody.SuspendLayout();
            this.PanelDatagrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.PanelClose.SuspendLayout();
            this.PanelMenu.SuspendLayout();
            this.PanelMenuOpenFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxOpenFile)).BeginInit();
            this.PanelMenuCleanUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxCleanUp)).BeginInit();
            this.PanelMenuDeleteGoods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxDeleteGoods)).BeginInit();
            this.PanelMenuDeleteRow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxDeleteRow)).BeginInit();
            this.PanelMenuOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTopic
            // 
            this.PanelTopic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(62)))), ((int)(((byte)(77)))));
            this.PanelTopic.Controls.Add(this.PicBoxClose);
            this.PanelTopic.Controls.Add(this.LabelTopic);
            this.PanelTopic.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTopic.Location = new System.Drawing.Point(0, 0);
            this.PanelTopic.Name = "PanelTopic";
            this.PanelTopic.Size = new System.Drawing.Size(978, 35);
            this.PanelTopic.TabIndex = 2;
            // 
            // PicBoxClose
            // 
            this.PicBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("PicBoxClose.Image")));
            this.PicBoxClose.Location = new System.Drawing.Point(933, 3);
            this.PicBoxClose.Name = "PicBoxClose";
            this.PicBoxClose.Size = new System.Drawing.Size(33, 32);
            this.PicBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxClose.TabIndex = 0;
            this.PicBoxClose.TabStop = false;
            this.PicBoxClose.Click += new System.EventHandler(this.PicBoxClose_Click);
            // 
            // LabelTopic
            // 
            this.LabelTopic.AutoSize = true;
            this.LabelTopic.ForeColor = System.Drawing.Color.White;
            this.LabelTopic.Location = new System.Drawing.Point(13, 13);
            this.LabelTopic.Name = "LabelTopic";
            this.LabelTopic.Size = new System.Drawing.Size(89, 12);
            this.LabelTopic.TabIndex = 0;
            this.LabelTopic.Text = "晶圆键合力测量";
            // 
            // PanelMain
            // 
            this.PanelMain.Controls.Add(this.PanelBody);
            this.PanelMain.Controls.Add(this.PanelClose);
            this.PanelMain.Controls.Add(this.PanelMenu);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(0, 35);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(978, 548);
            this.PanelMain.TabIndex = 3;
            this.PanelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMain_Paint);
            // 
            // PanelBody
            // 
            this.PanelBody.Controls.Add(this.PanelPic);
            this.PanelBody.Controls.Add(this.PanelDatagrid);
            this.PanelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBody.Location = new System.Drawing.Point(0, 52);
            this.PanelBody.Name = "PanelBody";
            this.PanelBody.Size = new System.Drawing.Size(978, 452);
            this.PanelBody.TabIndex = 1;
            // 
            // PanelPic
            // 
            this.PanelPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPic.Location = new System.Drawing.Point(603, 0);
            this.PanelPic.Name = "PanelPic";
            this.PanelPic.Size = new System.Drawing.Size(375, 452);
            this.PanelPic.TabIndex = 1;
            this.PanelPic.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // PanelDatagrid
            // 
            this.PanelDatagrid.Controls.Add(this.DataGridView);
            this.PanelDatagrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelDatagrid.Location = new System.Drawing.Point(0, 0);
            this.PanelDatagrid.Name = "PanelDatagrid";
            this.PanelDatagrid.Size = new System.Drawing.Size(603, 452);
            this.PanelDatagrid.TabIndex = 0;
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.AllowUserToOrderColumns = true;
            this.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGVTextBoxGoodsID,
            this.DGVTextBoxWaferID,
            this.DGVTextBoxSpec,
            this.DGVTextBoxSites,
            this.DGVTextBoxCheckTime,
            this.DGVTextBoxForce,
            this.DGVTextBoxResult});
            this.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView.Location = new System.Drawing.Point(0, 0);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridView.RowTemplate.Height = 23;
            this.DataGridView.Size = new System.Drawing.Size(603, 452);
            this.DataGridView.TabIndex = 0;
            // 
            // DGVTextBoxGoodsID
            // 
            this.DGVTextBoxGoodsID.HeaderText = "物料编号";
            this.DGVTextBoxGoodsID.Name = "DGVTextBoxGoodsID";
            // 
            // DGVTextBoxWaferID
            // 
            this.DGVTextBoxWaferID.HeaderText = "晶圆序号";
            this.DGVTextBoxWaferID.Name = "DGVTextBoxWaferID";
            // 
            // DGVTextBoxSpec
            // 
            this.DGVTextBoxSpec.HeaderText = "规格(in)";
            this.DGVTextBoxSpec.Name = "DGVTextBoxSpec";
            // 
            // DGVTextBoxSites
            // 
            this.DGVTextBoxSites.HeaderText = "站点";
            this.DGVTextBoxSites.Name = "DGVTextBoxSites";
            // 
            // DGVTextBoxCheckTime
            // 
            this.DGVTextBoxCheckTime.HeaderText = "检测时间(ms)";
            this.DGVTextBoxCheckTime.Name = "DGVTextBoxCheckTime";
            // 
            // DGVTextBoxForce
            // 
            this.DGVTextBoxForce.HeaderText = "键合力(J/m²)";
            this.DGVTextBoxForce.Name = "DGVTextBoxForce";
            // 
            // DGVTextBoxResult
            // 
            this.DGVTextBoxResult.HeaderText = "结果";
            this.DGVTextBoxResult.Name = "DGVTextBoxResult";
            // 
            // PanelClose
            // 
            this.PanelClose.Controls.Add(this.BtnClose);
            this.PanelClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelClose.Location = new System.Drawing.Point(0, 504);
            this.PanelClose.Name = "PanelClose";
            this.PanelClose.Size = new System.Drawing.Size(978, 44);
            this.PanelClose.TabIndex = 2;
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.Font = new System.Drawing.Font("宋体", 15F);
            this.BtnClose.Location = new System.Drawing.Point(883, 6);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(83, 32);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "关闭";
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(192)))), ((int)(((byte)(207)))));
            this.PanelMenu.Controls.Add(this.PanelMenuOpenFile);
            this.PanelMenu.Controls.Add(this.PanelMenuCleanUp);
            this.PanelMenu.Controls.Add(this.PanelMenuDeleteGoods);
            this.PanelMenu.Controls.Add(this.PanelMenuDeleteRow);
            this.PanelMenu.Controls.Add(this.PanelMenuOutput);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(978, 52);
            this.PanelMenu.TabIndex = 0;
            // 
            // PanelMenuOpenFile
            // 
            this.PanelMenuOpenFile.Controls.Add(this.PicBoxOpenFile);
            this.PanelMenuOpenFile.Controls.Add(this.LabelOpenFile);
            this.PanelMenuOpenFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenuOpenFile.Location = new System.Drawing.Point(362, 0);
            this.PanelMenuOpenFile.Name = "PanelMenuOpenFile";
            this.PanelMenuOpenFile.Size = new System.Drawing.Size(141, 52);
            this.PanelMenuOpenFile.TabIndex = 4;
            // 
            // PicBoxOpenFile
            // 
            this.PicBoxOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("PicBoxOpenFile.Image")));
            this.PicBoxOpenFile.Location = new System.Drawing.Point(3, 8);
            this.PicBoxOpenFile.Name = "PicBoxOpenFile";
            this.PicBoxOpenFile.Size = new System.Drawing.Size(33, 32);
            this.PicBoxOpenFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxOpenFile.TabIndex = 1;
            this.PicBoxOpenFile.TabStop = false;
            this.PicBoxOpenFile.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LabelOpenFile
            // 
            this.LabelOpenFile.AutoSize = true;
            this.LabelOpenFile.Location = new System.Drawing.Point(35, 17);
            this.LabelOpenFile.Name = "LabelOpenFile";
            this.LabelOpenFile.Size = new System.Drawing.Size(101, 12);
            this.LabelOpenFile.TabIndex = 0;
            this.LabelOpenFile.Text = "打开图片所在路径";
            // 
            // PanelMenuCleanUp
            // 
            this.PanelMenuCleanUp.Controls.Add(this.PicBoxCleanUp);
            this.PanelMenuCleanUp.Controls.Add(this.LabelCleanUp);
            this.PanelMenuCleanUp.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenuCleanUp.Location = new System.Drawing.Point(284, 0);
            this.PanelMenuCleanUp.Name = "PanelMenuCleanUp";
            this.PanelMenuCleanUp.Size = new System.Drawing.Size(78, 52);
            this.PanelMenuCleanUp.TabIndex = 3;
            // 
            // PicBoxCleanUp
            // 
            this.PicBoxCleanUp.Image = ((System.Drawing.Image)(resources.GetObject("PicBoxCleanUp.Image")));
            this.PicBoxCleanUp.Location = new System.Drawing.Point(6, 8);
            this.PicBoxCleanUp.Name = "PicBoxCleanUp";
            this.PicBoxCleanUp.Size = new System.Drawing.Size(33, 32);
            this.PicBoxCleanUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxCleanUp.TabIndex = 1;
            this.PicBoxCleanUp.TabStop = false;
            this.PicBoxCleanUp.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LabelCleanUp
            // 
            this.LabelCleanUp.AutoSize = true;
            this.LabelCleanUp.Location = new System.Drawing.Point(43, 17);
            this.LabelCleanUp.Name = "LabelCleanUp";
            this.LabelCleanUp.Size = new System.Drawing.Size(29, 12);
            this.LabelCleanUp.TabIndex = 0;
            this.LabelCleanUp.Text = "清空";
            // 
            // PanelMenuDeleteGoods
            // 
            this.PanelMenuDeleteGoods.Controls.Add(this.PicBoxDeleteGoods);
            this.PanelMenuDeleteGoods.Controls.Add(this.LabelDeleteGoods);
            this.PanelMenuDeleteGoods.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenuDeleteGoods.Location = new System.Drawing.Point(184, 0);
            this.PanelMenuDeleteGoods.Name = "PanelMenuDeleteGoods";
            this.PanelMenuDeleteGoods.Size = new System.Drawing.Size(100, 52);
            this.PanelMenuDeleteGoods.TabIndex = 2;
            // 
            // PicBoxDeleteGoods
            // 
            this.PicBoxDeleteGoods.Image = ((System.Drawing.Image)(resources.GetObject("PicBoxDeleteGoods.Image")));
            this.PicBoxDeleteGoods.Location = new System.Drawing.Point(6, 8);
            this.PicBoxDeleteGoods.Name = "PicBoxDeleteGoods";
            this.PicBoxDeleteGoods.Size = new System.Drawing.Size(33, 32);
            this.PicBoxDeleteGoods.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxDeleteGoods.TabIndex = 1;
            this.PicBoxDeleteGoods.TabStop = false;
            this.PicBoxDeleteGoods.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LabelDeleteGoods
            // 
            this.LabelDeleteGoods.AutoSize = true;
            this.LabelDeleteGoods.Location = new System.Drawing.Point(45, 17);
            this.LabelDeleteGoods.Name = "LabelDeleteGoods";
            this.LabelDeleteGoods.Size = new System.Drawing.Size(53, 12);
            this.LabelDeleteGoods.TabIndex = 0;
            this.LabelDeleteGoods.Text = "删除物料";
            // 
            // PanelMenuDeleteRow
            // 
            this.PanelMenuDeleteRow.Controls.Add(this.PicBoxDeleteRow);
            this.PanelMenuDeleteRow.Controls.Add(this.LabelDeleteRow);
            this.PanelMenuDeleteRow.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenuDeleteRow.Location = new System.Drawing.Point(78, 0);
            this.PanelMenuDeleteRow.Name = "PanelMenuDeleteRow";
            this.PanelMenuDeleteRow.Size = new System.Drawing.Size(106, 52);
            this.PanelMenuDeleteRow.TabIndex = 1;
            // 
            // PicBoxDeleteRow
            // 
            this.PicBoxDeleteRow.Image = ((System.Drawing.Image)(resources.GetObject("PicBoxDeleteRow.Image")));
            this.PicBoxDeleteRow.Location = new System.Drawing.Point(0, 6);
            this.PicBoxDeleteRow.Name = "PicBoxDeleteRow";
            this.PicBoxDeleteRow.Size = new System.Drawing.Size(33, 32);
            this.PicBoxDeleteRow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxDeleteRow.TabIndex = 1;
            this.PicBoxDeleteRow.TabStop = false;
            this.PicBoxDeleteRow.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LabelDeleteRow
            // 
            this.LabelDeleteRow.AutoSize = true;
            this.LabelDeleteRow.Location = new System.Drawing.Point(35, 17);
            this.LabelDeleteRow.Name = "LabelDeleteRow";
            this.LabelDeleteRow.Size = new System.Drawing.Size(65, 12);
            this.LabelDeleteRow.TabIndex = 0;
            this.LabelDeleteRow.Text = "删除选中行";
            // 
            // PanelMenuOutput
            // 
            this.PanelMenuOutput.Controls.Add(this.PicBoxOutput);
            this.PanelMenuOutput.Controls.Add(this.LabelOutput);
            this.PanelMenuOutput.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenuOutput.Location = new System.Drawing.Point(0, 0);
            this.PanelMenuOutput.Name = "PanelMenuOutput";
            this.PanelMenuOutput.Size = new System.Drawing.Size(78, 52);
            this.PanelMenuOutput.TabIndex = 0;
            this.PanelMenuOutput.Click += new System.EventHandler(this.PanelMenuOutput_Click);
            // 
            // PicBoxOutput
            // 
            this.PicBoxOutput.Image = ((System.Drawing.Image)(resources.GetObject("PicBoxOutput.Image")));
            this.PicBoxOutput.Location = new System.Drawing.Point(3, 8);
            this.PicBoxOutput.Name = "PicBoxOutput";
            this.PicBoxOutput.Size = new System.Drawing.Size(33, 32);
            this.PicBoxOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxOutput.TabIndex = 1;
            this.PicBoxOutput.TabStop = false;
            this.PicBoxOutput.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LabelOutput
            // 
            this.LabelOutput.AutoSize = true;
            this.LabelOutput.Location = new System.Drawing.Point(43, 17);
            this.LabelOutput.Name = "LabelOutput";
            this.LabelOutput.Size = new System.Drawing.Size(29, 12);
            this.LabelOutput.TabIndex = 0;
            this.LabelOutput.Text = "导出";
            this.LabelOutput.Click += new System.EventHandler(this.LabelOutput_Click);
            // 
            // DataManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(978, 583);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.PanelTopic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据管理";
            this.Load += new System.EventHandler(this.DataManage_Load);
            this.PanelTopic.ResumeLayout(false);
            this.PanelTopic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxClose)).EndInit();
            this.PanelMain.ResumeLayout(false);
            this.PanelBody.ResumeLayout(false);
            this.PanelDatagrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.PanelClose.ResumeLayout(false);
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenuOpenFile.ResumeLayout(false);
            this.PanelMenuOpenFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxOpenFile)).EndInit();
            this.PanelMenuCleanUp.ResumeLayout(false);
            this.PanelMenuCleanUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxCleanUp)).EndInit();
            this.PanelMenuDeleteGoods.ResumeLayout(false);
            this.PanelMenuDeleteGoods.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxDeleteGoods)).EndInit();
            this.PanelMenuDeleteRow.ResumeLayout(false);
            this.PanelMenuDeleteRow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxDeleteRow)).EndInit();
            this.PanelMenuOutput.ResumeLayout(false);
            this.PanelMenuOutput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTopic;
        private System.Windows.Forms.PictureBox PicBoxClose;
        private System.Windows.Forms.Label LabelTopic;
        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel PanelMenuOpenFile;
        private System.Windows.Forms.Panel PanelMenuCleanUp;
        private System.Windows.Forms.Panel PanelMenuDeleteGoods;
        private System.Windows.Forms.Panel PanelMenuDeleteRow;
        private System.Windows.Forms.Panel PanelMenuOutput;
        private System.Windows.Forms.Label LabelOutput;
        private System.Windows.Forms.Label LabelOpenFile;
        private System.Windows.Forms.Label LabelCleanUp;
        private System.Windows.Forms.Label LabelDeleteGoods;
        private System.Windows.Forms.Label LabelDeleteRow;
        private System.Windows.Forms.PictureBox PicBoxOutput;
        private System.Windows.Forms.PictureBox PicBoxOpenFile;
        private System.Windows.Forms.PictureBox PicBoxCleanUp;
        private System.Windows.Forms.PictureBox PicBoxDeleteGoods;
        private System.Windows.Forms.PictureBox PicBoxDeleteRow;
        private System.Windows.Forms.Panel PanelBody;
        private System.Windows.Forms.Panel PanelPic;
        private System.Windows.Forms.Panel PanelDatagrid;
        private System.Windows.Forms.Panel PanelClose;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTextBoxGoodsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTextBoxWaferID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTextBoxSpec;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTextBoxSites;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTextBoxCheckTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTextBoxForce;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTextBoxResult;
    }
}