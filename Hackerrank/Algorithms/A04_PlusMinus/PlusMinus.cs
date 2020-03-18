using System;

namespace CodingChallenge.Hackerrank.Algorithms.A04_PlusMinus 
{
    //https://www.hackerrank.com/challenges/plus-minus/problem
    #region Example Caller From Main 
    //int[] arr = new int[] { -4, 3, -9, 0, 4, 1 };
    //PlusMinus.plusMinus(arr);
    #endregion
    public static class PlusMinus
    {  
        public static void plusMinus(int[] arr)  
        {
            decimal length = arr.Length;
            decimal positiveCount = 0;
            decimal negativeCount = 0;
            decimal zeroCount = 0;
            decimal temp = (decimal)1 / length;

            foreach (var item in arr)
            {
                if (item > 0)
                    positiveCount++;
                else if (item < 0)
                    negativeCount++;
                else
                    zeroCount++;

            }
             
            Console.WriteLine(Math.Round(positiveCount * temp, 6));
            Console.WriteLine(Math.Round(negativeCount * temp, 6));
            Console.WriteLine(Math.Round(zeroCount * temp, 6)); 

        }
    }
}
