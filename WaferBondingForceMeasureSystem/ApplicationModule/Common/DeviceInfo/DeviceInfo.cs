using System;
using System.Net;
using System.Web;

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
        public static string GetDeviceName()
        {
            return Dns.GetHostName();
        }
        public static string GetDeviceUserName()
        {
            return Environment.UserName;
        }
        public static string GetIpv4Address()
        {
            string ipv4 = String.Empty;
            foreach (IPAddress ip in Dns.GetHostAddresses(GetClientIP()))
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    ipv4 = ip.ToString();
                    break;
                }
            }
            if (ipv4 != String.Empty)
            {
                return ipv4;
            }
            foreach (IPAddress ip in Dns.GetHostEntry(GetClientIP()).AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    ipv4 = ip.ToString();
                    break;
                }
            }
            return ipv4;
        }
        public static string GetClientIP()
        {
            if (null == HttpContext.Current.Request.ServerVariables["HTTP_VIA"])
            {
                return HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
            }
            else
            {
                return HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            }
        }
    }
}
