using System;
using System.Runtime.InteropServices;

namespace WaferBondingForceMeasureSystem.Util.Struct
{
    /// <summary>
    /// 功能描述    ：StructConvert
    /// 江苏埃洛德数据技术有限公司 2018-11-6
    /// 创 建 者    ：Admin
    /// 创建日期    ：2021/1/5 16:27:55 
    /// </summary>
    class StructConvert
    {
        public static byte[] StructToBytes(object structObj)
        {
            int size = Marshal.SizeOf(structObj);
            IntPtr buffer = Marshal.AllocHGlobal(size);
            try
            {
                Marshal.StructureToPtr(structObj, buffer, false);
                byte[] bytes = new byte[size];
                Marshal.Copy(buffer, bytes, 0, size);
                return bytes;
            }
            finally
            {
                Marshal.FreeHGlobal(buffer);
            }
        }
    }
}
