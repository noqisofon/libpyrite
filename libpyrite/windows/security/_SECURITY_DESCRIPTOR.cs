using System;
using System.Text;
using System.Runtime.InteropServices;


namespace pyrite.windows.security {


    /// <summary>
    /// 
    /// </summary>
    [StructLayoutAttribute( LayoutKind.Sequential )]
    public struct _SECURITY_DESCRIPTOR {
        /// <summary>
        /// 
        /// </summary>
        public static readonly uint SizeOf = (uint)Marshal.SizeOf( typeof( _SECURITY_DESCRIPTOR ) );
        /// <summary>
        /// InitializeSecurityDescriptor() で使うデフォルトリビジョンです。
        /// </summary>
        public const uint REVISION = 1;
        /// <summary>
        /// 
        /// </summary>
        public static readonly uint MIN_LENGTH = (uint)SizeOf;


        /// <summary>
        /// 
        /// </summary>
        public byte Revision;
        /// <summary>
        /// 
        /// </summary>
        public byte Size;
        /// <summary>
        /// 
        /// </summary>
        public int Control;
        /// <summary>
        /// 
        /// </summary>
        public IntPtr Owner;
        /// <summary>
        /// 
        /// </summary>
        public IntPtr Group;
        /// <summary>
        /// 
        /// </summary>
        public _ACL Sacl;
        /// <summary>
        /// 
        /// </summary>
        public _ACL Dacl;
    }


}
