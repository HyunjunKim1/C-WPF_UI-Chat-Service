using PropertyChanged;
using System.ComponentModel;

namespace Hamamatsu.chatword.ViewModel
{
    /// <summary>
    /// 필요에따라 속성을 바꾸는 뷰모델임
    /// </summary>

    public class BaseViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// 자식의 속성값이 변할때 시작되는 이벤트임
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };


        /// <summary>
        /// 
        /// Call this to fire a <see cref="cref="PropertyChanged"/> event
        /// </summary>
        /// <param name="name"></param>
        /// 
        public void OnPropertyChanged(string name)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
