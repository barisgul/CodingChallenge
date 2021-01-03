using System;

namespace CodingChallenge.Hackerrank.Algorithms.A07_AVeryBigSum 
{
    public static class AVeryBigSum
    {
        //https://www.hackerrank.com/challenges/a-very-big-sum/problem
        #region Example Caller From Main 
        //long[] array = new long[] { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };
        //AVeryBigSum.aVeryBigSum(array);
        #endregion
        public static long aVeryBigSum(long[] ar) 
        {
            int count = ar.Length;
            
            //Constraits
            if (1 > count || count > 10)
                throw new ArgumentOutOfRangeException(nameof(count));

            foreach (var item in ar)
            {
                if (item < 0 || Math.Pow(10, 10) < item)
                    throw new ArgumentOutOfRangeException(nameof(item));
            }

            long result = 0;

            foreach (var item in ar)
            {
                result += item;
            }

            return result;
        }
    }
}
