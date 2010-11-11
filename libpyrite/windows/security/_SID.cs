using System;
using System.Text;
using System.Runtime.InteropServices;


namespace pyrite.windows.security {


    /// <summary>
    /// 
    /// </summary>
    [StructLayout( LayoutKind.Sequential )]
    public struct _SID {
        /// <summary>
        /// 
        /// </summary>
        internal const int ANYSIZE_ARRAY = 1;
        /// <summary>
        /// 
        /// </summary>
        public static readonly uint SizeOf = (uint)Marshal.SizeOf( typeof( _SID ) );


        /// <summary>
        /// 
        /// </summary>
        byte Revision;
        /// <summary>
        /// 
        /// </summary>
        byte SubAuthorityCount;
        /// <summary>
        /// 
        /// </summary>
        _SID_IDENTIFIER_AUTHORITY IdentifierAuthority;
        /// <summary>
        /// 
        /// </summary>
        [MarshalAs( UnmanagedType.ByValArray, SizeConst = ANYSIZE_ARRAY )]
        uint[] SubAuthority;
    }


}
