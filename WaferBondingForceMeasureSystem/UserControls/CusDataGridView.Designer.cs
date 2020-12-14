
namespace WaferBondingForceMeasureSystem.UserControls
{
    partial class CusDataGridView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CusDataGridView));
            this.PanelBody = new System.Windows.Forms.Panel();
            this.PanelDataView = new System.Windows.Forms.Panel();
            this.PanelData = new System.Windows.Forms.Panel();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.ColumnGoodsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnWaferID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSpec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCheckTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBonding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelWaferID = new System.Windows.Forms.Panel();
            this.PicBox = new System.Windows.Forms.PictureBox();
            this.LabelWaferID = new System.Windows.Forms.Label();
            this.PanelBody.SuspendLayout();
            this.PanelDataView.SuspendLayout();
            this.PanelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.PanelWaferID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelBody
            // 
            this.PanelBody.Controls.Add(this.PanelDataView);
            this.PanelBody.Controls.Add(this.PanelWaferID);
            this.PanelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBody.Location = new System.Drawing.Point(0, 0);
            this.PanelBody.Name = "PanelBody";
            this.PanelBody.Size = new System.Drawing.Size(727, 259);
            this.PanelBody.TabIndex = 1;
            // 
            // PanelDataView
            // 
            this.PanelDataView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(242)))));
            this.PanelDataView.Controls.Add(this.PanelData);
            this.PanelDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDataView.Location = new System.Drawing.Point(0, 22);
            this.PanelDataView.Name = "PanelDataView";
            this.PanelDataView.Size = new System.Drawing.Size(727, 237);
            this.PanelDataView.TabIndex = 1;
            // 
            // PanelData
            // 
            this.PanelData.Controls.Add(this.DGV);
            this.PanelData.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelData.Location = new System.Drawing.Point(39, 0);
            this.PanelData.Name = "PanelData";
            this.PanelData.Size = new System.Drawing.Size(688, 237);
            this.PanelData.TabIndex = 0;
            this.PanelData.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelData_Paint);
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AllowUserToResizeRows = false;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.ColumnHeadersVisible = false;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnGoodsID,
            this.ColumnWaferID,
            this.ColumnSpec,
            this.ColumnSite,
            this.ColumnCheckTime,
            this.ColumnBonding,
            this.ColumnResult});
            this.DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV.Location = new System.Drawing.Point(0, 0);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowTemplate.Height = 23;
            this.DGV.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DGV.Size = new System.Drawing.Size(688, 237);
            this.DGV.TabIndex = 0;
            // 
            // ColumnGoodsID
            // 
            this.ColumnGoodsID.HeaderText = "Column1";
            this.ColumnGoodsID.Name = "ColumnGoodsID";
            this.ColumnGoodsID.ReadOnly = true;
            this.ColumnGoodsID.Width = 98;
            // 
            // ColumnWaferID
            // 
            this.ColumnWaferID.HeaderText = "Column2";
            this.ColumnWaferID.Name = "ColumnWaferID";
            this.ColumnWaferID.ReadOnly = true;
            this.ColumnWaferID.Width = 98;
            // 
            // ColumnSpec
            // 
            this.ColumnSpec.HeaderText = "Column3";
            this.ColumnSpec.Name = "ColumnSpec";
            this.ColumnSpec.ReadOnly = true;
            this.ColumnSpec.Width = 98;
            // 
            // ColumnSite
            // 
            this.ColumnSite.HeaderText = "Column4";
            this.ColumnSite.Name = "ColumnSite";
            this.ColumnSite.ReadOnly = true;
            this.ColumnSite.Width = 97;
            // 
            // ColumnCheckTime
            // 
            this.ColumnCheckTime.HeaderText = "Column5";
            this.ColumnCheckTime.Name = "ColumnCheckTime";
            this.ColumnCheckTime.ReadOnly = true;
            this.ColumnCheckTime.Width = 98;
            // 
            // ColumnBonding
            // 
            this.ColumnBonding.HeaderText = "Column6";
            this.ColumnBonding.Name = "ColumnBonding";
            this.ColumnBonding.ReadOnly = true;
            this.ColumnBonding.Width = 98;
            // 
            // ColumnResult
            // 
            this.ColumnResult.HeaderText = "Column7";
            this.ColumnResult.Name = "ColumnResult";
            this.ColumnResult.ReadOnly = true;
            this.ColumnResult.Width = 98;
            // 
            // PanelWaferID
            // 
            this.PanelWaferID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(242)))));
            this.PanelWaferID.Controls.Add(this.PicBox);
            this.PanelWaferID.Controls.Add(this.LabelWaferID);
            this.PanelWaferID.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelWaferID.Location = new System.Drawing.Point(0, 0);
            this.PanelWaferID.Name = "PanelWaferID";
            this.PanelWaferID.Size = new System.Drawing.Size(727, 22);
            this.PanelWaferID.TabIndex = 0;
            this.PanelWaferID.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelWaferID_Paint);
            // 
            // PicBox
            // 
            this.PicBox.Image = ((System.Drawing.Image)(resources.GetObject("PicBox.Image")));
            this.PicBox.Location = new System.Drawing.Point(21, 1);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(20, 20);
            this.PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBox.TabIndex = 0;
            this.PicBox.TabStop = false;
            this.PicBox.Click += new System.EventHandler(this.PicBox_Click);
            // 
            // LabelWaferID
            // 
            this.LabelWaferID.AutoSize = true;
            this.LabelWaferID.Font = new System.Drawing.Font("宋体", 10F);
            this.LabelWaferID.Location = new System.Drawing.Point(48, 4);
            this.LabelWaferID.Name = "LabelWaferID";
            this.LabelWaferID.Size = new System.Drawing.Size(70, 14);
            this.LabelWaferID.TabIndex = 0;
            this.LabelWaferID.Text = "晶圆序号:";
            // 
            // CusDataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelBody);
            this.Name = "CusDataGridView";
            this.Size = new System.Drawing.Size(727, 259);
            this.Load += new System.EventHandler(this.CusDataGridView_Load);
            this.PanelBody.ResumeLayout(false);
            this.PanelDataView.ResumeLayout(false);
            this.PanelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.PanelWaferID.ResumeLayout(false);
            this.PanelWaferID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelBody;
        private System.Windows.Forms.Panel PanelDataView;
        private System.Windows.Forms.Panel PanelData;
        private System.Windows.Forms.Panel PanelWaferID;
        private System.Windows.Forms.Label LabelWaferID;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.PictureBox PicBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGoodsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnWaferID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSpec;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSite;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCheckTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBonding;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnResult;
    }
}
