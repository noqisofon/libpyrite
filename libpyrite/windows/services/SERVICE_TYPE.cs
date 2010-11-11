using System;


namespace pyrite.windows.services {


    /// <summary>
    /// どのようなサービスかを表します。
    /// </summary>
    [Flags]
    public enum SERVICE_TYPE : uint {
        /// <summary>
        /// 
        /// </summary>
        KERNEL_DRIVER = 0x00000001,
        /// <summary>
        /// 
        /// </summary>
        FILE_SYSTEM_DRIVER = 0x00000002,
        /// <summary>
        /// 
        /// </summary>
        WIN32_OWN_PROCESS = 0x00000010,
        /// <summary>
        /// 
        /// </summary>
        WIN32_SHARE_PROCESS = 0x00000020,
        /// <summary>
        /// 
        /// </summary>
        INTERACTIVE_PROCESS = 0x00000100
    }


}
