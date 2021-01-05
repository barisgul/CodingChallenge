using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Hackerrank.Algorithms.Implementation
{
    //https://www.hackerrank.com/challenges/between-two-sets/problem
    #region Example Caller From Main 
    //List<int> a = new List<int> { 2, 6 };
    //List<int> b = new List<int> { 24, 36 };
    //var result = BetweenTwoSets.getTotalX(a, b);
    #endregion
    public class BetweenTwoSets
    {
        public static int getTotalX(List<int> a, List<int> b)
        {
            //Constraints
            if ((a.Count < 1 || 10 < a.Count) || (b.Count < 1 || 10 < b.Count))
                throw new ArgumentOutOfRangeException("Argument count is out of range");

            //Constraints
            foreach (var item in a)
            {
                if (item < 0 || item > 100)
                    throw new ArgumentOutOfRangeException(nameof(item));
            }

            //Constraints
            foreach (var item in b)
            {
                if (item < 0 || item > 100)
                    throw new ArgumentOutOfRangeException(nameof(item));
            }

            a.Sort();
            b.Sort();

            var totalXs = 0;
            var maximumA = a.Max(); //Time-complexity O(n)
            var minimumB = b.Min(); //Time-complexity O(m)
            var counter = 1;
            var multipleOfMaxA = maximumA;

            while (multipleOfMaxA <= minimumB)
            {
                var factorOfAll = true;

                foreach (var item in a) //Time complexity O(n)
                {
                    if (multipleOfMaxA % item != 0)
                    {
                        factorOfAll = false;
                        break;
                    }
                }

                if (factorOfAll)
                {
                    foreach (var item in b) //Time complexity O(m)
                    {
                        if (item % multipleOfMaxA != 0)
                        {
                            factorOfAll = false;
                            break;
                        }
                    }
                }

                if (factorOfAll)
                    totalXs++;

                counter++;
                multipleOfMaxA = maximumA * counter; //Here counter is the x factor which contributes to O(x(n+m)) complexity.
            }
            return totalXs;
        }
    }
}
