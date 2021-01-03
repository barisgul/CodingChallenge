using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Hackerrank.Algorithms.Implementation
{
    //https://www.hackerrank.com/challenges/minimum-distances/problem

    #region Example Caller From Main 
    //int[] a = new int[] { 7, 1, 3, 4, 1, 7 };
    //MinimumDistances.minimumDistances(a);
    #endregion
    public static class MinimumDistances
    {
        public static int minimumDistances(int[] a)
        {

            //constraits 
            if (a.Length < 1 || a.Length > Math.Pow(10, 3))
                throw new ArgumentOutOfRangeException(nameof(a.Length));

            foreach (var item in a)
            {
                if (item < 1 || Math.Pow(10, 5) < item)
                    throw new ArgumentOutOfRangeException(nameof(item));
            }

            //solution
            List<int> minDistances = new List<int>();
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j].Equals(a[i]))
                    {
                        int minDistance = Math.Abs(i - j);
                        minDistances.Add(minDistance);
                    }
                }
            }

            minDistances.Sort();

            if (minDistances.Count > 0 && minDistances[0] > -1)
                return minDistances[0]; 
            return -1;
        }
    }
}
