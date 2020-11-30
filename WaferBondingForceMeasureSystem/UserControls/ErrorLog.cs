using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.IO.Ports;

using WaferBondingForceMeasureSystem.Models;
using WaferBondingForceMeasureSystem.Models.Control;
using WaferBondingForceMeasureSystem.ApplicationModule.Common.FormCommon;

namespace WaferBondingForceMeasureSystem.UserControls
{
    public partial class ErrorLog : UserControl
    {
        public ErrorLog()
        {
            InitializeComponent();
        }

        private void ErrorLog_Load(object sender, EventArgs e)
        {
            //string[] pr = SerialPort.GetPortNames();
            //this.TextBoxErrorLog.Text = pr[0];
        }

        private void TextBoxErrorLog_Resize(object sender, EventArgs e)
        {
            List<ControlModel> cms = new List<ControlModel>();
            //UIBLL controlBLL = new UIBLL();
            //cms.Add(controlBLL.GetList(this.PanelMain));
            cms.Add(_controlModel);
            this.TextBoxErrorLog.Text = cms[0].Height.ToString();
            
        }

        static ControlModel _controlModel;
        public ControlModel ControlInteraction(ControlModel controlModel)
        {
            _controlModel = controlModel;
            return _controlModel;
        }
    }
}
