using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WaferBondingForceMeasureSystem.ApplicationModule.ComProtocol
{
    /// <summary>
    /// 功能描述    ：CommandName
    /// 江苏埃洛德数据技术有限公司 2018-11-6
    /// 创 建 者    ：Admin
    /// 创建日期    ：2020/11/25 8:43:35 
    /// </summary>

    /// <summary>
    /// CommandType:SET对应的CommandName
    /// </summary>
    enum SETCommandNames
    {
        #region SETCommand
        /// <summary>
        /// Error reset
        /// </summary>
        [Description("SET:RESET;")]
        RESET = 0,
        /// <summary>
        /// Program initialization (internal status initialization)
        /// </summary>
        [Description("SET:INITL;")]
        INITL = 1,
        /// <summary>
        /// LOAD indicator: ON
        /// </summary>
        [Description("SET:LPLODLON01;")]
        LPLODLON01 = 2,
        /// <summary>
        /// LOAD indicator: Flashes
        /// </summary>
        [Description("SET:BLLODLBL01;")]
        BLLODLBL01 = 3,
        /// <summary>
        /// LOAD indicator: OFF
        /// </summary>
        [Description("SET:LOLODLOF01;")]
        LOLODLOF01 = 4,
        /// <summary>
        /// UNLOAD indicator: ON
        /// </summary>
        [Description("SET:LPULDLON02;")]
        LPULDLON02 = 5,
        /// <summary>
        /// UNLOAD indicator: Flashes
        /// </summary>
        [Description("SET:BLULDLBL02;")]
        BLULDLBL02 = 6,
        /// <summary>
        /// UNLOAD indicator: OFF
        /// </summary>
        [Description("SET:LOULDLOF02;")]
        LOULDLOF02 = 7,
        /// <summary>
        /// OP. ACCESS indicator: ON
        /// </summary>
        [Description("SET:LPMSWLON03;")]
        LPMSWLON03 = 8,
        /// <summary>
        /// OP. ACCESS indicator: Flashes
        /// </summary>
        [Description("SET:BLMSWLBL03;")]
        BLMSWLBL03 = 9,
        /// <summary>
        /// OP. ACCESS indicator: OFF
        /// </summary>
        [Description("SET:LOMSWLOF03;")]
        LOMSWLOF03 = 10,
        /// <summary>
        /// PRESENCE indicator: ON
        /// </summary>
        [Description("SET:LPCONLON04;")]
        LPCONLON04 = 11,
        /// <summary>
        /// PRESENCE indicator: Flashes
        /// </summary>
        [Description("SET:BLCONLBL04;")]
        BLCONLBL04 = 12,
        /// <summary>
        /// PRESENCE indicator: OFF
        /// </summary>
        [Description("SET:LOCONLOF04;")]
        LOCONLOF04 = 13,
        /// <summary>
        /// PLACEMENT indicator: ON
        /// </summary>
        [Description("SET:LPCSTLON05;")]
        LPCSTLON05 = 14,
        /// <summary>
        /// PLACEMENT indicator: Flashes
        /// </summary>
        [Description("SET:BLCSTLBL05;")]
        BLCSTLBL05 = 15,
        /// <summary>
        /// PLACEMENT indicator: OFF
        /// </summary>
        [Description("SET:LOCSTLOF05;")]
        LOCSTLOF05 = 16,
        /// <summary>
        /// STATUS 1 indicator: ON
        /// </summary>
        [Description("SET:LON07;")]
        LON07 = 17,
        /// <summary>
        /// STATUS 1 indicator: Flashes
        /// </summary>
        [Description("SET:LBL07;")]
        LBL07 = 18,
        /// <summary>
        /// STATUS 1 indicator: OFF
        /// </summary>
        [Description("SET:LOF07;")]
        LOF07 = 19,
        /// <summary>
        /// STATUS 2 indicator: ON
        /// </summary>
        [Description("SET:LON08;")]
        LON08 = 20,
        /// <summary>
        /// STATUS 2 indicator: Flashes
        /// </summary>
        [Description("SET:LBL08;")]
        LBL08 = 21,
        /// <summary>
        /// STATUS 2 indicator: OFF
        /// </summary>
        [Description("SET:LOF08;")]
        LOF08 = 22,
        #endregion
    }

    /// <summary>
    /// CommandType:MOD对应的CommandName
    /// </summary>
    enum MODCommandNames
    {
        /// <summary>
        /// Changes to the online mode
        /// </summary>
        [Description("MOD:ONMGV;")]
        ONMGV = 0,
        /// <summary>
        /// Changes to the maintenance mode
        /// </summary>
        [Description("MOD:MENTE;")]
        MENTE = 1,
        /// <summary>
        /// Changes to the teaching mode
        /// </summary>
        [Description("MOD:TEACH;")]
        TEACH = 2,
    }

    /// <summary>
    /// CommandType:GET对应的CommandName
    /// </summary>
    enum GETCommandNames
    {
        /// <summary>
        /// Checks the status
        /// </summary>
        [Description("GET:STATE;")]
        STATE = 0,
        /// <summary>
        /// Checks the version
        /// </summary>
        [Description("GET:VERSN;")]
        VERSN = 1,
        /// <summary>
        /// Reports the indicator status
        /// </summary>
        [Description("GET:LEDST;")]
        LEDST = 2,
        /// <summary>
        /// Wafer search data (descending order)
        /// </summary>
        [Description("GET:MAPDT;")]
        MAPDT = 3,
        /// <summary>
        /// Wafer search data (ascending order)
        /// </summary>
        [Description("GET:MAPRD;")]
        MAPRD = 4,
        /// <summary>
        /// Wafer quantity check
        /// </summary>
        [Description("GET:WFCNT;")]
        WFCNT = 5,
    }

    /// <summary>
    /// CommandType:FIN对应的CommandName
    /// </summary>
    enum FINCommandNames
    {

    }

    /// <summary>
    /// CommandType:MOV对应的CommandName
    /// </summary>
    enum MOVCommandNames
    {
        #region Combined
        /// <summary>
        /// Moves the FOUP to the initial position
        /// </summary>
        [Description("MOV:ORGSH;")]
        ORGSH = 0,
        /// <summary>
        /// Aborts the operation and moves the FOUP to the initial position
        /// </summary>
        [Description("MOV:ABORG;")]
        ABORG = 1,
        /// <summary>
        /// Loads the FOUP (transfers the FOUP to the transfer unit)
        /// </summary>
        [Description("MOV:CLOAD;")]
        CLOAD = 2,
        /// <summary>
        /// Loads the FOUP (same as CLOAD) to the point where the system is ready to open the door
        /// </summary>
        [Description("MOV:CLDDK;")]
        CLDDK = 3,
        /// <summary>
        /// Clamps the FOUP and moves the FOUP to the Y-axis docking position
        /// </summary>
        [Description("MOV:CLDYD;")]
        CLDYD = 4,
        /// <summary>
        /// Continues loading the FOUP after CLDDK
        /// </summary>
        [Description("MOV:CLDOP;")]
        CLDOP = 5,
        /// <summary>
        /// Maps and loads the FOUP
        /// </summary>
        [Description("MOV:CLDMP;")]
        CLDMP = 6,
        /// <summary>
        /// Continues mapping and loading the FOUP after CLDDK
        /// </summary>
        [Description("MOV:CLMPO;")]
        CLMPO = 7,
        /// <summary>
        /// Unloads the FOUP (at the ejection position)
        /// </summary>
        [Description("MOV:CULOD;")]
        CULOD = 8,
        /// <summary>
        /// Closes the door (same as CULOD)
        /// </summary>
        [Description("MOV:CULDK;")]
        CULDK = 9,
        /// <summary>
        /// Undocks the FOUP (while being clamped) after CULDK
        /// </summary>
        [Description("MOV:CUDCL;")]
        CUDCL = 10,
        /// <summary>
        /// Unloads the FOUP after CULDK
        /// </summary>
        [Description("MOV:CUDNC;")]
        CUDNC = 11,
        /// <summary>
        /// Unloads the FOUP to the docking status
        /// </summary>
        [Description("MOV:CULYD;")]
        CULYD = 12,
        /// <summary>
        /// Unloads the FOUP to the point where the system can release (unclamp) the FOUP
        /// </summary>
        [Description("MOV:CULFC;")]
        CULFC = 13,
        /// <summary>
        /// Maps and unloads the FOUP from the loaded status
        /// </summary>
        [Description("MOV:CUDMP;")]
        CUDMP = 14,
        /// <summary>
        /// Maps the FOUP and closes the door from the loaded status
        /// </summary>
        [Description("MOV:CUMDK;")]
        CUMDK = 15,
        /// <summary>
        /// Maps the FOUP to the before-unclamp status from the loaded status
        /// </summary>
        [Description("MOV:CUMFC;")]
        CUMFC = 16,
        /// <summary>
        /// Maps the FOUP while being loaded
        /// </summary>
        [Description("MOV:MAPDO;")]
        MAPDO = 17,
        /// <summary>
        /// Resumes the interrupted mapping
        /// </summary>
        [Description("MOV:REMAP;")]
        REMAP = 18,
        #endregion

        #region Individual
        /// <summary>
        /// FOUP clamp: Open
        /// </summary>
        [Description("MOV:PODOP;")]
        PODOP = 19,
        /// <summary>
        /// FOUP clamp: Close
        /// </summary>
        [Description("MOV:PODCL;")]
        PODCL = 20,
        /// <summary>
        /// Vacuum on
        /// </summary>
        [Description("MOV:VACON;")]
        VACON = 21,
        /// <summary>
        /// Vacuum off
        /// </summary>
        [Description("MOV:VACOF;")]
        VACOF = 22,
        /// <summary>
        /// Latch key: Open (Unlatches the FOUP door.)
        /// </summary>
        [Description("MOV:DOROP;")]
        DOROP = 23,
        /// <summary>
        /// Latch key: Close (Latches the FOUP door.)
        /// </summary>
        [Description("MOV:DORCL;")]
        DORCL = 24,
        /// <summary>
        /// Mapper arm: Open
        /// </summary>
        [Description("MOV:MAPOP;")]
        MAPOP = 25,
        /// <summary>
        /// Mapper arm: Close
        /// </summary>
        [Description("MOV:MAPCL;")]
        MAPCL = 26,
        /// <summary>
        /// Move to Z-axis up position (door open position)
        /// </summary>
        [Description("MOV:ZDRUP;")]
        ZDRUP = 27,
        /// <summary>
        /// Move to Z-axis down position (transport unit handover possible position)
        /// </summary>
        [Description("MOV:ZDRDW;")]
        ZDRDW = 28,
        /// <summary>
        /// Lower to Z-axis mapping end position and conduct mapping
        /// </summary>
        [Description("MOV:ZDRMP;")]
        ZDRMP = 29,
        /// <summary>
        /// Move the mapper to the start position
        /// </summary>
        [Description("MOV:ZMPST;")]
        ZMPST = 30,
        /// <summary>
        /// Move the mapper to the wait position
        /// </summary>
        [Description("MOV:ZMPED;")]
        ZMPED = 31,
        /// <summary>
        /// Mapper stopper on
        /// </summary>
        [Description("MOV:MSTON;")]
        MSTON = 32,
        /// <summary>
        /// Mapper stopper off
        /// </summary>
        [Description("MOV:MSTOF;")]
        MSTOF = 33,
        /// <summary>
        /// Move to Y-axis undock position
        /// </summary>
        [Description("MOV:YWAIT;")]
        YWAIT = 34,
        /// <summary>
        /// Move to Y-axis dock position
        /// </summary>
        [Description("MOV:YDOOR;")]
        YDOOR = 35,
        /// <summary>
        /// Move to door open position
        /// </summary>
        [Description("MOV:DORBK;")]
        DORBK = 36,
        /// <summary>
        /// Move to door close position
        /// </summary>
        [Description("MOV:DORFW;")]
        DORFW = 37,
        #endregion

        #region Control
        /// <summary>
        /// Retry during recoverable error
        /// </summary>
        [Description("MOV:RETRY;")]
        RETRY = 38,
        /// <summary>
        /// Immediate stop and command abort
        /// </summary>
        [Description("MOV:STOP_;")]
        STOP_ = 39,
        /// <summary>
        /// Immediate stop
        /// </summary>
        [Description("MOV:PAUSE;")]
        PAUSE = 40,
        /// <summary>
        /// Command abort
        /// </summary>
        [Description("MOV:ABORT;")]
        ABORT = 41,
        /// <summary>
        /// Resume operation
        /// </summary>
        [Description("MOV:RESUM;")]
        RESUM = 42,
        #endregion
    }

    enum EVTCommandNames
    {
        [Description("INF:PODON;")]
        PODON = 1,
    }
}
