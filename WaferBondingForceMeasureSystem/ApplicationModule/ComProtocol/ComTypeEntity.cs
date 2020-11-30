using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace WaferBondingForceMeasureSystem.ApplicationModule.ComProtocol
{
    /// <summary>
    /// 功能描述    ：CommandType
    /// 江苏埃洛德数据技术有限公司 2018-11-6
    /// 创 建 者    ：Admin
    /// 创建日期    ：2020/11/25 8:30:28 
    /// </summary>
    class CommandType
    {
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
            TCH = 6
        }
    }
}
