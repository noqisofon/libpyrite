using System;



namespace pyrite.windows.services {


    /// <summary>
    /// 
    /// </summary>
    [Flags]
    public enum SERVICE_STATE : uint {
        /// <summary>
        /// 
        /// </summary>
        STOPPED = 0x00000001,
        /// <summary>
        /// 
        /// </summary>
        START_PENDING = 0x00000002,
        /// <summary>
        /// 
        /// </summary>
        STOP_PENDING = 0x00000003,
        /// <summary>
        /// 
        /// </summary>
        RUNNING = 0x00000004,
        /// <summary>
        /// 
        /// </summary>
        CONTINUE_PENDING = 0x00000005,
        /// <summary>
        /// 
        /// </summary>
        PAUSE_PENDING = 0x00000006,
        /// <summary>
        /// 
        /// </summary>
        PAUSED = 0x00000007,
    }


}
