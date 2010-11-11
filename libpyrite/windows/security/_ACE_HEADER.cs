using System;
using System.Text;
using System.Runtime.InteropServices;


namespace pyrite.windows.security {


    /// <summary>
    /// ACE のヘッダです。
    /// </summary>
    public struct _ACE_HEADER {
        /// <summary>
        /// 
        /// </summary>
        public static readonly uint SizeOf = (uint)Marshal.SizeOf( typeof( _ACE_HEADER ) );


        /// <summary>
        /// ACE のタイプを表します。
        /// </summary>
        public byte  AceType;
        /// <summary>
        /// 継承に関するフラグを表します。
        /// </summary>
        public byte  AceFlags;
        /// <summary>
        /// ACE のサイズを表します。
        /// </summary>
        public short AceSize;
    }


}