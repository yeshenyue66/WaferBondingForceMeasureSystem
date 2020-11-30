using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaferBondingForceMeasureSystem.Util.DataType
{
    /// <summary>
    /// 功能描述    ：TypeTranslate
    /// 江苏埃洛德数据技术有限公司 2018-11-6
    /// 创 建 者    ：Admin
    /// 创建日期    ：2020/11/25 14:22:41 
    /// </summary>
    class TypeTranslate
    {
        public static byte[] StringToHexByte(string str)
        {
            byte[] bt = Encoding.Default.GetBytes(str);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in bt)
            {
                sb.Append(b.ToString("X2"));
            }
            string strbyte = sb.ToString();
            byte[] returnBytes = new byte[strbyte.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
            {
                returnBytes[i] = Convert.ToByte(strbyte.Substring(i * 2, 2));
                
            }
            return returnBytes;
        }


    }
}
