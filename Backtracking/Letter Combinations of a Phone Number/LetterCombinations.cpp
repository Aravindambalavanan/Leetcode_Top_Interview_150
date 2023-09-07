class Solution {
public:
    vector<string> letterCombinations(const string& digits) {
        const unordered_map<char, string> phoneMap = {
            {'2', "abc"},
            {'3', "def"},
            {'4', "ghi"},
            {'5', "jkl"},
            {'6', "mno"},
            {'7', "pqrs"},
            {'8', "tuv"},
            {'9', "wxyz"}
        };
        vector<string> combinations;
        if (!digits.empty()) {
            generateCombinations(digits, 0, "", phoneMap, combinations);
        }
        return combinations;
    }

private:
    void generateCombinations(const string& digits, size_t index, const string& current,
                              const unordered_map<char, string>& phoneMap,
                              vector<string>& combinations) {
        if (index == digits.length()) {
            combinations.push_back(current);
            return;
        }

        char digit = digits[index];
        if (phoneMap.find(digit) != phoneMap.end()) {
            const string& letters = phoneMap.at(digit);
            for (char letter : letters) {
                generateCombinations(digits, index + 1, current + letter, phoneMap, combinations);
            }
        }
    }
};