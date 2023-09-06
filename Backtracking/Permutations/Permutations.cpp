class Solution {
public:
    vector<vector<int>> permute(vector<int>& nums) {
        vector<vector<int>> result;
        sort(nums.begin(), nums.end());
        permutations(result, nums, 0);
        return result;
    }

private:
    void permutations(vector<vector<int>>& result, vector<int>& nums, int index) {
        if (index == nums.size()) {
            result.push_back(nums);
            return;
        }
        for (int i = index; i < nums.size(); ++i) {
            swap(nums[index], nums[i]);
            permutations(result, nums, index + 1);
            swap(nums[index], nums[i]);
        }
    }
};