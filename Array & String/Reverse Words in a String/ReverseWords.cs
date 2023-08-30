public class Solution {
    public string ReverseWords(string s) {
        return String.Join(" ", s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse());
    }
}