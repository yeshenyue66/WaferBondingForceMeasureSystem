using System;
using System.Windows.Forms;
using WaferBondingForceMeasureSystem.ApplicationModule.Common.FormCommon;

namespace WaferBondingForceMeasureSystem.SettingForms
{
    public partial class CalibrationSetting : Form
    {
        private static CalibrationSetting calibrationSetting = null;
        private CalibrationSetting()
        {
            InitializeComponent();
            UIBLL.CustomizeMove<Panel, Label>(this.PanelTopic, this.LabelTopic, this);
        }

        public static CalibrationSetting Singleton()
        {
            if(calibrationSetting == null)
            {
                calibrationSetting = new CalibrationSetting();
                return calibrationSetting;
            }
            else
            {
                return calibrationSetting;
            }
        }

        private void PicBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
