using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Hackerrank.Algorithms.Strings
{

    #region Example Caller From Main 
    //int n =3;
    // string passwprd = "Ab1",
    //StrongPassword.strongPassword(n,password);
    #endregion
    public class StrongPassword
    {
        static bool hasNumer;
        static bool hasLowerCase;
        static bool hasUpperCase;
        static bool hasSpecialCharacter;
        public static int strongPassword(int n, string password)
        {
            //Constraints 
            if (n < 1 || 100 < n)
                throw new ArgumentOutOfRangeException(nameof(n));

            //solution
            string numbers = "0123456789";
            string lower_case = "abcdefghijklmnopqrstuvwxyz";
            string upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string special_characters = "!@#$%^&*()-+";

            hasNumer = CheckCondition(password, numbers);
            hasLowerCase = CheckCondition(password, lower_case);
            hasUpperCase = CheckCondition(password, upper_case);
            hasSpecialCharacter = CheckCondition(password, special_characters);
             
            int originalLength = password.Length;
            int length = password.Length;
            if (!hasNumer)
                length++;
            if (!hasLowerCase)
                 length++;
            if (!hasUpperCase)
                length++;
            if (!hasSpecialCharacter)
                length++;

            while (length < 6)
            {
                length++;
            }

            return length-originalLength;
        }

        private static bool CheckCondition(string password, string contidionStr)
        {  
            bool status = password.IndexOfAny(contidionStr.ToCharArray()) >= 0; 

            return status;
        }
    }
}
