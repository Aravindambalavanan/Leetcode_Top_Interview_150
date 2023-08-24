class Solution {
public:
    int removeDuplicates(vector<int>& nums) {
        set<int> result(nums.begin(), nums.end());       
        nums.assign(result.begin(), result.end());
        return nums.size();
    }
};