public class Solution {
    public int[] TwoSum(int[] nums, int target) {
    int[] result = new int[2];
    
    var seen = new Dictionary<int, int>();   // value -> index
    
    for (int i = 0; i < nums.Length; i++) {
        int complement = target - nums[i];
        seen[complement] = nums[i];
        
        if (i != 0 && complement == seen.GetValueOrDefault(nums[i]) && Array.IndexOf(nums, complement) != i) {
            result[0] = Array.IndexOf(nums, complement);
            result[1] = i;
            break;
        }
        
    }

    return result;
    }
}
