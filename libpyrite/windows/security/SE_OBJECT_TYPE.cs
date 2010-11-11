using System;


namespace pyrite.windows.security {


    /// <summary>
    /// 
    /// </summary>
    public enum SE_OBJECT_TYPE : uint {
        /// <summary>
        /// 
        /// </summary>
        UNKNOWN_OBJECT_TYPE = 0,
        /// <summary>
        /// 
        /// </summary>
        FILE_OBJECT,
        /// <summary>
        /// 
        /// </summary>
        SERVICE,
        /// <summary>
        /// 
        /// </summary>
        PRINTER,
        /// <summary>
        /// 
        /// </summary>
        REGISTRY_KEY,
        /// <summary>
        /// 
        /// </summary>
        LMSHARE,
        /// <summary>
        /// 
        /// </summary>
        KERNEL_OBJECT,
        /// <summary>
        /// 
        /// </summary>
        WINDOW_OBJECT,
        /// <summary>
        /// 
        /// </summary>
        DS_OBJECT,
        /// <summary>
        /// 
        /// </summary>
        DS_OBJECT_ALL,
        /// <summary>
        /// 
        /// </summary>
        PROVIDER_DEFINED_OBJECT,
        /// <summary>
        /// 
        /// </summary>
        WMIGUID_OBJECT,
        /// <summary>
        /// 
        /// </summary>
        REGISTRY_WOW64_32KEY
    }


}
