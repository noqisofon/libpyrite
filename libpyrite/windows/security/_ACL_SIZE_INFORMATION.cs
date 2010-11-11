    using System;
using System.Text;
using System.Runtime.InteropServices;


namespace pyrite.windows.security {


    /// <summary>
    /// 
    /// </summary>
    [StructLayout( LayoutKind.Sequential )]
    public struct _ACL_SIZE_INFORMATION {
        /// <summary>
        /// 
        /// </summary>
        public static readonly uint SizeOf = (uint)Marshal.SizeOf( typeof( _ACL_SIZE_INFORMATION ) );


        /// <summary>
        /// 
        /// </summary>
        public uint AceCount;
        /// <summary>
        /// 
        /// </summary>
        public uint AclBytesInUse;
        /// <summary>
        /// 
        /// </summary>
        public uint AclBytesFree;
    }


}
