using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Hackerrank.Algorithms.Implementation
{
    //https://www.hackerrank.com/challenges/breaking-best-and-worst-records/problem
    #region Example Caller From Main 
    //int[] scores = new int[] { 10, 5, 20, 20, 4, 5, 2, 25, 1 };
    //var result = BreakingTheRecords.breakingRecords(scores);
    #endregion
    public class BreakingTheRecords
    {
        public static int[] breakingRecords(int[] scores)
        {
            //Constraints 
            if (scores.Length < 1 || scores.Length > 1000)
                throw new ArgumentOutOfRangeException(nameof(scores.Length));


            //Constraints  
            foreach (var item in scores)
            {
                if (item < 0 || Math.Pow(10, 8) < item)
                    throw new ArgumentOutOfRangeException(nameof(item));
            }


            int highestScoreCount = 0;
            int lowestScoreCount = 0;
            int lowest = scores[0];
            int highest = scores[0];

            for (int i = 0; i < scores.Length; i++)
            {
                if (i.Equals(scores.Length - 1))
                {
                    if (highest < scores[i])
                    { 
                        highestScoreCount++;
                    }

                    if (lowest > scores[i])
                    { 
                        lowestScoreCount++;
                    }

                    break;
                }

                int nextScore = scores[i + 1];  
               
                if(highest < nextScore)
                {
                    highest = nextScore;
                    highestScoreCount++; 
                }

                if(lowest > nextScore)
                {
                    lowest = nextScore;
                    lowestScoreCount++; 
                }
            }

            var result = new int[] { highestScoreCount, lowestScoreCount };

            return result;
        }
    }
}