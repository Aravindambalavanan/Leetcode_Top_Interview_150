class Solution {
public:
    bool isAnagram(string s, string t) {
        if (s.length() != t.length()) {
            return false;
        }
        map<char, int> counter1, counter2;
        for(char c : s) {
            counter1[c]++;
        }
        for(char c : t) {
            counter2[c]++;
        }
        return counter1 == counter2;
    }
};