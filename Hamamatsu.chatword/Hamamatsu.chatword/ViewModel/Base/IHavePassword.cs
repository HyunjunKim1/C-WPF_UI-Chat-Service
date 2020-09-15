using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Hamamatsu.chatword
{
    /// <summary>
    /// 보안되는 암호를 제공하는 클래스용 인터페이스
    /// </summary>
    public interface IHavePassword
    {
        //보안되는 암호
        SecureString SecurePassword { get; }
    }
}
