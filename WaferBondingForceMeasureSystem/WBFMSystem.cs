using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using WaferBondingForceMeasureSystem.ApplicationModule.Common.FormCommon;
using WaferBondingForceMeasureSystem.ApplicationModule.Common.SerialPortCommon;
using WaferBondingForceMeasureSystem.ApplicationModule.ComProtocol;
using WaferBondingForceMeasureSystem.ApplicationModule.EventHandler;
using WaferBondingForceMeasureSystem.ApplicationModule.Log;
using WaferBondingForceMeasureSystem.Models.Control;
using WaferBondingForceMeasureSystem.SettingForms;
using WaferBondingForceMeasureSystem.UserControls;

namespace WaferBondingForceMeasureSystem
{
    public partial class WBFMSystem : Form
    {
        private static WBFMSystem wbfmSystem;

        public static WBFMSystem Singleton()
        {
            if (wbfmSystem == null)
            {
                wbfmSystem = new WBFMSystem();
            }
            return wbfmSystem;
        }

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
        
        private WBFMSystem()
        {
            InitializeComponent();
            UIBLL.CustomizeMove(this.PanelTopic, this.LabelTopic, this);
        }

        public void SerialPortInfo_Update(object sender, SerialEventHandler.SerialPortEventArgs e)
        {
            //string thread = Thread.CurrentThread.Name;
            lPSerialPort.Close();
            //lPSerialPort.PortName = SPBLL.LPSerialPortName();
            lPSerialPort.PortName = e.Com_Loadport;
            lPSerialPort.Open();
            //lPSerialPort.WriteBufferSize = 1024;
            //lPSerialPort.ReadBufferSize = 1024;
            lPSerialPort.DataReceived += new SerialDataReceivedEventHandler(LPSerialPort_DataReceived);
            lPSerialPort.PinChanged += LPSerialPort_PinChanged;

            if(lPSerialPort.DsrHolding)
            {
                this.LabelCurrentOperation.Text = "就绪";
            }
        }

        private void LPSerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //this.TextBoxErrorLog.Text = "12314";

            byte[] Message = ComFormatPackage.ConstructCommandInfo(SETCommandNames.LON07);
            lPSerialPort.Write(Message, 0, Message.Length);

        }

        private void LPSerialPort_PinChanged(object sender, SerialPinChangedEventArgs e)
        {
            LogMessage logInfo = new LogMessage();
            logInfo.OperationTime = DateTime.Now;
            logInfo.ExceptionInfo = "串口信号异常";
            this.TextBoxErrorLog.Text += new LogFormat().ErrorFormat(logInfo);
        }

        public void LabelPlan_Add(object sender, PlanEventHandler.PlanConfirmEventArgs e)
        {
            this.LabelKnifePlanSelected.Text = e.PlanDescrip;
        }

        private void PicBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static SerialPort lPSerialPort;

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

                //Type type = lPSerialPort.GetType();
                //FieldInfo fieldInfo = type.GetField("defaultBaudRate", BindingFlags.NonPublic | BindingFlags.Instance);
                //int a = (int)fieldInfo.GetValue(lPSerialPort);

                lPSerialPort.PortName = SPBLL.LPSerialPortName();
                lPSerialPort.Open();

                if (lPSerialPort.DsrHolding)
                {
                    this.LabelCurrentOperation.Text = "就绪";

                    //byte[] ms = new byte[1024];
                    byte[] Message = ComFormatPackage.ConstructCommandInfo(GETCommandNames.MAPRD);
                    lPSerialPort.Write(Message, 0, Message.Length);
                    
                    //lPSerialPort.ReadTimeout = 1000;
                    //byte[] qew = new byte[1024];
                    //lPSerialPort.Read(qew, 0, qew.Length);

                    //byte[] qew2 = new byte[lPSerialPort.BytesToRead];
                    //lPSerialPort.Read(qew2, 0, qew2.Length);

                    lPSerialPort.DataReceived += BtnBoxOpen_Click;

                    //LPSerialPortTran lPSerialPortTran = new LPSerialPortTran(SystemSetting.GetLPSerialPort);
                    //lPSerialPortTran(lPSerialPort);
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
        /*
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
                    {
                        if (vPoint.Y <= 5)
                        {
                            m.Result = (IntPtr)HTTOPLEFT;
                        }
                        else if (vPoint.Y >= ClientSize.Height - 5)
                        {
                            m.Result = (IntPtr)HTBOTTOMLEFT;
                        }
                        else
                        {
                            m.Result = (IntPtr)HTLEFT;
                        }
                    }
                    else if (vPoint.X >= ClientSize.Width - 5)
                    {
                        if (vPoint.Y <= 5)
                        {
                            m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (vPoint.Y >= ClientSize.Height - 5)
                        {
                            m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                        else
                        {
                            m.Result = (IntPtr)HTRIGHT;
                        }
                    }
                    else if (vPoint.Y <= 5)
                    {
                        m.Result = (IntPtr)HTTOP;
                    }
                    else if (vPoint.Y >= ClientSize.Height - 5)
                    {
                        m.Result = (IntPtr)HTBOTTOM;
                    }
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
        */
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
            PlanManage.Singleton().ShowDialog();
        }

        private void LabelPlanManage_Click(object sender, EventArgs e)
        {
            PlanManage.Singleton().ShowDialog();
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

        private void WBFMSystem_Activated(object sender, EventArgs e)
        {
            UIBLL.CustomizeMove<Panel, Label>(this.PanelTopic, this.LabelTopic, this);
        }
    }
}