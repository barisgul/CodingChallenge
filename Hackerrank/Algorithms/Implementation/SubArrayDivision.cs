using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Hackerrank.Algorithms.Implementation
{
    //https://www.hackerrank.com/challenges/the-birthday-bar/problem
    public class SubArrayDivision
    {
        public static int birthday(List<int> s, int d, int m)
        {

            int ways = 0;
            int sum = 0;
            //Find if there is a way to break the chocolate at all
            if (m <= s.Count)
                for (int i = 0; i < m; i++)
                    sum += s[i];
            if (sum == d) ways++;
            ///////////////////////////////////////////////////////

            //Check other possible ways to break it by using a sliding window
            for (int i = 0; i < s.Count - m; i++)
            {
                sum = sum - s[i] + s[i + m];
                if (sum == d) ways++;
            }
            return ways;
        }
    }
}
