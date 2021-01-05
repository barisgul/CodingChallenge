using CodingChallenge.Hackerrank.Algorithms.A05_Staircase;
using CodingChallenge.Hackerrank.Algorithms.A06_MiniMaxSum;
using CodingChallenge.Hackerrank.Algorithms.A07_AVeryBigSum;
using CodingChallenge.Hackerrank.Algorithms.A08_TimeConversion;
using CodingChallenge.Hackerrank.Algorithms.Implementation;
using CodingChallenge.Hackerrank.Algorithms.Strings;
using System.Collections.Generic;

namespace CodingChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int> {2,6 };
            List<int> b = new List<int> {24,36 };
            var result = BetweenTwoSets.getTotalX(a, b);
        }

    }
}
