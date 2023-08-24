public class Solution {
    public int MajorityElement(int[] nums) {
        Array.Sort(nums);
        return nums[(int)nums.Length / 2];
    }
}