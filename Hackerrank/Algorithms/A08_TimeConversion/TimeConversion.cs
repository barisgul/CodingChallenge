using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Hackerrank.Algorithms.A08_TimeConversion
{
    //https://www.hackerrank.com/challenges/time-conversion/problem
    public static class TimeConversion
    {
        #region Example Caller From Main 
        //string s = "07:05:45PM";
        //TimeConversion.timeConversion(s);
        #endregion

        public static string timeConversion(string time)
        {
            FormatType formatType;
            string response = "";
            
            if (time.Contains("AM"))
                formatType = FormatType.AM;
            else
                formatType = FormatType.PM;

            char splitChar = formatType.ToString()[0];
            string[] timeWithoutType = time.Split(splitChar);
            string[] timeValues = timeWithoutType[0].Split(':');

            if (formatType.Equals(FormatType.PM))
            {
                string newHour = "";
                if (timeValues[0].Equals("12"))
                    newHour = "12";
                else
                {
                    newHour = (int.Parse(timeValues[0]) + 12).ToString();
                }
                response = newHour + ":" + timeValues[1] + ":" + timeValues[2];
            }
            if (formatType.Equals(FormatType.AM))
            {
                string newHour = "";
                if (timeValues[0].Equals("12"))
                {
                    newHour = "00";
                    response = newHour + ":" + timeValues[1] + ":" + timeValues[2];
                    return response;
                }

                response = timeWithoutType[0];
            }
                

            return response;
        }

        private enum FormatType
        {
            AM,
            PM
        }
    }
}
