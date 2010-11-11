using System.Runtime.InteropServices;


namespace pyrite.windows.services {


    /// <summary>
    /// サービスの状態を SCM に報告するための構造体です。
    /// </summary>
    [StructLayout( LayoutKind.Sequential )]
    public struct SERVICE_STATUS {
        /// <summary>
        /// SERVICE_STATUS 構造体のサイズです。
        /// </summary>
        public static readonly int SizeOf = Marshal.SizeOf( typeof( SERVICE_STATUS ) );
        
        
        /// <summary>
        /// 対応するサービスがどのようなサービスであるかを表します。
        /// </summary>
        public SERVICE_TYPE serviceType;
        /// <summary>
        /// 対応するサービスの現在の状態を表します。
        /// </summary>
        public SERVICE_STATE currentState;
        /// <summary>
        /// SCM から受信したい制御コードをビットフィールドで指定します。
        /// </summary>
        public SERVICE_CONTROLS_ACCEPT controlsAccepted;
        /// <summary>
        /// サービスの開始時、もしくはサービスの停止時にエラーが発生してしまい、
        /// 実際に処理を行うことができない場合のエラーコードを指定します。
        /// </summary>
        public uint win32ExitCode;
        /// <summary>
        /// オリジナルのエラーコードを指定します。
        /// </summary>
        /// <remarks>
        /// Win32 のエラーコードではなく、オリジナルのエラーコードを報告したいような場合、
        /// win32ExitCode に ERROR_SERCICE_SPECIFIC_ERROR を指定することにより、
        /// serviceSpecificExitCode にオリジナルのエラーコードを指定できます。
        /// </remarks>
        public uint serviceSpecificExitCode;
        /// <summary>
        /// 
        /// </summary>
        public uint checkPoint;
        /// <summary>
        /// 
        /// </summary>
        public uint waitHint;
    }


}
