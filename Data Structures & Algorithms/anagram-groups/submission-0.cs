public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
    
      Dictionary<string, int> sorted = new Dictionary<string, int>();
      Dictionary<string, List<string>> anagramsGroups = new Dictionary<string, List<string>>();

        for (int i = 0; i < strs.Length; i++)
        {
            char[] a = strs[i].ToCharArray();
            Array.Sort(a);
            string word = new string(a);  

            if(sorted.ContainsKey(word))
            {
                int j = sorted[word];

                anagramsGroups[strs[j]].Add(strs[i]);

            }
            else 
            {
                sorted.Add(word,i);
                anagramsGroups[strs[i]] = new List<string>();
                anagramsGroups[strs[i]].Add(strs[i]);
            }
            
        }
         return new List<List<string>>(anagramsGroups.Values);
    }
}
