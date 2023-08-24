import java.util.Arrays;

class Solution {
    public int majorityElement(int[] nums) {
        Arrays.sort(nums);

        int n = nums.length;

        return nums[n / 2];
    }
}