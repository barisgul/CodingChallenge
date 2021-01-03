using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingChallenge.Hackerrank.DataStructures.DS01_ArraysDS 
{
    //https://www.hackerrank.com/challenges/arrays-ds/problem

    #region Example Caller From Main 
    //int[] ar = new int[] { 2, 3, 6, 8 };
    //var reversed = ArraysDS.ReverserArray(ar);
    #endregion
    public static class ArraysDS
    {
        public static int[] ReverserArray(int[] a)
        {
            //cosntraits
            if(a.Length < 1 && 1000 > a.Length) 
            {
                throw new ArgumentOutOfRangeException("Array Count is out of range");
            }
            foreach (var item in a)
            {
                if (item < 1 && 10000 > item)
                    throw new ArgumentOutOfRangeException("Array item is out of range");
            }

            List<int> list = a.ToList();
            list.Reverse();

            int[] newArr = list.ToArray<int>();

            return newArr;
        }
    }
}
