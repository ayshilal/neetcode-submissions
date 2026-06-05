public class Solution {
    public bool IsAnagram(string s, string t) {
       
    bool isAnagram = false;

    if (s.Length == t.Length)
    {
        char[] sArray = s.ToCharArray();
        char[] tArray = t.ToCharArray();
        Array.Sort(sArray);
        Array.Sort(tArray);

        for (int i = 0; i < sArray.Length; i++)
        {
            if (sArray[i] == tArray[i]){
              isAnagram = true;
              continue;
            }
            else {
                isAnagram = false;
                break;
            }
        }
    }

    return isAnagram;
    }
    
}


// racecar and carrace 
// we check the letters and we check freq of each letter
// 2 Rs, 2 Cs, 2 As, 1 E. 

// 