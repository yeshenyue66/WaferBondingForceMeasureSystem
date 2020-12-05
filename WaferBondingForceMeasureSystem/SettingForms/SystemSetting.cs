using System;
using System.Configuration;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using System.Xml;
using WaferBondingForceMeasureSystem.ApplicationModule.Common.SerialPortCommon;
using WaferBondingForceMeasureSystem.ApplicationModule.Common.FormCommon;
using WaferBondingForceMeasureSystem.Util.Config;

namespace WaferBondingForceMeasureSystem.SettingForms
{
    public partial class SystemSetting : Form
    {
        private static SystemSetting systemSetting;
        private SystemSetting()
        {
            InitializeComponent();
        }

        public static SystemSetting Singleton()
        {
            if (systemSetting == null)
            {
                systemSetting = new SystemSetting();
            }
            return systemSetting;
        }

        static SerialPort lpSerialPort;
        public static SerialPort GetLPSerialPort(SerialPort serialPort)
        {
            lpSerialPort = serialPort;
            return lpSerialPort;
        }

        private void SystemSetting_Load(object sender, EventArgs e)
        {
            UIBLL.CustomizeMove<Panel, Label>(this.PanelSysSettingTopic, this.LabelSysSettingTopic, this);
            if (!IsChanged)
            {
                try
                {
                    SPBLL sPBLL = new SPBLL();
                    if (sPBLL.GetSerialPorts().Count > 1)
                    {
                        this.ComboBoxLoadPort.Items.AddRange(sPBLL.GetSerialPorts().ToArray());
                        this.ComboBoxLoadPort.SelectedIndex = 0;
                        this.ComboBoxManipulator.Items.AddRange(sPBLL.GetSerialPorts().ToArray());
                        this.ComboBoxManipulator.SelectedIndex = 1;
                    }
                    else
                    {
                        this.ComboBoxLoadPort.Text = string.Empty;
                        this.ComboBoxManipulator.Text = string.Empty;
                    }
                }
                catch
                {

                }
            }
            else
            {
                this.ComboBoxLoadPort.Text = systemSetting.ComboBoxLoadPort.Text;
                this.ComboBoxManipulator.Text = systemSetting.ComboBoxManipulator.Text;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            systemSetting.ComboBoxLoadPort.Text = this.ComboBoxLoadPort.Text;
            systemSetting.ComboBoxManipulator.Text = this.ComboBoxManipulator.Text;
            systemSetting.CTBKnife.TBoxContent = this.CTBKnife.TBoxContent;
            systemSetting.CTBCamera.TBoxContent = this.CTBCamera.TBoxContent;
            this.Close();
        }

        public delegate void MyDelegate(object sender, EventArgs e);
        public event MyDelegate MyEvent;

        private void BtnLPConnection_Click(object sender, EventArgs e)
        {
            ConfigSection.SetValue(AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "SerialPort.config", "LoadPort", this.ComboBoxLoadPort.Text);
            MyEvent?.Invoke(sender, e);
            //ConfigurationManager.AppSettings["LoadPortSerialPort"] = this.ComboBoxLoadPort.Text.ToString();
        }

        static bool IsChanged;
        private void ComboBoxLoadPort_TextChanged(object sender, EventArgs e)
        {
            IsChanged = true;
        }
        private void PicBoxSysSettingClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
