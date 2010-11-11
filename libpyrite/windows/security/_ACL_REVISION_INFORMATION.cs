using System;
using System.Text;
using System.Runtime.InteropServices;


namespace pyrite.windows.security {


    /// <summary>
    /// 
    /// </summary>
    public struct _ACL_REVISION_INFORMATION {
        /// <summary>
        /// 
        /// </summary>
        public static readonly uint SizeOf = (uint)Marshal.SizeOf( typeof( _ACL_REVISION_INFORMATION ) );


        /// <summary>
        /// 
        /// </summary>
        public uint AclRevision;
    }
}
