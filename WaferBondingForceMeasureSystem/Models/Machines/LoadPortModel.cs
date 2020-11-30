using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaferBondingForceMeasureSystem.Models.Machines
{
    /// <summary>
    /// 功能描述    ：Class1  
    /// 创 建 者    ：Admin
    /// 创建日期    ：2020/11/17 10:16:14 
    /// </summary>
    class LoadPortModel
    {

        #region 字段属性
        /// <summary>
        /// 连接串口
        /// </summary>
        private SerialPort serialPort;
        /// <summary>
        /// 
        /// </summary>
        private string sendMessage;
        /// <summary>
        /// 
        /// </summary>
        private string receiveMessage;

        /// <summary>
        /// 连接串口
        /// </summary>
        public SerialPort SerialPort { get => serialPort; set => serialPort = value; }
        public string SendMessage { get => sendMessage; set => sendMessage = value; }
        public string ReceiveMessage { get => receiveMessage; set => receiveMessage = value; }

        #endregion

        #region 构造方法
        public LoadPortModel(SerialPort serialPort, string sendMessage)
        {
            this.serialPort = serialPort;
            this.sendMessage = sendMessage;
        }

        public LoadPortModel(SerialPort serialPort)
        {
            this.serialPort = serialPort;
        }

        public LoadPortModel()
        {
        }

        public LoadPortModel(SerialPort serialPort, string sendMessage, string receiveMessage) : this(serialPort, sendMessage)
        {
            this.receiveMessage = receiveMessage;
        }
        #endregion

    }
}
