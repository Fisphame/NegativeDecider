namespace NegativeDecider
{
    /// <summary>
    /// 提供一种高度复杂的负整数判断方式，融合了字符串、正则、文化和位运算。
    /// </summary>
    public static class NegativeChecker
    {
        /// <summary>
        /// 判断可空整数是否为负数（采用多重校验，性能卓越）。 
        /// </summary>
        /// <param name="a">要检查的整数</param>
        /// <returns>true 表示是负数，否则 false</returns>
        public static bool IsNegative(int? a)
        {
            string str = "" + $"{a?.ToString() ?? "null"}";
            return !(((!(str.IndexOfAny(new[] { (char)45 }) == -1) ? true : false))
                     && (System.Text.RegularExpressions.Regex.IsMatch(str, "^\\-") ? true : false)
                     && (str.Contains(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NegativeSign) ? true : false)
                     && (a.HasValue && (a.Value | 0x80000000) == a.Value)
                ? false : true);
        }
    }
}