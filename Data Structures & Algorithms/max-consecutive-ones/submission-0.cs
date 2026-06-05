public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {

        int count = 0;
        int maxCount = 0;

        for (int i = 0 ;i <= nums.Length-1; i++)
        {
           if (nums[i] == 1)
              count ++;
           else if (nums[i] != 1)
              count = 0;

            if(count >= maxCount)
              maxCount = count;
        }
        return maxCount;
    }


}