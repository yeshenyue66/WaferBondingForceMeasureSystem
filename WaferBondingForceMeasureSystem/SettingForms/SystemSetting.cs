using System;
using System.Configuration;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using System.Xml;
using WaferBondingForceMeasureSystem.ApplicationModule.Common.SerialPortCommon;
using WaferBondingForceMeasureSystem.ApplicationModule.Common.FormCommon;
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

        private void BtnManipulatorConnection_Click(object sender, EventArgs e)
        {

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
                //this.PanelTBox1.Controls.Add(new CustomizeTextbox() { Dock = DockStyle.Fill, TBoxContent = 6500 });
                //this.PanelTBox2.Controls.Add(new CustomizeTextbox() { Dock = DockStyle.Fill, TBoxContent = 60 });
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
            ConfigurationManager.AppSettings["LoadPortSerialPort"] = this.ComboBoxLoadPort.Text.ToString();

            XmlDocument doc = new XmlDocument();
            doc.Load("SerialPort.config");
            XmlNode node = doc.SelectSingleNode(@"//add[@key='LoadPortSerialPort']");
            XmlElement ele = (XmlElement)node;
            ele.SetAttribute("value", this.ComboBoxLoadPort.Text.ToString());
            doc.Save("SerialPort.config");

            MyEvent?.Invoke(sender, e);
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
