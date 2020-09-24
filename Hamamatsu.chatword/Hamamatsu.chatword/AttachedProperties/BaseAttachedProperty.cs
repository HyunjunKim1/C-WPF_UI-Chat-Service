using System;
using System.ComponentModel;
using System.Runtime.Remoting.Channels;
using System.Windows;

namespace Hamamatsu.chatword
{
    /// <summary>
    /// WPF 연결 속성을 대체하는 기본연결 속성
    /// </summary>
    /// <typeparam name="Parent">연결된 속성이 될 부모클래스</typeparam>
    /// 
    public abstract class BaseAttachedProperty<Parent, Property>
        where Parent : BaseAttachedProperty<Parent, Property>, new()          //제네릭 T타입 공부해야함 !!!
    {
        #region Public Events
        /// <summary>
        /// 값이 변할때 실행되는 이벤트임
        /// </summary>
        public event Action<DependencyObject, DependencyPropertyChangedEventArgs> ValueChanged = (sender, e) => { };

        #endregion

        #region Public Properties
        /// <summary>
        /// 싱글톤인 부모클래스의 인스턴스
        /// </summary>
        public static Parent Instance { get; private set; } = new Parent();

        #endregion

        #region Attached Property Definitions

        /// <summary>
        /// 이클래스의 연결된 속성들
        /// </summary>
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.RegisterAttached("Value", typeof(Property),
                typeof(BaseAttachedProperty<Parent, Property>),
                new PropertyMetadata(new PropertyChangedCallback(OnValuePropertyChanged)));

        /// <summary>
        /// ValueProperty가 바뀔때 생기는 콜백 이벤트
        /// </summary>
        /// <param name="d"></param>
        /// <param name="e"></param>
        private static void OnValuePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            // Call the parent function
            Instance.OnValueChanged(d, e);

            // Call event listeners
            Instance.ValueChanged(d, e);
        }
        /// <summary>
        /// 연결된 속성들값들을 얻는거
        /// </summary>
        /// <param name="d">속성을 가져올 요소</param>
        /// <returns></returns>
        public static Property GetValue(DependencyObject d) => (Property)d.GetValue(ValueProperty);

        /// <summary>
        /// 연결된 속성들을 설정함
        /// </summary>
        /// <param name="d">속성들을 가져올 요소</param>
        /// <param name="value">연결된 속성들 값을 설정함</param>
        public static void SetValue(DependencyObject d, Property value) => d.SetValue(ValueProperty, value);
        #endregion

        #region Event Methods
        /// <summary>
        /// 이 유형의 연결된 속성이 변경 될 때 호출되는 메서드
        /// </summary>
        /// <param name="sender">sender 속성이 변경된 UI 요소</param>
        /// <param name="e">e 이거는 그냥 e벤트에 관한 인수</param>
        public virtual void OnValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e) { }

        #endregion
    }
}