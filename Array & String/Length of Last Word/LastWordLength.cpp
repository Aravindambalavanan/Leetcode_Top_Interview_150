class Solution {
public:
    int lengthOfLastWord(string s) {
        vector<string> words;
        istringstream iss(s);
        string word;

        while (iss >> word) {
            words.push_back(word);
        }

        if (words.empty()) {
            return 0;
        }

        return words.back().length();
    }
};