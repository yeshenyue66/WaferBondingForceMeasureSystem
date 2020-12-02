using System;
using System.Collections.Generic;
using System.Linq;
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
        public static Protocol protocol = Protocol.TDKA;
        public static MessageDel del = MessageDel.ETX;

        /// <summary>
        /// Message打包
        /// </summary>
        /// <param name="cmd">传输命令</param>
        /// <returns></returns>
        public static byte[] ConstructCommandInfo(Enum cmd)
        {
            ComFormatEntity comFormatEntity = new ComFormatEntity(cmd);
            List<byte> entity = new List<byte>();
            switch (protocol)
            {
                case Protocol.TDKA:
                    entity.Add(comFormatEntity.SOH(protocol));
                    entity.AddRange(comFormatEntity.LEN());
                    entity.AddRange(comFormatEntity.ADR());
                    entity.AddRange(comFormatEntity.CMD());
                    entity.Add(comFormatEntity.CSh());
                    entity.Add(comFormatEntity.CSl());
                    entity.Add(comFormatEntity.DEL(del)[0]);
                    break;
                case Protocol.TDKB:
                    entity.Add(comFormatEntity.SOH(protocol));
                    entity.AddRange(comFormatEntity.LEN());
                    entity.AddRange(comFormatEntity.ADR());
                    entity.AddRange(comFormatEntity.CMD());
                    entity.Add(comFormatEntity.CSh());
                    entity.Add(comFormatEntity.CSl());
                    entity.Add(comFormatEntity.DEL(del)[0]);
                    break;
            }

            return entity.ToArray();
        }

        /// <summary>
        /// Message解码
        /// </summary>
        /// <param name="buffer">获取报文</param>
        /// <returns></returns>
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