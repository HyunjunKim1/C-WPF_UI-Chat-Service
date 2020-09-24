using Hamamatsu.chatword.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hamamatsu.chatword
{
    /// <summary>
    /// LoginPage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class LoginPage : BasePage<LoginViewModel>, IHavePassword
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 이 로그인 페이지를 위한 보안이 적용된 암호
        /// </summary>
        public SecureString SecurePassword => PasswordText.SecurePassword;
    }
}