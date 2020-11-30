using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaferBondingForceMeasureSystem.ApplicationModule.Common.SerialPortCommon
{
    /// <summary>
    /// 功能描述    ：Class1  
    /// 创 建 者    ：Admin
    /// 创建日期    ：2020/11/17 10:16:14 
    /// </summary>
    interface ISPBLL
    {
        /// <summary>
        /// 获取串口列表
        /// </summary>
        /// <returns>返回串口列表</returns>
         List<StringBuilder> GetSerialPorts();
    }
}
