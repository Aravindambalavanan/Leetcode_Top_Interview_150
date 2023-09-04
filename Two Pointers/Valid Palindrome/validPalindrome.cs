public class Solution {
    public bool IsPalindrome(string s) {
        string res = new string(s.Where(char.IsLetterOrDigit).ToArray()).ToLower();
        return res == new string(res.Reverse().ToArray());
    }
}