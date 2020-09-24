using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Hamamatsu.chatword
{
    /// <summary>
    /// 커스텀 flat window를 위한 뷰 모델 <<
    /// </summary>
    public class LoginViewModel : BaseViewModel
    {
        #region public Properties

        //유저의 이메일
        public string Email { get; set; }

        /// <summary>
        /// 로그인 명령이 실행중인지 여부를 나타내는 플래그 
        /// </summary>
        public bool LoginIsRunning { get; set; }

        #endregion

        #region Commands


        /// <summary>
        /// 로그인 메뉴 보여주는 커맨드
        /// </summary>
        public ICommand LoginCommand { get; set; }

        #endregion

        #region 생성자
        /// <summary>
        /// 기본 생성자
        /// </summary>
        /// <param name="window"></param>

        public LoginViewModel()
        {
            //Create Commands
            LoginCommand = new RelayParameterizedCommand(async (parameter) => await Login(parameter));


        }

        #endregion

        /// <summary>
        /// 사용자의 로그인 시도
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public async Task Login(object parameter)
        {
            await RunCommand(() => this.LoginIsRunning, async () =>
            {
                await Task.Delay(5000);

                var email = this.Email;
                var pass = (parameter as IHavePassword).SecurePassword.Unsecure();
            });
        }
    }
}