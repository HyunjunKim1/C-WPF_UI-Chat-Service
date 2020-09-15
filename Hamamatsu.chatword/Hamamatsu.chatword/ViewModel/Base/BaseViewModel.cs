using Hamamatsu.chatword;
using PropertyChanged;
using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Threading.Tasks;


namespace Hamamatsu.chatword
{
    /// <summary>
    /// 필요에따라 속성을 바꾸는 뷰모델임
    /// </summary>
    /// <summary>
    /// A base view model that fires Property Changed events as needed
    /// </summary>
    
    public class BaseViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// The event that is fired when any child property changes its value
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        /// <summary>
        /// Call this to fire a <see cref="PropertyChanged"/> event
        /// </summary>
        /// <param name="name"></param>
        public void OnPropertyChanged(string name)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #region Command Helpers

        /// <summary>
        /// 업데이트 플래그가 설정되지 않은경우 명령을 실행함
        /// 플래그가 true이면 (함수가 이미 실행 중임을 나타냄) 액션이 실행되지 않음 
        /// 플래그가 false (실행중인 함수 없음을 나타냄)이면 액션이 실행됨
        /// 이 액션이 끝날경우에 플래그가 false로 재설정됨 !!!! 어렵다
        /// </summary>
        /// <param name="updatingFlag">명령이 이미 실행 중인지 정의하는 boolean 속성 플래그</param>
        /// <param name="action">명령이 아직 실행중이 아닌경우 실행해야하는 액션</param>
        /// <returns></returns>

        protected async Task RunCommand(Expression<Func<bool>> updatingFlag, Func<Task> action)
        {
            // Check if the flag property is true( meaning the function is already running)
            if (updatingFlag.GetPropertyValue())
                return;

            // 실행중인걸 나타내기위해 속성 플래그를 true로 설정함.
            updatingFlag.SetPropertyValue(true);

            try
            {
                // Run the passed in action
                await action();
            }
            finally
            {
                //set the property flag back to false now it's finished
                updatingFlag.SetPropertyValue(false);
            }
        }

        #endregion
    }
}
