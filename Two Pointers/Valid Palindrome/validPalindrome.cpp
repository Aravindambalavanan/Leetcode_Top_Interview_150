class Solution {
  public:
    bool isPalindrome(string s) {
        string cleaned = "";
        for (auto i : s) {
            if (isalnum(i))
                cleaned.push_back(tolower(i));
        }

        int l = 0;
        int r = cleaned.length() - 1;

        while (l < r) {
            if (cleaned[l] != cleaned[r])
                return false;
            l++;
            r--;
        }
        return true;
    }
};
