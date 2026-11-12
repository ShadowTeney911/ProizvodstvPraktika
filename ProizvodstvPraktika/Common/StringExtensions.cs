using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Это для задачи 16
namespace ProizvodstvPraktika.Common
{

    public static class StringExtensions
    {
        public static bool IsPalindrome(this string s)
        {
            string cleaned = "";
            foreach (char c in s)
            {
                if (char.IsLetterOrDigit(c))
                    cleaned += char.ToLower(c);
            }

            int left = 0;
            int right = cleaned.Length - 1;

            while (left < right)
            {
                if (cleaned[left] != cleaned[right])
                    return false;
                left++;
                right--;
            }

            return true;
        }

        public static int WordCount(this string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return 0;

            string[] words = s.Split(new char[] { ' ', '\t', '\n', '\r' },
                                     StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        public static string ReverseString(this string s)
        {
            string result = "";
            for (int i = s.Length - 1; i >= 0; i--)
                result += s[i];
            return result;
        }
    }
}