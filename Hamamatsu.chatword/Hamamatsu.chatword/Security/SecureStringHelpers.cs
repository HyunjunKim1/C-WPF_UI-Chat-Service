using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Hamamatsu.chatword
{
    /// <summary>
    /// SecureString 클래스를 도와줌
    /// </summary>
    public static class SecureStringHelpers
    {
        /// <summary>
        /// <see cref="SecureString"/> <-- 얘 텍스트에 대한 보안해제
        /// </summary>
        /// <param name="secureString">The secure string</param>
        /// <returns></returns>
        public static string Unsecure(this SecureString secureString)
        {
            // 확실히 보안문자를 가지고있을때
            if (secureString == null)
                return string.Empty;

            // 메모리안에 안전하지않은 문자를 가지고있는 포인터좌표
            var unmanagedString = IntPtr.Zero;

            try
            {
                //보안되지않은 비밀번호
                unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(secureString);
                return Marshal.PtrToStringUni(unmanagedString);
            }
            finally
            {
                // 메모리할당 초기화해주기
                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }
        }
    }
}
