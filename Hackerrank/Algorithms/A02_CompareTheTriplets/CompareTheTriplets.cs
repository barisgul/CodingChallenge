using System;
using System.Collections.Generic;

namespace CodingChallenge.Hackerrank.Algorithms.A02_CompareTheTriplets 
{
    //https://www.hackerrank.com/challenges/compare-the-triplets/problem
    #region Example Caller From Main
    //List<int> alice = new List<int> { 3, 5, 17 };
    //List<int> bob = new List<int> { 3, 5, 5 };

    //var result = CompareTheTriplets.CompareTriplets(alice, bob);
    #endregion

    public static class CompareTheTriplets 
    { 
        public static List<int> CompareTriplets(List<int> a, List<int> b)
        { 
            List<int> result = new List<int>();

            int alicePoint = 0;
            int bobPoint = 0;

            for (int i = 0; i < 3; i++)
            {
                if ((1 <= a[i] && 1 <= b[i]) || (a[i] <= 100 && b[i] <= 100)) //Constraints 
                {
                    if (a[i] == b[i])
                        continue;
                    else if (a[i] > b[i])
                        alicePoint++;
                    else if (b[i] > a[i])
                        bobPoint++;
                }
                else
                    throw new Exception("lists are out of range");
                    
            }

            result.Add(alicePoint);
            result.Add(bobPoint);
            
            return result;
        }
    }
}
