using System;
using System.Text;
using System.Runtime.InteropServices;


namespace pyrite.windows.security {


    /// <summary>
    /// 
    /// </summary>
    [StructLayout( LayoutKind.Sequential )]
    public struct _ACL {
        /// <summary>
        /// 
        /// </summary>
        public static readonly uint SizeOf = (uint)Marshal.SizeOf( typeof( _ACL ) );
        /// <summary>
        /// 
        /// </summary>
        public static readonly uint REVISION = 2;


        /// <summary>
        /// 
        /// </summary>
        public byte AclRevision;
        /// <summary>
        /// 
        /// </summary>
        public byte Sbz1;
        /// <summary>
        /// 
        /// </summary>
        public int AclSize;
        /// <summary>
        /// 
        /// </summary>
        public int AceCount;
        /// <summary>
        /// 
        /// </summary>
        public int Sbz2;
    }


}
