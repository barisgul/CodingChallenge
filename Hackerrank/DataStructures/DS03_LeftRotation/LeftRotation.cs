using System;
using System.Linq;

namespace CodingChallenge.Hackerrank.DataStructures.DS03_LeftRotation 
{
    //https://www.hackerrank.com/challenges/array-left-rotation/problem
    public static class LeftRotation
    {
        public static int[] leftRotation(int n, int d) 
        {
            int[] numbers = new int[n];
            int[] rotatedNumbers = new int[n];
            if (n == 0)
                throw new Exception("Unknwon exception");

            else if (n == 1) 
                rotatedNumbers[0] = 1;

            //generate number array
            for (int i = 0; i < n; i++)
            {
                numbers[i] = i + 1;
            }

            //rotate to left
            
            for (int i = 0; i < d; i++)
            { 
                int firstValue = numbers[0];
                numbers = numbers.Skip(1).ToArray(); //remove from first
                var list = numbers.ToList();
                list.Add(firstValue);
                numbers = list.ToArray();
                rotatedNumbers = numbers; 
            }

            for (int i = 0; i < rotatedNumbers.Count(); i++)
            {
                Console.Write(rotatedNumbers[i] + " ");
            }
            return rotatedNumbers;

        }
    }


}
