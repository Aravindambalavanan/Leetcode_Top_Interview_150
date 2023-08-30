public class Solution {
    public int LengthOfLastWord(string s) {
        return s.TrimEnd().Split(" ").Last().Length;
    }
}