using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace WaferBondingForceMeasureSystem.Models.Machines
{
    /// <summary>
    /// 功能描述    ：Class1  
    /// 创 建 者    ：Admin
    /// 创建日期    ：2020/11/17 10:16:14 
    /// </summary>
    class ManipulatorModel
    {
        private SerialPort serialPort;
        private string sendMessage;
        private string receiveMessage;

        public SerialPort SerialPort { get => serialPort; set => serialPort = value; }
        public string SendMessage { get => sendMessage; set => sendMessage = value; }
        public string ReceiveMessage { get => receiveMessage; set => receiveMessage = value; }

        public ManipulatorModel(SerialPort serialPort, string sendMessage)
        {
            this.serialPort = serialPort;
            this.sendMessage = sendMessage;
        }

        public ManipulatorModel(SerialPort serialPort)
        {
            this.serialPort = serialPort;
        }

        public ManipulatorModel()
        {
        }

        public ManipulatorModel(SerialPort serialPort, string sendMessage, string receiveMessage) : this(serialPort, sendMessage)
        {
            this.receiveMessage = receiveMessage;
        }
    }
}
