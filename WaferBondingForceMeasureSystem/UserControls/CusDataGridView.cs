using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaferBondingForceMeasureSystem.UserControls
{
    public partial class CusDataGridView : UserControl
    {
        public int CusHeight { get => 25 + this.DGV.Rows.Count * this.DGV.RowTemplate.Height; }

        public CusDataGridView()
        {
            InitializeComponent();
            Dock = DockStyle.Top;
        }

        private void PanelData_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CusDataGridView_Load(object sender, EventArgs e)
        {
            this.DGV.Rows.Add("1", "2", "1", "2", "1", "2", "1");
            this.DGV.Rows.Add("1", "2", "1", "2", "1", "2", "1");
            this.DGV.Rows.Add("1", "2", "1", "2", "1", "2", "1");
            this.DGV.Rows.Add("1", "2", "1", "2", "1", "2", "1");

            this.Height = CusHeight;
        }

        private void PicBox_Click(object sender, EventArgs e)
        {
            if (this.PanelDataView.Visible == true)
            {
                this.PanelDataView.Visible = false;
                this.PicBox.Image = Image.FromFile(AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "Images/DGVUp.png");
            }
            else
            {
                this.PanelDataView.Visible = true;
                this.PicBox.Image = Image.FromFile(AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "Images/DGVDown.png");
            }
        }

        private void PanelWaferID_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
