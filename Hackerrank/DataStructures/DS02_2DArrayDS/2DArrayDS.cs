using System.Collections.Generic;

namespace CodingChallenge.Hackerrank.DataStructures.DS02_2DArrayDS 
{
    //https://www.hackerrank.com/challenges/2d-array/problem
    public static class _2DArrayDS 
    {
        public static int HourglassSum(int[][] arr)
        {
            
            List<int> listOfHourGlasses = new List<int>();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int sumOfHourGlass = 0;
                    sumOfHourGlass += arr[i][j];
                    sumOfHourGlass += arr[i][j+1];
                    sumOfHourGlass += arr[i][j+2];
                    sumOfHourGlass += arr[i+1][j+1];
                    sumOfHourGlass += arr[i+2][j];
                    sumOfHourGlass += arr[i+2][j+1];
                    sumOfHourGlass += arr[i+2][j+2];


                    listOfHourGlasses.Add(sumOfHourGlass);
                }
            }

            //listOfHourGlasses.Sort((a, b) => b.CompareTo(a)); // descending sort
            listOfHourGlasses.Sort();
            listOfHourGlasses.Reverse();
            int maxOfHourGlasses = listOfHourGlasses[0];
            return maxOfHourGlasses;
        }
    }
}
