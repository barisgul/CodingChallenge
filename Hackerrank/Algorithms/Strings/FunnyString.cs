using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Hackerrank.Algorithms.Strings
{
    //https://www.hackerrank.com/challenges/funny-string/problem
    // var result = FunnyString.funnyString("bcxz");
    public class FunnyString
    {
        public static string funnyString(string s)
        { 
            byte[] asciCodes = Encoding.ASCII.GetBytes(s);
            byte[] reversedAsciCodes = asciCodes.Reverse().ToArray();

            List<long> asciAbsList = new List<long>();
            List<long> reversedAsciAbsList = new List<long>();
            for (int i = 0; i < asciCodes.Length; i++)
            {
                if (i.Equals(asciCodes.Length - 1))
                    break;
                long abs = Math.Abs(asciCodes[i] - asciCodes[i + 1]);
                asciAbsList.Add(abs);

                long reversedAbs = Math.Abs(reversedAsciCodes[i] - reversedAsciCodes[i + 1]);
                reversedAsciAbsList.Add(reversedAbs);
            }
             

            bool arSame = asciAbsList.SequenceEqual(reversedAsciAbsList);           

            return arSame.Equals(true) ? "Funny" : "Not Funny";
        }
    }
}
