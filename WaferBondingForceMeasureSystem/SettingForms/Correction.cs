using System.Windows.Forms;
using WaferBondingForceMeasureSystem.ApplicationModule.Common.FormCommon;
using WaferBondingForceMeasureSystem.ApplicationModule.ComProtocol;

namespace WaferBondingForceMeasureSystem.SettingForms
{
    public partial class Correction : Form
    {
        public Correction()
        {
            InitializeComponent();
            UIBLL.CustomizeMove<Panel, Label>(this.PanelMenu, this.LabelCorrect, this);
        }

        private void BtnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void BtnKnifeInitial_Click(object sender, System.EventArgs e)
        {
            if(WBFMSystem.lPSerialPort.IsOpen)
            {
                byte[] init = ComFormatPackage.ConstructCommandInfo(SETCommandNames.LBL07);
                WBFMSystem.lPSerialPort.Write(init, 0, init.Length);
            }
        }
    }
}
