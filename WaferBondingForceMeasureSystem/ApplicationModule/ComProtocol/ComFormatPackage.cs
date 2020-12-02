using System;
using System.Text;

using WaferBondingForceMeasureSystem.Models.ComProtocol;

namespace WaferBondingForceMeasureSystem.ApplicationModule.ComProtocol
{
    /// <summary>
    /// 功能描述    ：ComFormatPackage
    /// 江苏埃洛德数据技术有限公司 2018-11-6
    /// 创 建 者    ：Admin
    /// 创建日期    ：2020/11/30 15:06:01 
    /// </summary>
    class ComFormatPackage
    {
        public static byte[] Construct()
        {
            return default;
        }
        public static ComFormat ParseCommandInfo(byte[] buffer)
        {
            int ComStr_length;
            int currentIndex = 0;
            byte[] temp = null;
            ComFormat comFormat = new ComFormat();
            
            if(buffer[currentIndex] == 0x01 && buffer.Length > 0)
            {
                comFormat.SOH = buffer[currentIndex];
                currentIndex += 1;
            }
            if(buffer[currentIndex] == 0x30)
            {
                int strlength = buffer[currentIndex++];
                ComStr_length = buffer.Length - 8;
                if (strlength == ComStr_length)
                {
                    Array.Copy(buffer, currentIndex++, temp, 0, ComStr_length);
                    comFormat.CMD = Encoding.ASCII.GetString(temp);
                }
            }
            return comFormat;
        }
    }
}