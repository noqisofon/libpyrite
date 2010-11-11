using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;


namespace pyrite.windows.pinvoke {


    using security;
    using services;


    /// <summary>
    ///
    /// </summary>
    public static class AdvAPI32 {
        /// <summary>
        /// ハンドルで指定されたオブジェクトのセキュリティ記述子のコピーを取得します。
        /// </summary>
        /// <param name="handle">オブジェクトのハンドル。</param>
        /// <param name="ObjectType">オブジェクトタイプ。</param>
        /// <param name="SecurityInfo">取得するセキュリティ情報のタイプ。</param>
        /// <param name="pSidOwner">所有者 SID へのポインタを受け取る。</param>
        /// <param name="pSidGroup">プライマリグループ SID へのポインタを受け取る。</param>
        /// <param name="pDacl">DACL へのポインタを受け取る。</param>
        /// <param name="pSacl">SACL へのポインタを受け取る。</param>
        /// <param name="pSecurityDescriptor">セキュリティ記述子へのポインタ。</param>
        /// <returns>成功なら ERROR_SUCCESS が返る。</returns>
        [DllImport( "advapi32.dll", SetLastError = true )]
        public static extern uint GetSecurityInfo(
            IntPtr handle,
            SE_OBJECT_TYPE ObjectType,
            SECURITY_INFORMATION SecurityInfo,
            out IntPtr pSidOwner,
            out IntPtr pSidGroup,
            out IntPtr pDacl,
            out IntPtr pSacl,
            out IntPtr pSecurityDescriptor
        );
        /// <summary>
        /// 
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="ObjectType"></param>
        /// <param name="SecurityInfo"></param>
        /// <param name="pSidOwner"></param>
        /// <param name="pSidGroup"></param>
        /// <param name="pDacl"></param>
        /// <param name="pSacl"></param>
        /// <param name="pSecurityDescriptor"></param>
        /// <returns></returns>
        [DllImport( "advapi32.dll", SetLastError = true )]
        public static extern uint GetSecurityInfo(
            IntPtr handle,
            SE_OBJECT_TYPE ObjectType,
            SECURITY_INFORMATION SecurityInfo,
            out IntPtr pSidOwner,
            out IntPtr pSidGroup,
            out IntPtr pDacl,
            out IntPtr pSacl,
            IntPtr pSecurityDescriptor
        );
        /// <summary>
        /// 
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="ObjectType"></param>
        /// <param name="SecurityInfo"></param>
        /// <param name="pSidOwner"></param>
        /// <param name="pSidGroup"></param>
        /// <param name="pDacl"></param>
        /// <param name="pSacl"></param>
        /// <param name="pSecurityDescriptor"></param>
        /// <returns></returns>
        [DllImport( "advapi32.dll", SetLastError = true )]
        public static extern uint GetSecurityInfo(
            IntPtr handle,
            SE_OBJECT_TYPE ObjectType,
            SECURITY_INFORMATION SecurityInfo,
            out IntPtr pSidOwner,
            out IntPtr pSidGroup,
            out IntPtr pDacl,
            out IntPtr pSacl,
            out _SECURITY_DESCRIPTOR pSecurityDescriptor
        );
        /// <summary>
        /// 
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="ObjectType"></param>
        /// <param name="SecurityInfo"></param>
        /// <param name="pSidOwner"></param>
        /// <param name="pSidGroup"></param>
        /// <param name="pDacl"></param>
        /// <param name="pSacl"></param>
        /// <param name="pSecurityDescriptor"></param>
        /// <returns></returns>
        [DllImport( "advapi32.dll", SetLastError = true )]
        public static extern uint GetSecurityInfo(
            IntPtr handle,
            SE_OBJECT_TYPE ObjectType,
            SECURITY_INFORMATION SecurityInfo,
            out IntPtr pSidOwner,
            out IntPtr pSidGroup,
            out _ACL pDacl,
            out _ACL pSacl,
            out _SECURITY_DESCRIPTOR pSecurityDescriptor
        );


        /// <summary>
        /// SID(セキュリティ ID)を、表示や格納、送信に適した文字列へ変換します。
        /// </summary>
        /// <param name="sid">変換する SID へのポインタ。</param>
        /// <param name="sidString">SID 文字列へのポインタを受け取る変数へのポインタ。</param>
        /// <returns>成功したら真。</returns>
        [DllImport( "advapi32", SetLastError = true )]
        public static extern bool ConvertSidToStringSid(
            IntPtr sid,
            out IntPtr sidString
        );
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sid"></param>
        /// <param name="sidString"></param>
        /// <returns></returns>
        public static bool ConvertSidToStringSid(IntPtr sid, out string sidString) {
            IntPtr tmp_sid_string = IntPtr.Zero;
            bool result = ConvertSidToStringSid( sid, out tmp_sid_string );
            sidString = Marshal.PtrToStringAuto( tmp_sid_string );

            return result;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sid"></param>
        /// <param name="sidString"></param>
        /// <returns></returns>
        [DllImport( "advapi32", SetLastError = true )]
        public static extern bool ConvertSidToStringSid(
            _SID sid,
            out IntPtr sidString
        );


        /// <summary>
        /// 新しいセキュリティ記述子を初期化します。
        /// </summary>
        /// <param name="pSecurityDescriptor">セキュリティ記述子のアドレス。</param>
        /// <param name="dwRevision">リビジョンレベル。</param>
        /// <returns>成功なら真。</returns>
        [DllImport( "advapi32.dll", SetLastError = true )]
        public static extern bool InitializeSecurityDescriptor(IntPtr pSecurityDescriptor, uint dwRevision);
        /// <summary>
        ///  新しいセキュリティ記述子を初期化します。
        /// </summary>
        /// <param name="pSecurityDescriptor">セキュリティ記述子のアドレス。</param>
        /// <returns>成功したら真。</returns>
        public static bool InitializeSecurityDescriptor(IntPtr pSecurityDescriptor) {
            return InitializeSecurityDescriptor( pSecurityDescriptor, _SECURITY_DESCRIPTOR.REVISION );
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pSecurityDescriptor"></param>
        /// <param name="dwRevision"></param>
        /// <returns></returns>
        [DllImport( "advapi32.dll", SetLastError = true )]
        public static extern bool InitializeSecurityDescriptor(ref _SECURITY_DESCRIPTOR pSecurityDescriptor, uint dwRevision);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pSecurityDescriptor"></param>
        /// <returns></returns>
        public static bool InitializeSecurityDescriptor(ref _SECURITY_DESCRIPTOR pSecurityDescriptor) {
            return InitializeSecurityDescriptor( ref pSecurityDescriptor, _SECURITY_DESCRIPTOR.REVISION );
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="pacl"></param>
        /// <param name="nAclLength"></param>
        /// <param name="dwAclRevision"></param>
        /// <returns></returns>
        [DllImport( "advapi32.dll", SetLastError = true )]
        public static extern bool InitializeAcl(IntPtr pAcl, uint nAclLength, uint dwAclRevision);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pacl"></param>
        /// <param name="nAclLength"></param>
        /// <returns></returns>
        public static bool InitializeAcl(IntPtr pAcl, uint nAclLength) {
            return InitializeAcl( pAcl, nAclLength, _ACL.REVISION );
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pAcl"></param>
        /// <returns></returns>
        public static bool InitializeAcl(IntPtr pAcl) {
            return InitializeAcl( pAcl, _ACL.SizeOf, _ACL.REVISION );
        }


        /// <summary>
        /// セキュリティ記述子のコンポーネントが有効かどうかを調べます。
        /// </summary>
        /// <param name="pSecurityDescriptor">セキュリティ記述子のアドレス。</param>
        /// <returns>成功したら真。</returns>
        [DllImport( "advapi32.dll", SetLastError = true )]
        public static extern bool IsValidSecurityDescriptor(IntPtr pSecurityDescriptor);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pSecurityDescriptor"></param>
        /// <returns></returns>
        [DllImport( "advapi32.dll", SetLastError = true )]
        public static extern bool IsValidSecurityDescriptor(_SECURITY_DESCRIPTOR pSecurityDescriptor);


        /// <summary>
        /// 構造上有効な構造体のサイズをバイト単位で返します。
        /// </summary>
        /// <param name="pSecurityDescriptor">セキュリティ記述子のアドレス。</param>
        /// <returns>SECURITY_DESCRIPTOR 構造体のバイト単位の長さ。</returns>
        [DllImport( "advapi32.dll" )]
        public static extern int GetSecurityDescriptorLength(IntPtr pSecurityDescriptor);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pSecurityDescriptor"></param>
        /// <returns></returns>
        [DllImport( "advapi32.dll" )]
        public static extern int GetSecurityDescriptorLength(_SECURITY_DESCRIPTOR pSecurityDescriptor);


        /// <summary>
        /// ACL(アクセス制御リスト)内の一つの ACE(アクセス制御エントリ)へのポインタを取得します。
        /// </summary>
        /// <param name="aclPtr">アクセス制御リストへのポインタ。</param>
        /// <param name="aceIndex">取得する ACE のインデックス番号。</param>
        /// <param name="acePtr">ACE へのポインタへのポインタ。</param>
        /// <returns>成功したら真。</returns>
        [DllImport( "advapi32.dll", SetLastError = true )]
        public static extern bool GetAce(IntPtr aclPtr, int aceIndex, out IntPtr acePtr);


        /// <summary>
        /// ACL(アクセス制御リスト)に関する情報を取得します。
        /// </summary>
        /// <param name="pAcl">アクセス制御リストへのポインタ。</param>
        /// <param name="pAclInfomation"></param>
        /// <param name="nAclInfomationLength"></param>
        /// <param name="dwAclInfomationClass"></param>
        /// <returns></returns>
        [DllImport( "advapi32.dll", SetLastError = true )]
        public static extern bool GetAclInformation(
            IntPtr pAcl,
            IntPtr pAclInformation,
            uint nAclInformationLength,
            ACL_INFORMATION_CLASS dwAclInformationClass
        );
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pAcl"></param>
        /// <param name="pAclInformation"></param>
        /// <param name="nAclInformationLength"></param>
        /// <param name="dwAclInformationClass"></param>
        /// <returns></returns>
        [DllImport( "advapi32.dll", SetLastError = true )]
        public static extern bool GetAclInformation(
            IntPtr pAcl,
            ref _ACL_REVISION_INFORMATION pAclInformation,
            uint nAclInformationLength,
            ACL_INFORMATION_CLASS dwAclInformationClass
        );
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pAcl"></param>
        /// <param name="pAclInformation"></param>
        /// <param name="nAclInformationLength"></param>
        /// <param name="dwAclInformationClass"></param>
        /// <returns></returns>
        [DllImport( "advapi32.dll", SetLastError = true )]
        public static extern bool GetAclInformation(
            IntPtr pAcl,
            ref _ACL_SIZE_INFORMATION pAclInformation,
            uint nAclInformationLength,
            ACL_INFORMATION_CLASS dwAclInformationClass
        );


        /// <summary>
        /// ファイルまたはディレクトリに関する、指定された情報を取得します。
        /// </summary>
        /// <param name="lpFileName">ファイル名。</param>
        /// <param name="requestedInfomation">取得する情報。</param>
        /// <param name="pSecurityDescriptor">セキュリティ記述子のアドレス。</param>
        /// <param name="nLength">セキュリティ記述子バッファのサイズ。</param>
        /// <param name="lpnLengthNeeded">バッファが必要とするサイズを保持するアドレス。</param>
        /// <returns>成功すれば真。</returns>
        [DllImport( "advapi32.dll", SetLastError = true )]
        public static extern bool GetFileSecurity(
            string lpFileName,
            SECURITY_INFORMATION requestedInfomation,
            IntPtr pSecurityDescriptor,
            uint nLength,
            out uint lpnLengthNeeded
        );
        /// <summary>
        /// ファイルまたはディレクトリに関する、指定された情報を取得します。
        /// </summary>
        /// <param name="lpFileName">ファイル名。</param>
        /// <param name="requestedInfomation">取得する情報。</param>
        /// <param name="pSecurityDescriptor">セキュリティ記述子。</param>
        /// <param name="nLength">セキュリティ記述子バッファのサイズ。</param>
        /// <param name="lpnLengthNeeded">バッファが必要とするサイズを保持するアドレス。</param>
        /// <returns>成功すれば真。</returns>
        [DllImport( "advapi32.dll", SetLastError = true )]
        public static extern bool GetFileSecurity(
            string lpFileName,
            SECURITY_INFORMATION requestedInfomation,
            [MarshalAs( UnmanagedType.Struct )] ref _SECURITY_DESCRIPTOR pSecurityDescriptor,
            uint nLength,
            out uint lpnLengthNeeded
        );


        /// <summary>
        /// 指定されたセキュリティ記述子内の DACL(随意アクセス制御リスト)へのポインタを取得します。
        /// </summary>
        /// <param name="pSecurityDescriptor">セキュリティ記述子のアドレス。</param>
        /// <param name="lpbDaclPresent">DACL が存在することを示すフラグへのアドレス。</param>
        /// <param name="pDacl">ACL へのポインタのアドレス。</param>
        /// <param name="lpbDaclDefaulted">DACL が既定のものかどうかを示すフラグのアドレス。</param>
        /// <returns>成功すれば真。</returns>
        [DllImport( "advapi32.dll", SetLastError = true )]
        public static extern bool GetSecurityDescriptorDacl(
            IntPtr pSecurityDescriptor,
            ref bool lpbDaclPresent,
            out IntPtr pDacl,
            ref bool lpbDaclDefaulted
        );


        /// <summary>
        /// 
        /// </summary>
        /// <param name="pSecurityDescriptor"></param>
        /// <param name="lpbSaclPresent"></param>
        /// <param name="pSacl"></param>
        /// <param name="lpbSaclDefaulted"></param>
        /// <returns></returns>
        [DllImport( "advapi32.dll", SetLastError = true )]
        public static extern bool GetSecurityDescriptorSacl(
            IntPtr pSecurityDescriptor,
            ref bool lpbSaclPresent,
            out IntPtr pSacl,
            ref bool lpbSaclDefaulted
        );


        /// <summary>
        /// セキュリティ記述子から所有者情報を取得します。
        /// </summary>
        /// <param name="pSecurityDescriptor">セキュリティ記述子のアドレス。</param>
        /// <param name="pOwner">所有者の SIDへのポインタのアドレス。</param>
        /// <param name="lpbOwnerDefaulted">既定かどうかを示すフラグのアドレス。</param>
        /// <returns>成功したら真。</returns>
        [DllImport( "advapi32.dll", SetLastError = true )]
        public static extern bool GetSecurityDescriptorOwner(
            IntPtr pSecurityDescriptor,
            [MarshalAs( UnmanagedType.LPArray )] byte[] pOwner,
            ref bool lpbOwnerDefaulted
        );
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pSecurityDescriptor"></param>
        /// <param name="pOwner"></param>
        /// <param name="lpbOwnerDefaulted"></param>
        /// <returns></returns>
        [DllImport( "advapi32.dll", SetLastError = true )]
        public static extern bool GetSecurityDescriptorOwner(
            _SECURITY_DESCRIPTOR pSecurityDescriptor,
            [MarshalAs( UnmanagedType.LPArray )] byte[] pOwner,
            ref bool lpbOwnerDefaulted
        );
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pSecurityDescriptor"></param>
        /// <param name="pOwner"></param>
        /// <param name="lpbOwnerDefaulted"></param>
        /// <returns></returns>
        [DllImport( "advapi32.dll", SetLastError = true )]
        public static extern bool GetSecurityDescriptorOwner(
            IntPtr pSecurityDescriptor,
            out object pOwner,
            ref bool lpbOwnerDefaulted
        );
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pSecurityDescriptor"></param>
        /// <param name="pOwner"></param>
        /// <param name="lpbOwnerDefaulted"></param>
        /// <returns></returns>
        [DllImport( "advapi32.dll", SetLastError = true )]
        public static extern bool GetSecurityDescriptorOwner(
            IntPtr pSecurityDescriptor,
            out IntPtr pOwner,
            ref bool lpbOwnerDefaulted
        );
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pSecurityDescriptor"></param>
        /// <param name="pOwner"></param>
        /// <param name="lpbOwnerDefaulted"></param>
        /// <returns></returns>
        [DllImport( "advapi32.dll", SetLastError = true )]
        public static extern bool GetSecurityDescriptorOwner(
            _SECURITY_DESCRIPTOR pSecurityDescriptor,
            out object pOwner,
            ref bool lpbOwnerDefaulted
        );
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pSecurityDescriptor"></param>
        /// <param name="pOwner"></param>
        /// <param name="lpbOwnerDefaulted"></param>
        /// <returns></returns>
        [DllImport( "advapi32.dll", SetLastError = true )]
        public static extern bool GetSecurityDescriptorOwner(
            _SECURITY_DESCRIPTOR pSecurityDescriptor,
            out IntPtr pOwner,
            ref bool lpbOwnerDefaulted
        );


        /// <summary>
        /// 
        /// </summary>
        /// <param name="pSecurityDescriptor"></param>
        /// <param name="pGroup"></param>
        /// <param name="lpbGroupDefaulted"></param>
        /// <returns></returns>
        [DllImport( "advapi32.dll", SetLastError = true )]
        public static extern bool GetSecurityDescriptorGroup(
            IntPtr pSecurityDescriptor,
            out IntPtr pGroup,
            ref bool lpbGroupDefaulted
        );


        /// <summary>
        /// 
        /// </summary>
        /// <param name="lpSystemName"></param>
        /// <param name="Sid"></param>
        /// <param name="lpName"></param>
        /// <param name="cchName"></param>
        /// <param name="lpReferencedDomainName"></param>
        /// <param name="cchReferencedDomainName"></param>
        /// <param name="peUse"></param>
        /// <returns></returns>
        [DllImport( "advapi32.dll", SetLastError = true, CharSet = CharSet.Auto )]
        public static extern bool LookupAccountSid(
            string lpSystemName,
            IntPtr Sid,
            [Out] StringBuilder lpName,
            out uint cchName,
            [Out] StringBuilder lpReferencedDomainName,
            out uint cchReferencedDomainName,
            ref SID_NAME_USE peUse
        );
        /// <summary>
        /// SID に対応するアカウントの名前とその SID が見つかった最初のドメインを取得します。
        /// </summary>
        /// <param name="lpSystemName">ローカル、またはリモートコンピュータ名。</param>
        /// <param name="Sid">参照する SID。</param>
        /// <param name="lpName">アカウントを受け取るバッファ。</param>
        /// <param name="cchName">アカウント名バッファのサイズ。</param>
        /// <param name="ReferencedDomainName">参照されるドメインの名前を受け取るバッファ。</param>
        /// <param name="cchReferencedDomainName">ドメイン名バッファのサイズ。</param>
        /// <param name="peUse">SID のタイプを受け取ります。</param>
        /// <returns>成功したら真。</returns>
        [DllImport( "advapi32.dll", SetLastError = true, CharSet = CharSet.Auto )]
        public static extern bool LookupAccountSid(
            string lpSystemName,
            [MarshalAs( UnmanagedType.LPArray )] byte[] Sid,
            [Out] StringBuilder lpName,
            out uint cchName,
            [Out] StringBuilder lpReferencedDomainName,
            out uint cchReferencedDomainName,
            ref SID_NAME_USE peUse
        );


        /// <summary>
        /// 呼び出し側サービスに関するサービス制御マネージャのステータス情報を更新します。
        /// </summary>
        /// <param name="hServiceStatus">現在のサービスに対応するステータス情報構造体のハンドル。</param>
        /// <param name="lpServiceStatus">呼び出し側サービスに関する最新ステータス情報を格納する構造体への参照。</param>
        /// <returns>成功すれば真。</returns>
        [DllImport( "advapi32.dll", SetLastError = true, CharSet = CharSet.Auto )]
        public static extern bool SetServiceStatus(IntPtr hServiceStatus, ref SERVICE_STATUS lpServiceStatus);
    }


}
