impl Solution {
    pub fn is_palindrome(s: String) -> bool {
        let cleaned = s
            .chars()
            .filter(|c| c.is_ascii_alphanumeric())
            .collect::<String>()
            .to_lowercase();
        let reversed = cleaned.chars().rev().collect::<String>();
        cleaned == reversed
    }
}