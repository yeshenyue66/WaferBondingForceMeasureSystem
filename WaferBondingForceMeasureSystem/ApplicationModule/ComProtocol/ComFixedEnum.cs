using System;
using System.ComponentModel;

namespace WaferBondingForceMeasureSystem.ApplicationModule.ComProtocol
{
    public enum SOHvalue
    {
        /// <summary>
        /// TDKA SOH value
        /// </summary>
        [Description("")]
        TDKA = 0,
        /// <summary>
        /// TDKB SOH value
        /// </summary>
        [Description("s")]
        TDKB = 1
    }
    public enum DEL
    {
        [Description("0x03")]
        ETX = 0,
        CR = 1,
        CRLF = 2
    }
}