public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
          Dictionary<string, List<string>> anagramsGroups = new Dictionary<string, List<string>>();

        foreach(string word in strs)
        {
            char[] sortedWord = word.ToCharArray();
            Array.Sort(sortedWord);
            string sortedKey= new string(sortedWord);

            if(!anagramsGroups.ContainsKey(sortedKey))
               anagramsGroups.Add(sortedKey, new List<string>() { word });
            else
                anagramsGroups[sortedKey].Add(word);
        }
         return new List<List<string>>(anagramsGroups.Values);
    }
}
