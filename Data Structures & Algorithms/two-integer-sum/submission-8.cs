public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] result = new int[2];

        var seen = new Dictionary<int, int>();  
        
        for (int i = 0; i < nums.Length; i++) {
            int need = target - nums[i];

            if (seen.TryGetValue(need, out int j)) {
                return [j,i];
            }

            seen[nums[i]] = i;
        }

        return [-1,-1];
    }
}
