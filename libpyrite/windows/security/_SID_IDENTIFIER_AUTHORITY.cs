using System;
using System.Text;
using System.Runtime.InteropServices;


namespace pyrite.windows.security {


    /// <summary>
    /// 
    /// </summary>
    public struct _SID_IDENTIFIER_AUTHORITY {
        /// <summary>
        /// 
        /// </summary>
        public static readonly uint SizeOf = (uint)Marshal.SizeOf( typeof( _SID_IDENTIFIER_AUTHORITY ) );


        /// <summary>
        /// 
        /// </summary>
        [MarshalAs( UnmanagedType.ByValArray, SizeConst = 6 )]
        public byte[] Value;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public _SID_IDENTIFIER_AUTHORITY(byte[] value) {
            Value = value;
        }
    }


}
