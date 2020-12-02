using System.ComponentModel;

namespace WaferBondingForceMeasureSystem.ApplicationModule.ComProtocol
{
    enum Protocol
    {
        TDKA = 0,
        TDKB = 1,
    }

    enum Commandtypes
    {
        /// <summary>
        /// Initialization setting command
        /// </summary>
        [Description("SET")]
        SET = 0,
        /// <summary>
        /// Operation mode setting command
        /// </summary>
        [Description("MOD")]
        MOD = 1,
        /// <summary>
        /// Status acquisition command
        /// </summary>
        [Description("GET")]
        GET = 2,
        /// <summary>
        /// Normal reception command
        /// </summary>
        [Description("FIN")]
        FIN = 3,
        /// <summary>
        /// Operation command
        /// </summary>
        [Description("MOV")]
        MOV = 4,
        /// <summary>
        /// Operation command
        /// </summary>
        [Description("EVT")]
        EVT = 5,
        /// <summary>
        /// Operation command
        /// </summary>
        [Description("TCH")]
        TCH = 6,
    }

    enum MessageDel
    {
        ETX = 0,
        CR = 1,
        CRLF = 2,
    }
}
