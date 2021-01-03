using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Hackerrank.Algorithms.Strings
{
    // https://www.hackerrank.com/challenges/camelcase/problem
    public class CamelCase
    {
        #region Example Caller From Main 
        //string s = "saveChangesInTheEditor";
        //CamelCase.camelcase(s);
        #endregion
        public static int camelcase(string s)
        {

            //Constraints
            if (s.Length < 1 || Math.Pow(10, 5) < s.Length)
                throw new ArgumentOutOfRangeException(nameof(s.Length));

            //solution
            char[] charArr = s.ToCharArray();
            int countOfWords = 0;
            foreach (var item in charArr)
            {
                if (Char.IsUpper(item))
                {
                    countOfWords++;
                }
            }

            return countOfWords +1;
        }
    }
}
