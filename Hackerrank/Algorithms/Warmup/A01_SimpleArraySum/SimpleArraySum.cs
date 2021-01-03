using System;

namespace CodingChallenge.Hackerrank.Algorithms.A01_SimpleArraySum
{
    //https://www.hackerrank.com/challenges/simple-array-sum

    #region Example Caller From Main
    //int[] ar = new int[] { 3, 2, 2, 10 };
    //int sum = SimpleArraySum.ArraySum(ar);
    //Console.WriteLine(sum);
    #endregion
    public static class SimpleArraySum  
    {
        public static int ArraySum(int[] ar)  
        {          
            int sum = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                if (0 < ar.Length && 0 <= ar[i] && ar.Length <= 1000)
                    sum += ar[i];
                else
                    throw new Exception("array is out of range");
            }

            return sum;
        }

    }
}
