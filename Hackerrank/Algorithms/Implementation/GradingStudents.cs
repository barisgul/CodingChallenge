using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Hackerrank.Algorithms.Implementation
{
    public static class GradingStudents
    {
        #region Example Caller From Main 
        //List<int> grades = new List<int> {73, 67, 38, 33}
        //GradingStudents.gradingStudents(grades);
    #endregion
    public static List<int> gradingStudents(List<int> grades)
        {
            //Constraits for count
            if (grades.Count < 1 || 60 < grades.Count)
                throw new ArgumentOutOfRangeException(nameof(grades));

            //Constraits for item
             foreach (var item in grades)
            {
                if (item < 0 || 100 < item)
                    throw new ArgumentOutOfRangeException(nameof(item));
            }

            List<int> gradedStudents = new List<int>();


            foreach (var item in grades)
            {
                int finalGrade;
                if (item < 38)
                {
                    finalGrade = item;
                    gradedStudents.Add(finalGrade);
                    continue;
                }
                    

                if (item % 5 == 0)
                    finalGrade = item;

                else
                {
                    finalGrade = RoundToUp(item);
                }

                gradedStudents.Add(finalGrade);
            }

            return gradedStudents;
        }

        private static int RoundToUp(int grade)
        {
            int roundedGrade = grade;
            for (int i = 0; i < 2; i++)
            {
                roundedGrade++;
                if (roundedGrade % 5 == 0)
                    break;
            }

            if (roundedGrade % 5 == 0)
                return roundedGrade;
            return grade;
        }
    }
}
