using System;
using System.Net;

namespace WaferBondingForceMeasureSystem.ApplicationModule.Common.DeviceInfo
{
    /// <summary>
    /// 功能描述    ：DeviceInfo
    /// 江苏埃洛德数据技术有限公司 2018-11-6
    /// 创 建 者    ：Admin
    /// 创建日期    ：2020/12/25 15:53:28 
    /// </summary>
    class DeviceInfo
    {
        public static string DeviceName()
        {
            return Dns.GetHostName();
        }
        public static string DeviceUserName()
        {
            return Environment.UserName;
        }
    }
}
