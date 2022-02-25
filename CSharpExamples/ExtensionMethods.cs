using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamples.Extensions
{


    public static class Utils
    {
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }

        public static DateTime DaysFromToday(this int days)
        {
            return DateTime.Now.AddDays(days);
        }

        public static int CountVowels(this string sentence)
        {
            var vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };
            var total = 0;
            foreach (var letter in sentence)
            {
                if (vowels.Contains(letter))
                {
                    total += 1;
                }
            }
            return total;
        }
    }
}

