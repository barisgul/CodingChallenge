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
    }
}
