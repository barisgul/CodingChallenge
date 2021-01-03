using CodingChallenge.Hackerrank.Algorithms.A05_Staircase;
using CodingChallenge.Hackerrank.Algorithms.A06_MiniMaxSum;
using CodingChallenge.Hackerrank.Algorithms.A07_AVeryBigSum;
using CodingChallenge.Hackerrank.Algorithms.A08_TimeConversion;
using CodingChallenge.Hackerrank.Algorithms.Implementation;
using System.Collections.Generic;

namespace CodingChallenge
{
    class Program
    { 
        static void Main(string[] args)
        {
            List<int> grades = new List<int> { 33,35,73, 67, 38, 33 };
            var result = GradingStudents.gradingStudents(grades);
        }

    }
}
