using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media.Animation;

namespace Hamamatsu.chatword
{
    /// <summary>
    /// Animation helpers for <see cref="cref="StoryBoard"/>
    /// </summary>
    public static class StoryboardHelpers
    {
        /// <summary>
        /// 슬라이드를 추가하고 스토리보드에 애니메이션
        /// </summary>
        /// <param name="storyboard">애니메이션을 추가할 스토리보드</param>
        /// <param name="seconds">애니메이션에 걸리는 시간</param>
        /// <param name="offset">시작할곳부터 오른쪽까지 거리</param>
        /// <param name="decelerationRatio">이건 감속하는 속도</param>
        public static void AddSlideFromRight(this Storyboard storyboard, float seconds, double offset, float decelerationRatio = 0.9f)
        {
            // Create the margin animate from right
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(offset, 0, -offset, 0),
                To = new Thickness(0),
                DecelerationRatio = decelerationRatio
            };
            // 타겟의 속성 이름을 설정함
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));
            // 이 스토리보드에 추가하기
            storyboard.Children.Add(animation);
        }
        /// <summary>
        /// 슬라이드를 추가하고 스토리보드에 애니메이션 
        /// </summary>
        /// <param name="storyboard">애니메이션을 추가할 스토리보드</param>
        /// <param name="seconds">애니메이션에 걸리는 시간</param>
        /// <param name="offset">시작할곳부터 오른쪽까지 거리</param>
        /// <param name="decelerationRatio">이건 감속하는 속도</param>
        public static void AddSlideToLeft(this Storyboard storyboard, float seconds, double offset, float decelerationRatio = 0.9f)
        {
            // Create the margin animate from To Left
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(0),
                To = new Thickness(-offset, 0, offset, 0),
                DecelerationRatio = decelerationRatio
            };
            // 타겟의 속성 이름을 설정함
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));
            // 이 스토리보드에 추가하기
            storyboard.Children.Add(animation);
        }
        /// <summary>
        /// Fade in을 추가하고 스토리보드에 애니메이션 페이드 인하기
        /// </summary>
        /// <param name="storyboard">애니메이션을 추가할 스토리보드</param>
        /// <param name="seconds">애니메이션에 걸리는 시간</param>
        public static void AddFadeIn(this Storyboard storyboard, float seconds)
        {
            // Create the margin animate from right
            var animation = new DoubleAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = 0,
                To = 1,
            };
            // 타겟의 속성 이름을 설정함
            Storyboard.SetTargetProperty(animation, new PropertyPath("Opacity"));
            // 이 스토리보드에 추가하기
            storyboard.Children.Add(animation);
        }
        /// <summary>
        /// Fade out을 추가하고 스토리보드에 애니메이션 페이드 인하기
        /// </summary>
        /// <param name="storyboard">애니메이션을 추가할 스토리보드</param>
        /// <param name="seconds">애니메이션에 걸리는 시간</param>
        public static void AddFadeOut(this Storyboard storyboard, float seconds)
        {
            // Create the margin animate from right
            var animation = new DoubleAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = 1,
                To = 0,
            };
            // 타겟의 속성 이름을 설정함
            Storyboard.SetTargetProperty(animation, new PropertyPath("Opacity"));
            // 이 스토리보드에 추가하기
            storyboard.Children.Add(animation);
        }
    }
}