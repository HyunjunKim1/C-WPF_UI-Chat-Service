using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Hamamatsu.chatword
{
    /// <summary>
    /// Expressions을 도와주는 헬퍼클래스
    /// </summary>
    public static class ExpressionHelpers
    {
        /// <summary>
        /// expression을 컴파일하고 반환값을 가져옴
        /// </summary>
        /// <typeparam name="T">return value의 타입</typeparam>
        /// <param name="lamba">expression complie</param>
        /// <returns></returns>
        public static T GetPropertyValue<T>(this Expression<Func<T>> lamba)
        {
            return lamba.Compile().Invoke();
        }

        /// <summary>
        /// 속성을 포함하는 식에서 기본 속성 값을 지정된 값으로 설정해주는코드
        /// </summary>
        /// <typeparam name="T">The type of Value to set</typeparam>
        /// <param name="lamba">The expression</param>
        public static void SetPropertyValue<T>(this Expression<Func<T>> lamba, T value)
        {
            // Converts a lamba () => some.Property, to some.Property
            var expression = (lamba as LambdaExpression).Body as MemberExpression;

            // 속성정보를 얻고 설정할수있음
            var propertyInfo = (PropertyInfo)expression.Member;
            var target = Expression.Lambda(expression.Expression).Compile().DynamicInvoke();

            // 속성값 설정
            propertyInfo.SetValue(target, value);
        }
    }
}