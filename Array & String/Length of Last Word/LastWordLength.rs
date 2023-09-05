impl Solution {
    pub fn length_of_last_word(s: String) -> i32 {
        match s.trim().split_whitespace().last() {
            Some(word) => word.len() as i32,
            None => 0,
        }
    }
}