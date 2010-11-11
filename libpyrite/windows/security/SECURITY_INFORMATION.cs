using System;


namespace pyrite.windows.security {


    /// <summary>
    /// 
    /// </summary>
    [Flags]
    public enum SECURITY_INFORMATION : uint {
        /// <summary>
        /// 
        /// </summary>
        OWNER = 0x00000001,
        /// <summary>
        /// 
        /// </summary>
        GROUP = 0x00000002,
        /// <summary>
        /// 
        /// </summary>
        DACL = 0x00000004,
        /// <summary>
        /// 
        /// </summary>
        SACL = 0x00000008,
        /// <summary>
        /// 
        /// </summary>
        UNPROTECTED_SACL = 0x10000000,
        /// <summary>
        /// 
        /// </summary>
        UNPROTECTED_DACL = 0x20000000,
        /// <summary>
        /// 
        /// </summary>
        PROTECTED_SACL = 0x40000000,
        /// <summary>
        /// 
        /// </summary>
        PROTECTED_DACL = 0x80000000
    }
}
