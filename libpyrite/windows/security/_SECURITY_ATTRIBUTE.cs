using System;
using System.Runtime.InteropServices;


namespace pyrite.windows.security {


    /// <summary>
    /// 
    /// </summary>
    [StructLayout( LayoutKind.Sequential )]
    public struct _SECURITY_ATTRIBUTES {
        /// <summary>
        /// 
        /// </summary>
        public static readonly uint SizeOf = (uint)Marshal.SizeOf( typeof( _SECURITY_ATTRIBUTES ) );


        /// <summary>
        /// 
        /// </summary>
        public int nLength;
        /// <summary>
        /// 
        /// </summary>
        public IntPtr lpSecurityDescriptor;
        /// <summary>
        /// 
        /// </summary>
        public int bInheritHandle;
    }


}
