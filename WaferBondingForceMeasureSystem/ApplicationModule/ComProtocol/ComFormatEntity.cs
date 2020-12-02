using System;
using System.Text;

using WaferBondingForceMeasureSystem.Util.DataType;
using WaferBondingForceMeasureSystem.Util.Enum;
using WaferBondingForceMeasureSystem.Util.String;

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
        public byte Soh { get => soh; set => soh = value; }

        public ComFormatEntity(Enum Value)
        {
            value = Value;
        }

        /// <summary>
        /// 返回SOH
        /// </summary>
        /// <param name="ProtocolSelected">选择协议类型</param>
        /// <returns></returns>
        public byte SOH(Protocol protocol)
        {
            byte soh = 0x01;
            switch (protocol)
            {
                case Protocol.TDKA:
                    break;
                case Protocol.TDKB:
                    soh = TypeTranslate.StringToHexByte(EnumAttribute.GetDescription(SOHvalue.TDKB))[0];
                    break;
            }
            return soh;
        }

        /// <summary>
        /// 返回LEN
        /// </summary>
        /// <returns></returns>
        public byte[] LEN()
        {
            int len = 4 + CMDstr().Length;
            return new byte[2] { 0x00, (byte)len };
        }

        /// <summary>
        /// 返回默认串口连接的ADR字符串
        /// </summary>
        /// <returns></returns>
        public string ADRstr()
        {
            return "00";
        }

        /// <summary>
        /// 返回默认串口连接的ADR
        /// </summary>
        /// <returns></returns>
        public byte[] ADR()
        {
            return new byte[] { 0x30, 0x30 };
        }

        /// <summary>
        /// 返回cmd字符串
        /// </summary>
        /// <returns></returns>
        public string CMDstr()
        {
            return EnumAttribute.GetDescription(value);
        }

        /// <summary>
        /// 返回cmd
        /// </summary>
        /// <returns></returns>
        public byte[] CMD()
        {
            return Encoding.ASCII.GetBytes(CMDstr());
        }

        /// <summary>
        /// 返回CSh
        /// </summary>
        /// <returns></returns>
        public byte CSh()
        {
            int Checksum;
            Checksum = LEN()[1] + Str.GetCharSum(CMDstr()) + 96;
            string csh = Convert.ToString((byte)Checksum, 16);
            int length = csh.Length;
            char value = csh.ToCharArray()[length - 2];
            return (byte)value;
        }

        /// <summary>
        /// 返回CSl
        /// </summary>
        /// <returns></returns>
        public byte CSl()
        {
            int Checksum;
            Checksum = LEN()[0] + LEN()[1] + Str.GetCharSum(CMDstr()) + 96;
            string csh = Convert.ToString((byte)Checksum, 16);
            int length = csh.Length;
            char value = csh.ToCharArray()[length - 1];
            return (byte)value;
        }

        /// <summary>
        /// 返回DEL
        /// </summary>
        /// <param name="messageDel">DEL类型</param>
        /// <returns></returns>
        public byte[] DEL(MessageDel messageDel)
        {
            byte[] del = new byte[2];
            switch(messageDel)
            {
                case MessageDel.ETX:
                    del[0] = 0x03;
                    break;
                case MessageDel.CR:
                    del[0] = 0x0D;
                    break;
                case MessageDel.CRLF:
                    del = new byte[] { 0x0D, 0x0A };
                    break;
            }
            return del;
        }
    }
}
