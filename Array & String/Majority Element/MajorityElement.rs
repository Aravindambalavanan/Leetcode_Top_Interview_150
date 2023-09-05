impl Solution {
    pub fn majority_element(nums: Vec<i32>) -> i32 {
        let mut mutable_nums = nums.clone();
        mutable_nums.sort();
        return mutable_nums[mutable_nums.len() / 2];
    }
}