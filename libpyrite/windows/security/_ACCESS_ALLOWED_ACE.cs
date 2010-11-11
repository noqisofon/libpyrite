using System;
using System.Text;
using System.Runtime.InteropServices;


namespace pyrite.windows.security {


    /// <summary>
    /// PACE ÇÃé¿ëÃÇ∆Ç»ÇÈç\ë¢ëÃÇ≈Ç∑ÅB
    /// </summary>
    [StructLayout( LayoutKind.Sequential )]
    public struct _ACCESS_ALLOWED_ACE {
        /// <summary>
        /// 
        /// </summary>
        public static readonly uint SizeOf = (uint)Marshal.SizeOf( typeof( _ACL ) );


        /// <summary>
        /// 
        /// </summary>
        public _ACE_HEADER   Header;
        /// <summary>
        /// 
        /// </summary>
        public ACCESS_MASK   Mask;
        /// <summary>
        /// 
        /// </summary>
        public uint          SidStart;
    }


}
