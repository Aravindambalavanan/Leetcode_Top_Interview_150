impl Solution {
    pub fn remove_duplicates(nums: &mut Vec<i32>) -> i32 {
        let len = nums.len();
    
        if len <= 2 {
            return len as i32;
        }

        let mut unique_count = 2;

        for i in 2..len {
            if nums[i] != nums[unique_count - 2] {
                nums[unique_count] = nums[i];
                unique_count += 1;
            }
        }

        unique_count as i32
    }
}