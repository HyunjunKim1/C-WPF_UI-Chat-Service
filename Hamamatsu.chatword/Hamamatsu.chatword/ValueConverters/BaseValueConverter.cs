using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace Hamamatsu.chatword.ValueConverters
{
    /// <summary>
    /// 직접 XAML 사용을 허용하는 기본 값 변환기
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class BaseValueConverter<T> : MarkupExtension, IValueConverter
        where T : class, new()
    {
        #region Private Members
        //이 Converter에 정적 인스턴스
        private static T mConverter = null;

        #endregion

        #region Markup Extension Methods

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return mConverter ?? (mConverter = new T());
        }
        #endregion

        #region Value Converter Methods

        //하나를 다른 타입으로 바꾸는거
        public abstract object Convert(object value, Type targetType, object parameter, CultureInfo culture);

        //값을 다시 이전타입으로 바꾸는거
        public abstract object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);
        
        #endregion
    }
}
