using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Hamamatsu.chatword
{
    public class MonitorPasswordProperty : BaseAttachedProperty<MonitorPasswordProperty, bool>
    {
        public override void OnValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            // Get the caller
            var passwordBox = sender as PasswordBox;

            // 암호상자가 맞는지 확인해라. Make sure it is password box
            if (passwordBox == null)
                return;

            // 그 이전 이벤트를 지우는 코드
            passwordBox.PasswordChanged -= PasswordBox_PasswordChanged;

            // If the caller set MonitorPassword to true...
            if ((bool)e.NewValue)
            {
                // 기본값 설정
                HasTextProperty.SetValue(passwordBox);

                // 암호박스 암호 변경하는걸 시작함
                passwordBox.PasswordChanged += PasswordBox_PasswordChanged;
            }
        }

        /// <summary>
        /// 암호상자의 암호가 바뀔때 시작하는 메소드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            // 연결된 HasText 값을 설정 Set 함
            HasTextProperty.SetValue((PasswordBox)sender);
        }
    }

    /// <summary>
    ///  (이거에 연결될 HasText 속성)->> <see cref="PasswordBox"/>
    /// </summary>
    public class HasTextProperty : BaseAttachedProperty<HasTextProperty, bool>
    {
        /// <summary>
        ///호출자<see cref = "PasswordBox"/> 에 텍스트가 있는지 여부에 따라 HasText 속성을 설정함
        /// </summary>
        /// <param name="sender"></param>
        public static void SetValue(DependencyObject sender)
        {
            SetValue(sender, ((PasswordBox)sender).SecurePassword.Length > 0);
        }
    }
}
