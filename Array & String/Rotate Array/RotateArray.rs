impl Solution {
    pub fn rotate(nums: &mut Vec<i32>, k: i32) {
        let k = k as usize % nums.len();
        let mut rotated = vec![0; nums.len()];
        for i in 0..nums.len() {
            rotated[(i + k) % nums.len()] = nums[i];
        }
        nums.clone_from_slice(&rotated);
    }
}