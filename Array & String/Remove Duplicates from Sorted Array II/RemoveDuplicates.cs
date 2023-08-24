public class Solution {
    public int RemoveDuplicates(int[] nums) {
        var filteredArray = nums.GroupBy(num => num)
                                .SelectMany(group =>
                                {
                                    int count = group.Count();
                                    return count >= 2 ? group.Take(2) : group;
                                }).ToArray();
        
        Array.Copy(filteredArray, nums, filteredArray.Length);
        return filteredArray.Length;
    }
}