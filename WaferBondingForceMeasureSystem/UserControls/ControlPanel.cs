using System;
using System.Windows.Forms;

using WaferBondingForceMeasureSystem.ApplicationModule.Common.FormCommon;
using WaferBondingForceMeasureSystem.Models.Control;

namespace WaferBondingForceMeasureSystem.UserControls
{
    public partial class ControlPanel : UserControl
    {
        public ControlPanel()
        {
            InitializeComponent();
        }

        private void ControlPanel_Resize(object sender, EventArgs e)
        {
            foreach(ControlModel _childcontrol in new UIBLL().GetSizeList(this))
            {
                _childcontrol.Width = 200 * this.Width / 306;
                //_childcontrol.FontSet = new Font(_childcontrol.FontSet.Name, 10 * this.Width / 306);
            }
           
            //this.LabelNum.Width = 200 * this.PanelSetting.Width / 306;
            //LabelNum.Font = new Font(LabelNum.Font.Name, Convert.ToSingle(10) * (float)(this.PanelSetting.Width / 306));
            //this.LabelHandle.Width = 200 * this.PanelSetting.Width / 306;
            //LabelHandle.Font = new Font(LabelHandle.Font.Name, Convert.ToSingle(10) * this.PanelSetting.Width / 306);
            //this.LabelPlan.Width = 200 * this.PanelSetting.Width / 306;
            //LabelPlan.Font = new Font(LabelPlan.Font.Name, Convert.ToSingle(10) * this.PanelSetting.Width / 306);
            //this.LabelSerial.Width = 200 * this.PanelSetting.Width / 306;
            //LabelSerial.Font = new Font(LabelSerial.Font.Name, Convert.ToSingle(10) * this.PanelSetting.Width / 306);
            //this.Width = 200 * this.PanelSetting.Width / 306;
        }
    }
}
