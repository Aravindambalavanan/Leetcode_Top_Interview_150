public class Solution {
    public IList<string> LetterCombinations(string digits) {
        Dictionary<char, string> phoneMap = new Dictionary<char, string> {
            {'2', "abc"},
            {'3', "def"},
            {'4', "ghi"},
            {'5', "jkl"},
            {'6', "mno"},
            {'7', "pqrs"},
            {'8', "tuv"},
            {'9', "wxyz"}
        };
        List<string> combinations = new List<string>();
        if (!string.IsNullOrEmpty(digits)) {
            GenerateCombinations(digits, 0, "", phoneMap, combinations);
        }
        return combinations;
    }

    private void GenerateCombinations(string digits, int index, string current,
                                       Dictionary<char, string> phoneMap,
                                       List<string> combinations) {
        if (index == digits.Length) {
            combinations.Add(current);
            return;
        }

        char digit = digits[index];
        if (phoneMap.ContainsKey(digit)) {
            string letters = phoneMap[digit];
            foreach (char letter in letters) {
                GenerateCombinations(digits, index + 1, current + letter, phoneMap, combinations);
            }
        }
    }
}