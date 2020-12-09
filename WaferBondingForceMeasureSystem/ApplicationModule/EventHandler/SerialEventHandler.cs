using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaferBondingForceMeasureSystem.SettingForms;

namespace WaferBondingForceMeasureSystem.ApplicationModule.EventHandler
{
    /// <summary>
    /// 功能描述    ：SerialEventHandler
    /// 江苏埃洛德数据技术有限公司 2018-11-6
    /// 创 建 者    ：Admin
    /// 创建日期    ：2020/12/7 14:22:28 
    /// </summary>
    public class SerialEventHandler
    {
        public delegate void SerialPortEventHandler(object sender, SerialPortEventArgs e);
        public event SerialPortEventHandler Serial;

        public class SerialPortEventArgs : EventArgs
        {
            public readonly string Com_Loadport;
            public readonly string Com_Manipulator;

            public SerialPortEventArgs(string com_Loadport, string com_Manipulator)
            {
                this.Com_Loadport = com_Loadport;
                this.Com_Manipulator = com_Manipulator;
            }
        }

        protected virtual void SerialPortTranslate(SerialPortEventArgs e)
        {
            Serial?.Invoke(this, e);
        }

        public void Translation(string com_Loadport, string com_Manipulator)
        {
            SerialPortEventArgs e = new SerialPortEventArgs(com_Loadport, com_Manipulator);
            SerialPortTranslate(e);
        }
    }
}
