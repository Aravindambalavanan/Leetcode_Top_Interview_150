class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) {
        unordered_map<int, int> d;
        vector<int> result;
        for (int index = 0; index < nums.size(); ++index) {
            if (d.find(target - nums[index]) != d.end()) {
                result.push_back(d[target - nums[index]]);
                result.push_back(index);
                break;
            }
            d[nums[index]] = index;
        }
        return result;
    }
};