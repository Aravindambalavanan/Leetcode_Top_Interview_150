class Solution {
  public:
    bool isSubsequence(string s, string t) {
        if (s.length() > t.length())
            return false;
        if (s.length() == 0)
            return true;

        int l = 0;
        int r = 0;

        while (l < s.length() && r < t.length()) {
            if (s[l] == t[r])
                l++;
            r++;
        }

        return l == s.length();
    }
};
