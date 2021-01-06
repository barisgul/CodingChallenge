using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Hackerrank.Algorithms.Strings
{
    public class Gemstones
    {
        //https://www.hackerrank.com/challenges/gem-stones/problem 
        #region Example call action
        //string[] arr = new string[] { "vtrjvgbj", "mkmjyaeav", "sibzdmsk" };
        //var result = Gemstones.gemstones(arr);
        #endregion
        public static int gemstones(string[] arr)
        {
            //Constraints
            if (arr.Length < 1 || 100 < arr.Length)
                throw new ArgumentOutOfRangeException(nameof(arr));

            foreach (var item in arr)
            {
                if(item.Length <1 || 100< item.Length)
                    throw new ArgumentOutOfRangeException(nameof(item));

                foreach (var c in item)
                {
                    if (!Char.IsLower(c))
                        throw new Exception("letter is not lowercase");

                    if(!IsLatin(c))
                        throw new Exception("letter is not basic latin case");
                }
            }

            char[] lettersToCheck = arr[0].ToCharArray();

            bool containsLetter = false;
            int gemstones = 0;

            var list = arr.ToList();
            list.RemoveAt(0);

            foreach (var item in lettersToCheck)
            {
                foreach (var str in list)
                {
                    if (str.Contains(item))
                    {
                        containsLetter = true;
                        continue;
                    }
                    else
                    {
                        containsLetter = false;
                        break;
                    }
                }

                if (containsLetter)
                    gemstones++;
            }

            return gemstones;
        }

        private static bool IsLatin(char c) 
        {
            return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z');
        }
    }
}
