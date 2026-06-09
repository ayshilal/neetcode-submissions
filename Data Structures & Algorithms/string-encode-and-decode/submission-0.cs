public class Solution {

     public string Encode(List<string> strs) {
        string encoded = "";
        foreach (string word in strs)
            encoded += word.Length + "#" + word;
        return encoded;
    }

    public List<string> Decode(string s) {
        List<string> strs = new();
        int i = 0;
        while (i < s.Length) {
            int j = i;
            while (s[j] != '#') j++;          // find the delimiter
            int len = int.Parse(s[i..j]);     // length before '#'
            strs.Add(s.Substring(j + 1, len)); // grab exactly len chars
            i = j + 1 + len;                   // jump past this word
        }
        return strs;
    }
}
