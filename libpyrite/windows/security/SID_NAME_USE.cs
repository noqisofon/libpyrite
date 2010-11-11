using System;


namespace pyrite.windows.security {


    /// <summary>
    /// 
    /// </summary>
    public enum SID_NAME_USE : uint {
        /// <summary>
        /// 
        /// </summary>
        SidTypeUser = 1,
        /// <summary>
        /// 
        /// </summary>
        SidTypeGroup,
        /// <summary>
        /// 
        /// </summary>
        SidTypeDomain,
        /// <summary>
        /// 
        /// </summary>
        SidTypeAlias,
        /// <summary>
        /// 
        /// </summary>
        SidTypeWellKnownGroup,
        /// <summary>
        /// 
        /// </summary>
        SidTypeDeletedAccount,
        /// <summary>
        /// 
        /// </summary>
        SidTypeInvalid,
        /// <summary>
        /// 
        /// </summary>
        SidTypeUnknown,
        /// <summary>
        /// 
        /// </summary>
        SidTypeComputer
    }


}
