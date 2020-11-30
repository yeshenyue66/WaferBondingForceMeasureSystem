using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaferBondingForceMeasureSystem.Models.ComProtocol.TDKA
{
    /// <summary>
    /// 功能描述    ：ComFormat
    /// 江苏埃洛德数据技术有限公司 2018-11-6
    /// 创 建 者    ：Admin
    /// 创建日期    ：2020/11/25 10:37:57 
    /// </summary>
    class ComFormat
    {
        /// <summary>
        /// Start of communication
        /// </summary>
        public byte SOH { get; set; }
        /// <summary>
        /// No.of bytes from ADR to CSl.(4-100)
        /// </summary>
        public byte[] LEN { get; set; }
        /// <summary>
        /// Destination address
        /// </summary>
        public byte[] ADR { get; set; }
        /// <summary>
        /// Command string and command parameters
        /// </summary>
        public string CMD { get; set; }
        /// <summary>
        /// Checksum: Upper digits
        /// </summary>
        public byte CSh { get; set; }
        /// <summary>
        /// Checksum: Lower digits
        /// </summary>
        public byte CSl { get; set; }
        /// <summary>
        /// End of communication
        /// </summary>
        public byte[] DEL { get; set; }
    }
}
