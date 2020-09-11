using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Input;

namespace Hamamatsu.chatword.ViewModel
{
    /// <summary>
    /// 커스텀 flat window를 위한 뷰 모델 <<
    /// </summary>
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

        /// <summary>
        /// 마지막으로 알려진 Dock 위치
        /// </summary>
        private WindowDockPosition mDockPosition = WindowDockPosition.Undocked;
        #endregion



        #region public Properties
        //윈도우창이 가장 작은 크기를 정해줌
        public double WindowMinimumWidth { get; set; } = 400;
        public double WindowMinimumHeight { get; set; } = 400;

        public bool Borderless { get { return (mWindow.WindowState == WindowState.Maximized || mDockPosition != WindowDockPosition.Undocked); } }
       
        /// <summary>
        /// 실행창 주위 테두리 크기조절
        /// </summary>   
        public int ResizeBorder { get { return Borderless ? 0 : 6; } }

        /// <summary>
        /// 실행창 주위 테두리 크기, 외부 여백까지 생각
        /// </summary>
        public Thickness ResizeBorderThickness { get { return new Thickness(ResizeBorder+OuterMarginSize); } }

        public Thickness InnerContentPadding { get; set; } = new Thickness(0);

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

        /// <summary>
        /// 타이틀바 높이/윈도우창 제목
        /// </summary>
        public int TitleHeight { get; set; } = 42;
        public GridLength TitleHeightGridLength { get { return new GridLength(TitleHeight+ ResizeBorder); } }

        /// <summary>
        /// 채팅앱의 현재 페이지 알려주는 getset
        /// </summary>
        public ApplicationPage CurrentPage { get; set; } = ApplicationPage.Login;

        #endregion

        #region Commands

        /// <summary>
        /// 최소화 시키는 커맨드
        /// </summary>
        public ICommand MinimizeCommand { get; set; }
        /// <summary>
        /// 최대화 커맨드
        /// </summary>
        public ICommand MaximizeCommand { get; set; }
        /// <summary>
        /// 닫기 커맨드
        /// </summary>
        public ICommand CloseCommand { get; set; }
        /// <summary>
        /// 시스템 메뉴 보여주는 커맨드
        /// </summary>
        public ICommand MenuCommand { get; set; }

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

            //Create Commands
            MinimizeCommand = new RelayCommand(() => mWindow.WindowState = WindowState.Minimized);
            MaximizeCommand = new RelayCommand(() => mWindow.WindowState ^= WindowState.Maximized);
            CloseCommand = new RelayCommand(() => mWindow.Close());
            MenuCommand = new RelayCommand(() => SystemCommands.ShowSystemMenu(mWindow, GetMousePosition()));

            var resizer = new WindowResizer(mWindow);

            // Listen out for dock changes
            resizer.WindowDockChanged += (dock) =>
            {
                // Store last position
                mDockPosition = dock;

                // Fire off resize events
                WindowResized();
            };
        }
        #endregion

        #region Private Helpers

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]

        internal static extern bool GetCursorPos(ref Win32Point pt);

        [StructLayout(LayoutKind.Sequential)]

        internal struct Win32Point
        {
            public Int32 X;
            public Int32 Y;
        };

        /// <summary>
        /// 화면에서 현재 마우스 위치를 가져오는 코드
        /// </summary>
        /// <returns></returns>
        private static Point GetMousePosition()
        {
            Win32Point w32Mouse = new Win32Point();
            GetCursorPos(ref w32Mouse);
            return new Point(w32Mouse.X, w32Mouse.Y);
        }

        private void WindowResized()
        {
            // Fire off events for all properties that are affected by a resize
            OnPropertyChanged(nameof(Borderless));
            OnPropertyChanged(nameof(ResizeBorderThickness));
            OnPropertyChanged(nameof(OuterMarginSize));
            OnPropertyChanged(nameof(OuterMarginSizeThickness));
            OnPropertyChanged(nameof(WindowRadius));
            OnPropertyChanged(nameof(WindowCornerRadius));
        }

        #endregion
    }
}
