using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingChallenge.Hackerrank.Algorithms.A06_MiniMaxSum 
{
    //https://www.hackerrank.com/challenges/mini-max-sum/problem
    #region Example Caller From Main 
    //int[] arr = new int[] { 1, 3, 5, 7, 9 };
    //MiniMaxSum.miniMaxSum(arr);
    #endregion
    public static class MiniMaxSum
    {
        public static void miniMaxSum(int[] arr) 
        {
            //Constraits
            foreach (var item in arr)
            {
                if (item < 1 || Math.Pow(10, 9) < item)
                    throw new ArgumentOutOfRangeException("Argument is out of range");
            }

            List<int> arrList = arr.ToList(); 

            arrList.Sort();

            long minSum = 0, maxSum = 0;

            //collect minSum
            for (int i = 0; i < arrList.Count - 1; i++)
            {
                minSum += arrList[i];
            }

            //collect maxSum
            for (int i = arrList.Count-1; i > 0; i--)
            {
                maxSum += arrList[i];
            }

            Console.WriteLine(String.Format("{0} {1}",minSum,maxSum));
        }
    }
}
