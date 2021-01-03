using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingChallenge.Hackerrank.Algorithms.A03_DiagonalDifference 
{
    //https://www.hackerrank.com/challenges/diagonal-difference/problem
    #region Example Caller From Main 
    //List<List<int>> arr = new List<List<int>>()
    //    {
    //        new List<int>()
    //        {
    //            1,2,5
    //        },
    //        new List<int>()
    //        {
    //            4,5,6
    //        },
    //        new List<int>()
    //        {
    //            7,8,9
    //        }

    //    };
    //DiagonalDifference.diagonalDifference(arr);
    #endregion
    public static class DiagonalDifference
    {   
        public static int diagonalDifference(List<List<int>> arr)
        {
            int[][] arrays = arr.Select(a => a.ToArray()).ToArray();

            var primarySum = arrays.PrimaryDiagonal().Sum();
            var secondarySum = arrays.SecondaryDiagonal().Sum();

            int result = Math.Abs(primarySum-secondarySum);

            return result;
        }

        private static IEnumerable<T> PrimaryDiagonal<T>(this IEnumerable<T[]> values)
        {
            return values.Select((x, i) => x[i]);
        }

        private static IEnumerable<T> SecondaryDiagonal<T>(this IEnumerable<T[]> values)
        {
            return values.Reverse().Select((x, i) => x[i]);
        } 
    }
}
