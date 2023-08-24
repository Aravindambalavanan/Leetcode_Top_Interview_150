public class Solution {
    public int RemoveDuplicates(int[] nums) {
        var uniqueArray = nums.Distinct().ToArray();
        Array.Copy(uniqueArray, nums, uniqueArray.Length);
        return uniqueArray.Length;
    }
}