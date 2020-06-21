using System;

namespace huiwen
{
    class Program
    {

        /// <summary>
        /// 过滤非字母以外的字符串
        /// </summary>
        /// <returns>过滤后的字符串</returns>
        /// <param name="s">待过滤的字符串</param>
        private static string FilterCharacter(string s)
        {
            var res = string.Empty;
            s = s.ToLower().Trim();
            s.ToList().ForEach(c =>
            {
                if ((c >= 48 && c <= 57) || (c >= 97 && c <= 122)) 
                {
                    res += c;
                }
            });
            return res;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
