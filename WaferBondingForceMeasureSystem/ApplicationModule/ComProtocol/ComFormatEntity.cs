using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WaferBondingForceMeasureSystem.Util.DataType;
using WaferBondingForceMeasureSystem.Util.Enum;
using WaferBondingForceMeasureSystem.Util.String;
using WaferBondingForceMeasureSystem.ApplicationModule.ComProtocol;

namespace WaferBondingForceMeasureSystem.ApplicationModule.ComProtocol
{
    /// <summary>
    /// 功能描述    ：ComFormat
    /// 江苏埃洛德数据技术有限公司 2018-11-6
    /// 创 建 者    ：Admin
    /// 创建日期    ：2020/11/25 10:30:32 
    /// </summary>
    class ComFormatEntity
    {
        Enum value;
        private byte soh;
        private byte[] len;
        private byte[] adr;
        private byte[] cmd;
        public byte Soh { get => soh; set => soh = value; }
        public byte[] Len { get => len; set => len = new byte[2] { 0x00, (byte)(4 + CMDstr().Length) }; }
        public byte[] Adr { get => adr; set => adr = new byte[] { 0x30, 0x30 }; }
        public byte[] Cmd { get => cmd; set => cmd = Encoding.ASCII.GetBytes(CMDstr()); }

        public ComFormatEntity(Enum Value)
        {
            value = Value;
        }

        /// <summary>
        /// 返回SOH
        /// </summary>
        /// <param name="ProtocolSelected">选择协议类型</param>
        /// <returns></returns>
        public byte SOH(string ProtocolSelected)
        {
            byte bt = 0x01;
            switch (ProtocolSelected)
            {
                case "TDKA":
                    break;
                case "TDKB":
                    bt = TypeTranslate.StringToHexByte(EnumAttribute.GetDescription(SOHvalue.TDKB))[0];
                    break;
            }
            return bt;
        }

        public byte[] LEN()
        {
            int len = 4 + CMDstr().Length;
            return new byte[2] { 0x00, (byte)len };
        }

        public string ADRstr()
        {
            return "00";
        }

        public byte[] ADR()
        {
            return new byte[] { 0x30, 0x30 };
        }
        
        /// <summary>
        /// 获取整个cmd
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public string CMDstr()
        {
            return EnumAttribute.GetDescription(value);
            
        }

        public byte[] CMD()
        {
            return Encoding.ASCII.GetBytes(CMDstr());
        }

        public byte CSh()
        {
            int Checksum;
            Checksum = LEN()[1] + Str.GetCharSum(CMDstr()) + 96;
            string csh = Convert.ToString((byte)Checksum, 16);
            int length = csh.Length;
            char value = csh.ToCharArray()[length - 2];

            return (byte)value;
        }

        public byte CSl()
        {
            int Checksum;
            Checksum = LEN()[0] + LEN()[1] + Str.GetCharSum(CMDstr()) + 96;
            string csh = Convert.ToString((byte)Checksum, 16);
            int length = csh.Length;
            char value = csh.ToCharArray()[length - 1];

            return (byte)value;
        }

    }
}
