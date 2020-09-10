using System.Windows;

namespace Hamamatsu.chatword.ViewModel
{
    public class WindowViewModel : BaseViewModel
    {
        #region Private Member

        /// <summary>
        /// 이 뷰모델이 이 Window를 제어함
        /// </summary>
        private Window mWindow;

        /// <summary>
        /// 창주위에 그림자 생기게 하는거
        /// </summary>
        private int mOuterMarginSize = 10;

        /// <summary>
        /// 창 가장자리 반경
        /// </summary>
        private int mWindowRadius = 10;

        #endregion

        #region public Properties

        /// <summary>
        /// 실행창 주위 테두리 크기
        /// </summary>
        public int ResizeBorder { get; set; } = 6;

        /// <summary>
        /// 실행창 주위 테두리 크기 외부 여백까지 생각
        /// </summary>
        public Thickness ResizeBorderThickness { get { return new Thickness(ResizeBorder+OuterMarginSize); } }

        /// <summary>
        /// 창주위에 그림자 생기게 하는거
        /// </summary>
        public int OuterMarginSize
        {
            get
            {
                return mWindow.WindowState == WindowState.Maximized ? 0 : mOuterMarginSize;
            }
            set
            {
                mOuterMarginSize = value;
            }
        }

        /// <summary>
        /// 창주위에 그림자 생기게 하는거
        /// </summary>
        public Thickness OuterMarginSizeThickness { get { return new Thickness(OuterMarginSize); } }

        /// <summary>
        /// 창 가장자리 반경
        /// </summary>
        public int WindowRadius
        {
            get
            {
                return mWindow.WindowState == WindowState.Maximized ? 0 : mWindowRadius;
            }
            set
            {
                mWindowRadius = value;
            }
        }

        /// <summary>
        /// 창 가장자리 반경
        /// </summary>
        public CornerRadius WindowCornerRadius { get { return new CornerRadius(WindowRadius); } }
        #endregion

        #region 생성자
        /// <summary>
        /// 기본 생성자
        /// </summary>
        /// <param name="window"></param>

        public WindowViewModel(Window window)
        {
            mWindow = window;

            mWindow.StateChanged += (sender, e) =>
            {
                OnPropertyChanged(nameof(ResizeBorderThickness));
                OnPropertyChanged(nameof(OuterMarginSize));
                OnPropertyChanged(nameof(OuterMarginSizeThickness));
                OnPropertyChanged(nameof(WindowRadius));
                OnPropertyChanged(nameof(WindowCornerRadius));
            };
        }
        #endregion
    }
}
