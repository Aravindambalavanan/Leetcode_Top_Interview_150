public class Solution {
    public int RemoveElement(int[] nums, int val) {
        var filtered = nums.Where(num => num != val).ToArray();
        Array.Copy(filtered, nums, filtered.Length);
        return filtered.Length;
    }
}