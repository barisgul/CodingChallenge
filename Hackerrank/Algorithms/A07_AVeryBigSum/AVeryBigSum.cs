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
            char[] c = ar[0].ToString().ToCharArray(); 
            
            if (1 > count || count > 10)
                throw new Exception("out of range");
            int zero = 0;
            long lastIndex = 0;
            
            string s = string.Empty;
            foreach (var item in c)
            {
                if (item.Equals('0'))
                {
                    zero++;
                    s += item.ToString();
                }   
            }

            if (s.Length.Equals(8))
                s = s.Remove(s.Length - 1);

            foreach (var item in ar)
            {
                var index = item % 10;
                lastIndex += index;
            }

            string temp = count + s + lastIndex;
            long result = Convert.ToInt64(temp);

            return result ;
        }
    }
}
