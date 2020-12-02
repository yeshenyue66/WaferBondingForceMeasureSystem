using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using WaferBondingForceMeasureSystem.ApplicationModule.Common.FormCommon;
using WaferBondingForceMeasureSystem.ApplicationModule.ComProtocol;
using WaferBondingForceMeasureSystem.Models.Control;
using WaferBondingForceMeasureSystem.SettingForms;
using WaferBondingForceMeasureSystem.UserControls;

namespace WaferBondingForceMeasureSystem
{

    public partial class WBFMSystem : Form
    {

        public static readonly log4net.ILog loginfo = log4net.LogManager.GetLogger("loginfo");
        public static readonly log4net.ILog logerror = log4net.LogManager.GetLogger("logerror");

        public static void WriteLog(string info)
        {
            if (loginfo.IsInfoEnabled)
            {
                loginfo.Info(info);
            }
        }

        public static void WriteLog(string info, Exception ex)
        {
            if (logerror.IsErrorEnabled)
            {
                logerror.Error(info, ex);
            }
        }
        SystemSetting systemSetting = null;
        public WBFMSystem()
        {
            InitializeComponent();

            //new UIBLL().CustomizeMove<Panel>(this.PanelMenu, this);

            systemSetting = SystemSetting.Singleton();
            systemSetting.MyEvent += WBFMSystem_Load;
           
        }

        private void PicBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        static SerialPort lPSerialPort;
        delegate SerialPort LPSerialPortTran(SerialPort serialPort);
        private void WBFMSystem_Load(object sender, EventArgs e)
        {
            //new UIBLL().CustomizeMove(this.PanelMenu, this);

            this.PanelLog.Controls.Add(new ErrorLog {Dock = DockStyle.Fill });
            this.PanelAnalysisPic.Controls.Add(new AnalysisPic { Dock = DockStyle.Fill });
            this.PanelControl.Controls.Add(new ControlPanel { Dock = DockStyle.Fill });

            try
            {
                lPSerialPort = new SerialPort();
                //lPSerialPort.PortName = SPBLL.LPSerialPortName();
                lPSerialPort.PortName = "COM2";
                lPSerialPort.Open();

                //ComFormatEntity comFormatEntity = new ComFormatEntity(EVTCommandNames.PODOF);
                //List<byte> bbb = new List<byte>();
                //bbb.Add(comFormatEntity.SOH("TDKA"));
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

                //byte[] da = Encoding.ASCII.GetBytes("$1CR");
                byte[] Message = ComFormatPackage.ConstructCommandInfo(SETCommandNames.INITL);
                lPSerialPort.Write(Message, 0, Message.Length);

                LPSerialPortTran lPSerialPortTran = new LPSerialPortTran(SystemSetting.GetLPSerialPort);
                lPSerialPortTran(lPSerialPort);

            }
            catch
            {

            }
        }
   
        private void PicBoxScaling_Click(object sender, EventArgs e)
        {

        }

        #region WndProc

        const int WM_NCHITTEST = 0x0084;
        const int HTLEFT = 10;
        const int HTRIGHT = 11;
        const int HTTOP = 12;
        const int HTTOPLEFT = 13;
        const int HTTOPRIGHT = 14;
        const int HTBOTTOM = 15;
        const int HTBOTTOMLEFT = 0x10;
        const int HTBOTTOMRIGHT = 17;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    Point vPoint = new Point((int)m.LParam & 0xFFFF,
                        (int)m.LParam >> 16 & 0xFFFF);
                    vPoint = PointToClient(vPoint);
                    if (vPoint.X <= 5)
                        if (vPoint.Y <= 5)
                            m.Result = (IntPtr)HTTOPLEFT;
                        else if (vPoint.Y >= ClientSize.Height - 5)
                            m.Result = (IntPtr)HTBOTTOMLEFT;
                        else m.Result = (IntPtr)HTLEFT;
                    else if (vPoint.X >= ClientSize.Width - 5)
                        if (vPoint.Y <= 5)
                            m.Result = (IntPtr)HTTOPRIGHT;
                        else if (vPoint.Y >= ClientSize.Height - 5)
                            m.Result = (IntPtr)HTBOTTOMRIGHT;
                        else m.Result = (IntPtr)HTRIGHT;
                    else if (vPoint.Y <= 5)
                        m.Result = (IntPtr)HTTOP;
                    else if (vPoint.Y >= ClientSize.Height - 5)
                        m.Result = (IntPtr)HTBOTTOM;
                    break;
            }
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        #endregion

        private void WBFMSystem_Move(object sender, EventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);

        }

        public delegate ControlModel ControlInteraction(ControlModel _controlModel);

        private void WBFMSystem_Resize(object sender, EventArgs e)
        {
            ControlInteraction interaction = new ControlInteraction(new ErrorLog().ControlInteraction);
            interaction(new UIBLL().GetSizeData(this));
            ControlInteraction interaction2 = new ControlInteraction(new AlgorithmSetting().ControlInteraction);
            interaction2(new UIBLL().GetSizeData(this));

            this.PanelLog.Width = 239 * this.Width / 800;
            this.PanelControl.Width = 241 * this.Width / 800;
        }

        private void TSMenuCalibration_Click(object sender, EventArgs e)
        {
            CalibrationSetting calibrationSetting = new CalibrationSetting();
            calibrationSetting.ShowDialog();
        }

        private void PanelAlgorithmSetting_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelAnalysisPic_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LabelAlgorithmSetting_Click(object sender, EventArgs e)
        {
            AlgorithmSetting algorithmSetting = new AlgorithmSetting();
            algorithmSetting.ShowDialog();
        }

        private void LabelSystemSetting_Click(object sender, EventArgs e)
        {
            SystemSetting.Singleton().ShowDialog();
        }

        private void PicBoxSystemSetting_Click(object sender, EventArgs e)
        {
            SystemSetting.Singleton().ShowDialog();
        }

        private void PanelAlgorithmSetting_Click(object sender, EventArgs e)
        {
            byte[] buf = new byte[lPSerialPort.BytesToRead];
            lPSerialPort.Read(buf, 0, buf.Length);
            ComFormatPackage.ParseCommandInfo(buf);
            AlgorithmSetting algorithmSetting = new AlgorithmSetting();
            algorithmSetting.ShowDialog();
        }

        private void PicBoxAlgorithmSetting_Click(object sender, EventArgs e)
        {
            byte[] buf = new byte[lPSerialPort.BytesToRead];
            lPSerialPort.Read(buf, 0, buf.Length);
            ComFormatPackage.ParseCommandInfo(buf);
            AlgorithmSetting algorithmSetting = new AlgorithmSetting();
            algorithmSetting.ShowDialog();
        }

        private void LabelDataManage_Click(object sender, EventArgs e)
        {
            DataManage dataManage = new DataManage();
            dataManage.ShowDialog();
        }

        private void PicBoxDataManage_Click(object sender, EventArgs e)
        {
            DataManage dataManage = new DataManage();
            dataManage.ShowDialog();
        }

        private void PicBoxPlanManage_Click(object sender, EventArgs e)
        {
            PlanManage planManage = new PlanManage();
            planManage.ShowDialog();
        }

        private void LabelPlanManage_Click(object sender, EventArgs e)
        {
            PlanManage planManage = new PlanManage();
            planManage.ShowDialog();
        }

        private void LabelCalibrationSetting_Click(object sender, EventArgs e)
        {
            CalibrationSetting calibrationSetting = new CalibrationSetting();
            calibrationSetting.ShowDialog();
        }

        private void PicBoxCalibration_Click(object sender, EventArgs e)
        {
            CalibrationSetting calibrationSetting = new CalibrationSetting();
            calibrationSetting.ShowDialog();
        }

        private Point mouseOffset;
        private bool isMouseDown = false;
        //private void WBFMSystem_MouseUp(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        isMouseDown = false;
        //    }
        //}

        //private void WBFMSystem_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (isMouseDown)
        //    {
        //        Point p = MousePosition;
        //        p.Offset(mouseOffset.X, mouseOffset.Y);
        //        this.Location = p;
        //    }
        //}

        //private void WBFMSystem_MouseDown(object sender, MouseEventArgs e)
        //{
        //    int yOffset, xOffset;
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
        //        yOffset = -e.Y - SystemInformation.FrameBorderSize.Height;
        //        mouseOffset = new Point(xOffset, yOffset);
        //        isMouseDown = true;
        //    }
        //}

        private void PanelTopic_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void PanelTopic_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point p = MousePosition;
                p.Offset(mouseOffset.X, mouseOffset.Y);
                this.Location = p;
            }
        }

        private void PanelTopic_MouseDown(object sender, MouseEventArgs e)
        {
            int yOffset, xOffset;
            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
                yOffset = -e.Y - SystemInformation.FrameBorderSize.Height;
                mouseOffset = new Point(xOffset, yOffset);
                isMouseDown = true;
            }
        }
    }
}