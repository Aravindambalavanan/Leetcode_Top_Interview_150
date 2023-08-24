class Solution {
    public int removeDuplicates(int[] nums) {
        int j = 0;

        for (int i = 0; i < nums.length; i++) {
            if (i < nums.length - 1 && nums[i] == nums[i + 1]) {
                continue;
            } else {
                nums[j++] = nums[i];
            }
        }
        return j;
    }
}