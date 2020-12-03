using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using WaferBondingForceMeasureSystem.ApplicationModule.Common.FormCommon;
using WaferBondingForceMeasureSystem.ApplicationModule.Common.SerialPortCommon;
using WaferBondingForceMeasureSystem.ApplicationModule.ComProtocol;
using WaferBondingForceMeasureSystem.ApplicationModule.Log;
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
        PlanManage planManage = null;
        //private static WBFMSystem wbfmSystem;
        public WBFMSystem()
        {
            InitializeComponent();
            UIBLL.CustomizeMove<Panel, Label>(this.PanelTopic, this.LabelTopic, this);
            try
            {
                systemSetting = SystemSetting.Singleton();
                systemSetting.MyEvent += SerialPortInfo_Update;

                planManage = new PlanManage();
                planManage.MyEvent += new PlanManage.MyDelegate(LabelPlan_Add);
            }
            catch
            {

            }
        }

        private void SerialPortInfo_Update(object sender, EventArgs e)
        {
            lPSerialPort.Close();
            //lPSerialPort = new SerialPort();
            lPSerialPort.PortName = SPBLL.LPSerialPortName();
            lPSerialPort.Open();
            if(lPSerialPort.CtsHolding)
            {
                this.LabelCurrentOperation.Text = "就绪";
            }
        }

        private void LabelPlan_Add(object sender, EventArgs e)
        {
            this.LabelKnifePlanSelected.Text = planModel;
        }

        //public static WBFMSystem Singelton()
        //{
        //    if(wbfmSystem == null)
        //    {
        //        wbfmSystem = new WBFMSystem();
        //    }
        //    return wbfmSystem;
        //}

        private void PicBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static SerialPort lPSerialPort;
        delegate SerialPort LPSerialPortTran(SerialPort serialPort);

        static string planModel;
        public static string GetPlanModel(string _planModel)
        {
            planModel = _planModel;
            return planModel;
        }

        private void WBFMSystem_Load(object sender, EventArgs e)
        {
            UIBLL.CustomizeMove<Panel, Label>(this.PanelTopic, this.LabelTopic, this);

            try
            {
                lPSerialPort = new SerialPort();
                lPSerialPort.PortName = SPBLL.LPSerialPortName();
                lPSerialPort.Open();

                if (lPSerialPort.CtsHolding)
                {
                    byte[] Message = ComFormatPackage.ConstructCommandInfo(SETCommandNames.INITL);
                    lPSerialPort.Write(Message, 0, Message.Length);

                    byte[] qew = new byte[lPSerialPort.BytesToRead];
                    lPSerialPort.Read(qew, 0, qew.Length);
                    //this.TextBoxErrorLog.Text = Encoding.ASCII.GetString(qew);

                    LPSerialPortTran lPSerialPortTran = new LPSerialPortTran(SystemSetting.GetLPSerialPort);
                    lPSerialPortTran(lPSerialPort);
                }
                else
                {
                    this.LabelCurrentOperation.Text = "初始化失败！";
                    LogMessage logInfo = new LogMessage();
                    logInfo.OperationTime = DateTime.Now;
                    logInfo.ExceptionInfo = "初始化失败";
                    this.TextBoxErrorLog.Text += new LogFormat().ErrorFormat(logInfo);
                    MessageBox.Show("默认串口号错误！");
                }
            }
            catch
            {
                
            }
        }
   
        private void PicBoxScaling_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.PicBoxScaling.Image = Image.FromFile(AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "Images/TurnMax.png");
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                this.PicBoxScaling.Image = Image.FromFile(AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "Images/TurnNormal.png");
            }
        }

        #region WndProc

        //const int WM_NCHITTEST = 0x0084;
        //const int HTLEFT = 10;
        //const int HTRIGHT = 11;
        //const int HTTOP = 12;
        //const int HTTOPLEFT = 13;
        //const int HTTOPRIGHT = 14;
        //const int HTBOTTOM = 15;
        //const int HTBOTTOMLEFT = 0x10;
        //const int HTBOTTOMRIGHT = 17;

        //protected override void WndProc(ref Message m)
        //{
        //    base.WndProc(ref m);
        //    switch (m.Msg)
        //    {
        //        case WM_NCHITTEST:
        //            Point vPoint = new Point((int)m.LParam & 0xFFFF,
        //                (int)m.LParam >> 16 & 0xFFFF);
        //            vPoint = PointToClient(vPoint);
        //            if (vPoint.X <= 5)
        //            {
        //                if (vPoint.Y <= 5)
        //                {
        //                    m.Result = (IntPtr)HTTOPLEFT;
        //                }
        //                else if (vPoint.Y >= ClientSize.Height - 5)
        //                {
        //                    m.Result = (IntPtr)HTBOTTOMLEFT;
        //                }
        //                else
        //                {
        //                    m.Result = (IntPtr)HTLEFT;
        //                }
        //            }
        //            else if (vPoint.X >= ClientSize.Width - 5)
        //            {
        //                if (vPoint.Y <= 5)
        //                {
        //                    m.Result = (IntPtr)HTTOPRIGHT;
        //                }
        //                else if (vPoint.Y >= ClientSize.Height - 5)
        //                {
        //                    m.Result = (IntPtr)HTBOTTOMRIGHT;
        //                }
        //                else
        //                {
        //                    m.Result = (IntPtr)HTRIGHT;
        //                }
        //            }
        //            else if (vPoint.Y <= 5)
        //            {
        //                m.Result = (IntPtr)HTTOP;
        //            }
        //            else if (vPoint.Y >= ClientSize.Height - 5)
        //            {
        //                m.Result = (IntPtr)HTBOTTOM;
        //            }
        //            break;
        //    }
        //}

        //[DllImport("user32.dll")]
        //public static extern bool ReleaseCapture();

        //[DllImport("user32.dll")]
        //public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        //public const int WM_SYSCOMMAND = 0x0112;
        //public const int SC_MOVE = 0xF010;
        //public const int HTCAPTION = 0x0002;

        #endregion

        private void WBFMSystem_Move(object sender, EventArgs e)
        {
            //ReleaseCapture();
            //SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        public delegate ControlModel ControlInteraction(ControlModel _controlModel);

        private void WBFMSystem_Resize(object sender, EventArgs e)
        {
            ControlInteraction interaction = new ControlInteraction(new ErrorLog().ControlInteraction);
            interaction(new UIBLL().GetSizeData(this));
            ControlInteraction interaction2 = new ControlInteraction(AlgorithmSetting.Singleton().ControlInteraction);
            interaction2(new UIBLL().GetSizeData(this));

            this.PanelLog.Width = 239 * this.Width / 800;
            this.PanelControl.Width = 241 * this.Width / 800;
        }

        private void LabelAlgorithmSetting_Click(object sender, EventArgs e)
        {
            AlgorithmSetting.Singleton().ShowDialog();
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
            AlgorithmSetting.Singleton().ShowDialog();
        }

        private void PicBoxAlgorithmSetting_Click(object sender, EventArgs e)
        {
            AlgorithmSetting.Singleton().ShowDialog();
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
            planManage.Show();
        }

        private void LabelPlanManage_Click(object sender, EventArgs e)
        {
            planManage.Show();
        }

        private void LabelCalibrationSetting_Click(object sender, EventArgs e)
        {
            CalibrationSetting.Singleton().ShowDialog();
        }

        private void PicBoxCalibration_Click(object sender, EventArgs e)
        {
            CalibrationSetting.Singleton().ShowDialog();
        }

        private void BtnCorrection_Click(object sender, EventArgs e)
        {
            new Correction().ShowDialog();
        }

        private void BtnBoxOpen_Click(object sender, EventArgs e)
        {
            byte[] Message = ComFormatPackage.ConstructCommandInfo(EVTCommandNames.PODOF);
            lPSerialPort.Write(Message, 0, Message.Length);
        }
    }
}