class Solution {
public:
    bool canConstruct(string ransomNote, string magazine) {
        unordered_map<char, int> charCount;
        for (char word : magazine)
            charCount[word]++;

        for (char word : ransomNote)
            charCount[word]--;

        for (const auto& entry : charCount) {
            if (entry.second < 0)                
                return false;
        }
        return true;
    }
};