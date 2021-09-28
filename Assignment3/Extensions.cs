using System;
using System.Collections.Generic;
using System.Linq;  
using System.Text.RegularExpressions;

namespace Assignment3
{
    public static class Extensions
    {
        public static IEnumerable<int> Flatten(this IEnumerable<int>[] xs) => xs.SelectMany(i => i);

        public static IEnumerable<int> Filter(this int[] ys) => ys.Where(i => i > 42).Where(i => i % 7 == 0);
        
        public static IEnumerable<int> IsLeapYear(this int[] ys) => ys.Where(i => DateTime.IsLeapYear(i));

        public static bool IsSecure(Uri uri) => (uri.Scheme.Contains("http")) && (uri.Scheme.Contains("https"));

        public static int WordCount(this string s) => Regex.Split(s, @"[\P{L}]+").Length;
    }


}
