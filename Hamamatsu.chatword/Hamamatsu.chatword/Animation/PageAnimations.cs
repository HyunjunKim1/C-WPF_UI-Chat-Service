using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Hamamatsu.chatword
{
    /// <summary>
    /// 특정한 방식으로 페이지를 애니메이션하는 도우미 클래스
    /// </summary>
    public static class PageAnimations
    {
        /// <summary>
        /// 오른쪽으로부터 슬라이드 되는 페이지
        /// </summary>
        /// <param name="page">페이지가 애니메이션되는거</param>
        /// <param name="seconds">애니메이션을 하는 시간</param>
        /// <returns></returns>
        public static async Task SlideAndFadeInFromRight(this Page page, float seconds)
        {
            // 스토리보드 생성하기
            var sb = new Storyboard();
            // Add slide from right animation
            sb.AddSlideFromRight(seconds, page.WindowWidth);
            // Add fade in  animation
            sb.AddFadeIn(seconds);

            // 애니메이팅 시작
            sb.Begin(page);

            // 페이지를 보이게하기
            page.Visibility = Visibility.Visible;

            await Task.Delay((int)(seconds * 1000));
        }

        /// <summary>
        /// 왼쪽으로 나가는 슬라이드 되는 페이지
        /// </summary>
        /// <param name="page">페이지가 애니메이션되는거</param>
        /// <param name="seconds">애니메이션을 하는 시간</param>
        /// <returns></returns>
        public static async Task SlideAndFadeOutToLeft(this Page page, float seconds)
        {
            // 스토리보드 생성하기
            var sb = new Storyboard();
            // Add slide from right animation
            sb.AddSlideToLeft(seconds, page.WindowWidth);
            // Add fade out  animation
            sb.AddFadeOut(seconds);

            // 애니메이팅 시작
            sb.Begin(page);

            // 페이지를 보이게하기
            page.Visibility = Visibility.Visible;

            await Task.Delay((int)(seconds * 1000));
        }
    }
}