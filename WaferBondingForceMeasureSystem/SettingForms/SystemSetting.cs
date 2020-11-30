using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Configuration;
using System.Xml;

using WaferBondingForceMeasureSystem.UserControls;
using WaferBondingForceMeasureSystem.ApplicationModule.Common.SerialPortCommon;

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
            if (!IsChanged)
            {
                this.PanelTBox1.Controls.Add(new CustomizeTextbox() { Dock = DockStyle.Fill, TBoxContent = 6500 });
                this.PanelTBox2.Controls.Add(new CustomizeTextbox() { Dock = DockStyle.Fill, TBoxContent = 60 });
                try
                {
                    SPBLL sPBLL = new SPBLL();
                    if (sPBLL.GetSerialPorts().Count > 1)
                    {
                        this.ComboBoxLoadPort.Text = sPBLL.GetSerialPorts()[0].ToString();
                        this.ComboBoxLoadPort.Items.AddRange(sPBLL.GetSerialPorts().ToArray());


                        this.ComboBoxManipulator.Text = sPBLL.GetSerialPorts()[1].ToString();
                        this.ComboBoxManipulator.Items.AddRange(sPBLL.GetSerialPorts().ToArray());
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
            ele.SetAttribute("value", this.ComboBoxLoadPort.Text.ToString().Substring(0, 4));
            doc.Save("SerialPort.config");

            MyEvent?.Invoke(sender, e);

            //SerialPort serialPort = new SerialPort();
            //serialPort.PortName = this.ComboBoxLoadPort.Text.ToString();
            //serialPort.BaudRate = 9600;
            //serialPort.DataBits = 8;
            //serialPort.StopBits = StopBits.One;
            //serialPort.DtrEnable = true;
            //serialPort.Parity = Parity.None;
            //serialPort.Open();

            //ComFormatEntity comFormatEntity = new ComFormatEntity(SETCommandNames.LPLODLON01);
            //List<byte> bbb = new List<byte>();
            //bbb.Add(comFormatEntity.SOH("TDKA")[0]);
            //bbb.Add(comFormatEntity.LEN()[0]);
            //bbb.Add(comFormatEntity.LEN()[1]);
            //bbb.Add(0x30);
            //bbb.Add(0x30);
            //List<byte> ccc = comFormatEntity.CMD().ToList();
            //bbb.AddRange(ccc);
            //bbb.Add(comFormatEntity.CSh());
            //bbb.Add(comFormatEntity.CSl());
            //bbb.Add(0x03);
            //byte[] ddd = bbb.ToArray();

            //lpSerialPort.Write(ddd, 0, ddd.Length);

        }

        static bool IsChanged;
        private void ComboBoxLoadPort_TextChanged(object sender, EventArgs e)
        {
            IsChanged = true;
        }
        private Point mousepoint;
        private Boolean leftflag = false;
        private void WBFMSystem_MouseUp(object sender, MouseEventArgs e)
        {
            leftflag = false;
        }

        private void WBFMSystem_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftflag)
            {
                Left = MousePosition.X - mousepoint.X;
                Top = MousePosition.Y - mousepoint.Y;
            }
        }

        private void WBFMSystem_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mousepoint.X = e.X;
                mousepoint.Y = e.Y;
                leftflag = true;
            }
        }
    }
}
