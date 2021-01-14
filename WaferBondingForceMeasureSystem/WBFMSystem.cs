using System;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using WaferBondingForceMeasureSystem.ApplicationModule.Common.DeviceInfo;
using WaferBondingForceMeasureSystem.ApplicationModule.Common.FormCommon;
using WaferBondingForceMeasureSystem.ApplicationModule.Common.SerialPortCommon;
using WaferBondingForceMeasureSystem.ApplicationModule.ComProtocol;
using WaferBondingForceMeasureSystem.ApplicationModule.EventHandler;
using WaferBondingForceMeasureSystem.ApplicationModule.Log;
using WaferBondingForceMeasureSystem.Models.Control;
using WaferBondingForceMeasureSystem.Models.IntranetProtocol;
using WaferBondingForceMeasureSystem.SettingForms;
using WaferBondingForceMeasureSystem.UserControls;
using WaferBondingForceMeasureSystem.Util.Struct;

namespace WaferBondingForceMeasureSystem
{
    public partial class WBFMSystem : Form
    {
        private static WBFMSystem wbfmSystem;
        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

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

            try
            {
                //socket.Connect("192.168.2.34", 3340);
                socket.Connect("127.0.0.1", 3340);
                if (socket.Connected)
                {
                    this.LabelConnectInfo.Text = "连接到内网主机";
                    const int BUFFER_SIZE = 1024;
                    byte[] readBuff = new byte[BUFFER_SIZE];
                    IAsyncResult count = socket.BeginReceive(readBuff, 0, readBuff.Length, SocketFlags.None, new AsyncCallback(LabelConnectInfo_Update), readBuff);
                    string res = Encoding.UTF8.GetString(readBuff);
                }
            }
            catch
            {
                this.LabelConnectInfo.Text = "未连接到内网";
                //IPAddress iPAddress = IPAddress.Parse("127.0.0.1");
                //IPEndPoint endPoint = new IPEndPoint(iPAddress, 3389);
                //socket.BeginConnect(endPoint, new AsyncCallback(ConnectCallback1), null);
            }
        }
        public static ManualResetEvent allDone = new ManualResetEvent(false);

        private void ConnectCallback1(IAsyncResult ar)
        {
            allDone.Set();
            //socket = (Socket)ar.AsyncState;
            this.Invoke(new EventHandler(delegate
            {
                LabelConnectInfo.Text += "ReConnecting";
            }));
            socket.EndConnect(ar);
        }
        delegate void LUEventHandler(string str);

        private void LabelConnectInfo_Update(IAsyncResult ar)
        {
            byte[] readBuff = (byte[])ar.AsyncState;
            this.Invoke(new EventHandler(delegate
            {
                LabelConnectInfo.Text += Encoding.UTF8.GetString(readBuff);
            }));
            try
            {
                socket.EndReceive(ar);
            }
            catch
            {
                this.Invoke(new EventHandler(delegate
                {
                    LabelConnectInfo.Text = "未连接到内网";
                }));
            }
        }

        public void SerialPortInfo_Update(object sender, SerialEventHandler.SerialPortEventArgs e)
        {
            lPSerialPort.Close();
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
            byte[] Message = ComFormatPackage.ConstructCommandInfo(SETCommandNames.LON07);
            lPSerialPort.Write(Message, 0, Message.Length);
        }

        private void LPSerialPort_PinChanged(object sender, SerialPinChangedEventArgs e)
        {
            LogMessage logInfo = new LogMessage
            {
                OperationTime = DateTime.Now,
                ExceptionInfo = "串口信号异常"
            };
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
            //if (this.LabelConnectInfo.Text == "未连接到内网") 
            //{
            //    IPAddress iPAddress = IPAddress.Parse("127.0.0.1");
            //    IPEndPoint endPoint = new IPEndPoint(iPAddress, 3340);
            //    socket.Connect(endPoint);
            //    //socket.BeginConnect(endPoint, new AsyncCallback(ConnectCallback1), null);
            //    //socket.BeginConnect(endPoint, new AsyncCallback((ar) =>
            //    //{
            //    //    this.Invoke(new EventHandler(delegate
            //    //    {
            //    //        LabelConnectInfo.Text += "ReConnecting..";
            //    //    }));
            //    //}), null);
            //}

            //byte[] _deviceName = Encoding.UTF8.GetBytes(DeviceInfo.DeviceName());
            //socket.Send(_deviceName, 0, _deviceName.Length, SocketFlags.None);

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

        private void button1_Click(object sender, EventArgs e)
        { 
            //byte[] _deviceName = Encoding.UTF8.GetBytes(DeviceInfo.GetDeviceName());
            ////List<ArraySegment<byte>> ad = new List<ArraySegment<byte>>();
            ////ArraySegment<byte> item = Encoding.UTF8.GetBytes(DeviceInfo.GetDeviceName());
            ////ad.Add(_deviceName);

            //IntranetTransInfoModel localDeviceInfoModel = new IntranetTransInfoModel();
            ////localDeviceInfoModel.Value = DeviceInfo.GetDeviceName();
            //string localIP;
            //using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            //{
            //    socket.Connect("8.8.8.8", 65530);
            //    IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
            //    localIP = endPoint.Address.ToString();
            //}
            ////localDeviceInfoModel.Value = localIP;
            //localDeviceInfoModel.Tag = new byte[] { 0x01 };
            ////localDeviceInfoModel.Length = Convert.ToByte(localDeviceInfoModel.Value.Length);
            //localDeviceInfoModel.LocalIPv4 = localIP;
            ////localDeviceInfoModel.LocalTransPort = 4567;
            //localDeviceInfoModel.CurrentUserName = "2344";
            //byte[] Message = StructConvert.StructToBytes(localDeviceInfoModel);

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            MemoryStream memoryStream = new MemoryStream();
            ABC aBC = new ABC();
            aBC.CurrentUserName = "name";
            aBC.LocalTransPort = 1234;
            binaryFormatter.Serialize(memoryStream, aBC);
            byte[] abc = memoryStream.ToArray();

            socket.Send(abc);
            memoryStream.Close();
            //socket.Send(_deviceName, 0, _deviceName.Length, SocketFlags.None);
        }
    }
    [Serializable]
    class ABC
    {
        public string CurrentUserName;
        public int LocalTransPort;
    }
}