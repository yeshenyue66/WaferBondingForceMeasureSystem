using System.Runtime.InteropServices;

namespace WaferBondingForceMeasureSystem.Models.IntranetProtocol
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    struct IntranetTransInfoModel
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public byte[] Tag;
        [MarshalAs(UnmanagedType.I4)]
        public int Length;
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        //public string Value;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        public string LocalIPv4;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        public string CurrentUserName;
        [MarshalAs(UnmanagedType.I4)]
        public int LocalTransPort;

    }
}