public class Solution {
    public int LongestConsecutive(int[] nums) {
    
          HashSet<int> set = new HashSet<int>(nums);
            int longest = 0;
            int count = 0;
            
            foreach( int number in set)
            {
                int prev = number;
                count = 0;
                while(set.Contains(prev))
                {
                    count++;
                    prev++;
                }
                longest = Math.Max(count, longest);

            }
            return longest;
               
    }
}
