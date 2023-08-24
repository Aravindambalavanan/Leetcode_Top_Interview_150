class Solution {
public:
    int removeDuplicates(vector<int>& nums) {
        if (nums.size() <= 2) {
            return nums.size();
        }
        int uniqueCount = 2;
        for (int i = 2; i < nums.size(); i++) {
            if (nums[i] != nums[uniqueCount - 2]) {
                nums[uniqueCount] = nums[i];
                uniqueCount++;
            }
        }
        return uniqueCount;
    }
};