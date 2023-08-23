public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> d = new Dictionary<int, int>();
        int[] result = new int[2];
        for (int index = 0; index < nums.Length; ++index) {
            if (d.ContainsKey(target - nums[index])) {
                result[0] = d[target - nums[index]];
                result[1] = index;
                break;
            }
            d[nums[index]] = index;
        }
        return result;
    }
}