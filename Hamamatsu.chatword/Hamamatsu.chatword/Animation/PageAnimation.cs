namespace Hamamatsu.chatword
{
    /// <summary>
    /// 표시할 페이지의 애니메이션을 표시하거나 사라지게할 코드
    /// </summary>
    public enum PageAnimation
    {
        /// <summary>
        /// No animation takes place
        /// </summary>
        None = 0,
        /// <summary>
        /// 페이지가 슬라이드 인되고 오른쪽으로 페이드인 됨
        /// </summary>
        SlideAndFadeInFromRight = 1,

        /// <summary>
        /// 페이지가 슬라이드 아웃되고 왼쪽으로 페이드 아웃됨
        /// </summary>
        SlideAndFadeOutToLeft = 2,
    }
}