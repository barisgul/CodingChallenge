using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Hackerrank.Algorithms.Implementation
{
    #region Example Caller From Main 
    //int x1 = 0, v1 = 3, x2 = 4, v2 = 2;
    //string result = NumberLineJumps.kangaroo(x1, v1, x2, v2);
    #endregion

    //https://www.hackerrank.com/challenges/kangaroo/problem
    public class NumberLineJumps
    {
        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            //Constraints
            if (0 > x1 || x1 > 10000)
                throw new ArgumentOutOfRangeException(nameof(x1));

            if (0 > x2 || x2 > 10000)
                throw new ArgumentOutOfRangeException(nameof(x2));

            if (1 > v1 || v1 > 10000)
                throw new ArgumentOutOfRangeException(nameof(v1));

            if (1 > v2 || v2 > 10000)
                throw new ArgumentOutOfRangeException(nameof(v2));

            int jumpCount = 0;
            int location1 = Math.Abs(v1 + x1);
            int location2 = Math.Abs(v2 + x2);
            string status = "NO";
            for (int i = 0; i < 10000; i++)
            {
                jumpCount ++;                

                if (location1.Equals(location2))
                {
                    status = "YES";
                    break;
                }

                location1 = location1 + v1;
                location2 = location2 + v2;
            }  

            return status;
        }
    }
}
