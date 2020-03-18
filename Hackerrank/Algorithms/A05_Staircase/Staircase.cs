using System;

namespace CodingChallenge.Hackerrank.Algorithms.A05_Staircase
{
    //https://www.hackerrank.com/challenges/staircase/problem
    #region Example Caller From Main 
    //Staircase.staircase(4);
    #endregion
    public static class Staircase
    {
        public static void staircase(int n)
        {

            //constraits
            if (0 > n || n > 100)
                throw new Exception("n is out of range");

            for (int i = 0; i < n; i++)
            {
                int k = i + 1;
                for (int j = n - i - 1; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int m = 0; m < k; m++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}
