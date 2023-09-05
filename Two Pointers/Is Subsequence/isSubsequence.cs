public class Solution {
    public bool IsSubsequence(string s, string t) {
        foreach (char c in s) {
            int i = t.IndexOf(c);
            if (i == -1) {
                return false;
            }
            t = t.Substring(i + 1);
        }
        return true;
    }
}