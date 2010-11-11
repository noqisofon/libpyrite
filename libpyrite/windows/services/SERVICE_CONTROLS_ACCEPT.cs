using System;


namespace pyrite.windows.services {


    /// <summary>
    /// サービスが SCM からのどのコードを受信するかを指定します。
    /// </summary>
    [Flags]
    public enum SERVICE_CONTROLS_ACCEPT : uint {
        /// <summary>
        /// 
        /// </summary>
        NETBINDCHANGE = 0x00000010,
        /// <summary>
        /// 
        /// </summary>
        PARAMCHANGE = 0x00000008,
        /// <summary>
        /// 
        /// </summary>
        PAUSE_CONTINUE = 0x00000002,
        /// <summary>
        /// 
        /// </summary>
        PRESHUTDOWN = 0x00000100,
        /// <summary>
        /// 
        /// </summary>
        SHUTDOWN = 0x00000004,
        /// <summary>
        /// 
        /// </summary>
        STOP = 0x00000001
    }


}
