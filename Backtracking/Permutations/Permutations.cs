public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        List<IList<int>> result = new List<IList<int>>();
        Array.Sort(nums);
        Permutations(result, nums, 0);
        return result;
    }

    private void Permutations(List<IList<int>> result, int[] nums, int index) {
        if (index == nums.Length) {
            result.Add(new List<int>(nums));
            return;
        }
        for (int i = index; i < nums.Length; ++i) {
            Swap(nums, index, i);
            Permutations(result, nums, index + 1);
            Swap(nums, index, i);
        }
    }

    private void Swap(int[] nums, int i, int j) {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}