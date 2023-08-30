class Solution {
public:
    string reverseWords(string s) {
        vector<string> words;
        istringstream iss(s);
        string word;
        
        while (iss >> word) {
            words.push_back(word);
        }

        ostringstream oss;
        for (int i = words.size() - 1; i >= 0; --i) {
            oss << words[i];
            if (i > 0) {
                oss << " ";
            }
        }
        
        return oss.str();
    }
};