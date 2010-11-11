using System;


namespace pyrite.windows.security {


    /// <summary>
    /// 
    /// </summary>
    [Flags]
    public enum ACCESS_MASK : int {
        /// <summary>
        /// 
        /// </summary>
        DELETE = 0x00010000,
        /// <summary>
        /// 
        /// </summary>
        READ_CONTROL = 0x00020000,
        /// <summary>
        /// 
        /// </summary>
        WRITE_DAC = 0x00040000,
        /// <summary>
        /// 
        /// </summary>
        WRITE_OWNER = 0x00080000,
        /// <summary>
        /// 
        /// </summary>
        SYNCHRONIZE = 0x00100000,

        /// <summary>
        /// 
        /// </summary>
        STANDARD_RIGHTS_REQUIRED = 0x000f0000,
        /// <summary>
        /// 
        /// </summary>
        STANDARD_RIGHTS_READ = READ_CONTROL,
        /// <summary>
        /// 
        /// </summary>
        STANDARD_RIGHTS_WRITE = READ_CONTROL,
        /// <summary>
        /// 
        /// </summary>
        STANDARD_RIGHTS_EXECUTE = READ_CONTROL,

        /// <summary>
        /// 
        /// </summary>
        STANDARD_RIGHTS_ALL = 0x001f0000,
        /// <summary>
        /// 
        /// </summary>
        SPECIFIC_RIGHTS_ALL = 0x0000ffff
    }
}