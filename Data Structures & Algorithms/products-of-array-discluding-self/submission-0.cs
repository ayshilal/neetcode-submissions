public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
         int [] result = new int[nums.Length];
        int multiplyRight = 1;
        int multiplyLeft = 1;

        for (int i=0; i<nums.Length;i++)
        {
            result[i] = multiplyLeft;
            multiplyLeft *= nums[i];
        }

        for (int i=nums.Length-1; i>=0;i--)
        {
            result[i] *= multiplyRight;
            multiplyRight *= nums[i];
        }
        return result;
    }
}
