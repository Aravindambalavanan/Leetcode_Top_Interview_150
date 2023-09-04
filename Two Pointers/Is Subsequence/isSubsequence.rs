impl Solution {
    pub fn is_subsequence(s: String, t: String) -> bool {
        let mut t_chars: Vec<char> = t.chars().collect();
        for c in s.chars() {
            if let Some(i) = t_chars.iter().position(|&x| x == c) {
                t_chars = t_chars[(i + 1)..].to_vec();
            } else {
                return false;
            }
        }
        true
    }
}