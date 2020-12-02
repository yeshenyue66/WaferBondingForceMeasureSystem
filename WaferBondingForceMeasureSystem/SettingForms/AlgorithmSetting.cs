using System;
using System.Windows.Forms;
using WaferBondingForceMeasureSystem.Models.Control;
using WaferBondingForceMeasureSystem.UserControls;

namespace WaferBondingForceMeasureSystem.SettingForms
{
    public partial class AlgorithmSetting : Form
    {
        public AlgorithmSetting()
        {
            InitializeComponent();

            this.PanelTBox1.Controls.Add(new CustomizeTextbox() {Dock = DockStyle.Fill, TBoxContent = 100 });
            this.PanelTBox2.Controls.Add(new CustomizeTextbox() { Dock = DockStyle.Fill, TBoxContent = 500 });
            this.PanelTBox3.Controls.Add(new CustomizeTextbox() { Dock = DockStyle.Fill, TBoxContent = 500 });
            this.PanelTBox4.Controls.Add(new CustomizeTextbox() { Dock = DockStyle.Fill, TBoxContent = 100 });
            this.PanelTBox5.Controls.Add(new CustomizeTextbox() { Dock = DockStyle.Fill, TBoxContent = 100 });
            this.PanelTBox6.Controls.Add(new CustomizeTextbox() { Dock = DockStyle.Fill, TBoxContent = 100 });
            this.PanelTBox7.Controls.Add(new CustomizeTextbox() { Dock = DockStyle.Fill, TBoxContent = 100 });
            this.PanelTBox8.Controls.Add(new CustomizeTextbox() { Dock = DockStyle.Fill, TBoxContent = 100 });
            this.PanelTBox9.Controls.Add(new CustomizeTextbox() { Dock = DockStyle.Fill, TBoxContent = 100 });
            this.PanelTBox10.Controls.Add(new CustomizeTextbox() { Dock = DockStyle.Fill, TBoxContent = 100 });
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        static ControlModel _controlModel;
        public ControlModel ControlInteraction(ControlModel controlModel)
        {
            _controlModel = controlModel;
            return _controlModel;
        }

        private void AlgorithmSetting_Load(object sender, EventArgs e)
        {
            this.Height = 553 * _controlModel.Height / 1080;
            this.Width = 440 * _controlModel.Width / 1902;

        }
    }
}
