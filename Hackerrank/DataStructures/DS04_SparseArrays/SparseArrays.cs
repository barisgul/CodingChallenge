namespace CodingChallenge.Hackerrank.DataStructures.DS04_SparseArrays 
{
    public static class SparseArrays
    {
        public static int[] MatchingStrings(string[] strings, string[] queries)
        { 
            int[] matchedStr = new int[queries.Length];
             
            int i = 0; 
            matchedStr[i] = 0;
            foreach (var query in queries)
            {
                foreach (var str in strings)
                {
                    if(query.Equals(str))
                    {
                        matchedStr[i] = matchedStr[i] +1 ;
                    }
                }
                i++;
            } 

            return matchedStr;

        }
    }
}
