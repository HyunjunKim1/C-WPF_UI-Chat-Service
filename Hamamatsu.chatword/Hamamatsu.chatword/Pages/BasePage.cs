using Hamamatsu.chatword.ViewModel;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Hamamatsu.chatword
{
    /// <summary>
    /// 기본기능을 얻기위한 모든 페이지의 기본페이지
    /// </summary>
    public class BasePage<VM> : Page
        where VM : BaseViewModel, new()
    {
        #region Private Member

        /// <summary>
        /// 이 페이지와 연결된 뷰 모델
        /// </summary>
        private VM mViewModel;

        #endregion

        #region Public Properties
        /// <summary>
        /// The animation the play when the page is first loaded
        /// </summary>
        public PageAnimation PageLoadAnimation { get; set; } = PageAnimation.SlideAndFadeInFromRight;

        /// <summary>
        /// The animation the play when the page is unloaded
        /// </summary>
        public PageAnimation PageUnLoadAnimation { get; set; } = PageAnimation.SlideAndFadeOutToLeft;

        /// <summary>
        /// The time any slide animation takes to complete
        /// </summary>
        public float SlideSeconds { get; set; } = 0.8f;

        /// <summary>
        /// 이 채팅앱과 연관된 뷰 모델
        /// </summary>
        public VM ViewModel
        {
            get { return mViewModel; }
            set
            {
                // 아무거도 바뀌지 않을경우 리턴해주기
                if (mViewModel == value)
                    return;
                // value값 업데이트해주기
                mViewModel = value;

                // 이 페이지의 Data context 설정해주기
                this.DataContext = mViewModel;
            }
        }

        #endregion

        #region Constructor
        /// <summary>
        /// Default Contructor
        /// </summary>
        public BasePage()
        {
            // 애니메이팅 될때, 그 이전껀 없어지게함
            if (this.PageLoadAnimation != PageAnimation.None)
                this.Visibility = Visibility.Collapsed;

            //Listen out for the page loading
            this.Loaded += BasePage_Loaded;

            // 기본 뷰 모델 생성
            this.ViewModel = new VM();
        }

        #endregion

        #region Animation Load / Unload

        /// <summary>
        /// 페이지가 로딩이 되면, 필요한 애니메이션을 수행함
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BasePage_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            // Animate the page in
            await AnimateIn();
        }

        /// <summary>
        /// 이 페이지에서 애니메이션을 함
        /// </summary>
        /// <returns></returns>
        public async Task AnimateIn()
        {
            // 우리가 뭘 할지 확인하는것
            if (this.PageLoadAnimation == PageAnimation.None)
                return;

            switch (this.PageLoadAnimation)
            {
                case PageAnimation.SlideAndFadeInFromRight:

                    // 애니메이션 start
                    await this.SlideAndFadeInFromRight(this.SlideSeconds);

                    break;
            }
        }
        /// <summary>
        /// animate the page out
        /// </summary>
        /// <returns></returns>
        public async Task AnimateOut()
        {
            // 우리가 뭘 할지 확인하는것
            if (this.PageUnLoadAnimation == PageAnimation.None)
                return;

            switch (this.PageUnLoadAnimation)
            {
                case PageAnimation.SlideAndFadeOutToLeft:

                    // 애니메이션 start
                    await this.SlideAndFadeOutToLeft(this.SlideSeconds);

                    break;
            }
        }
        #endregion
    }
}