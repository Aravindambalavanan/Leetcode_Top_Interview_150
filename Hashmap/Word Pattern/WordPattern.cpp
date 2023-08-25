class Solution {
public:
    bool wordPattern(string pattern, string s) {
        unordered_map<char, int> patternMap;
        unordered_map<std::string, int> wordMap;
        istringstream input(s);
        string word;
        int i = 0, n = pattern.size();
        for (; input >> word; ++i) {
            if (i == n || patternMap[pattern[i]] != wordMap[word]) {
                return false;
            } 
            patternMap[pattern[i]] = wordMap[word] = i + 1;
        }
        return i == n; 
    }
};