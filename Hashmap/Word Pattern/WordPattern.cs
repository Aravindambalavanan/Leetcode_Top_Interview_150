public class Solution {
    public bool WordPattern(string pattern, string s) {
        Dictionary<char, int> patternMap = new Dictionary<char, int>();
        Dictionary<string, int> wordMap = new Dictionary<string, int>();
        string[] words = s.Split(' ');
        int i = 0, n = pattern.Length;

        if (n != words.Length) {
            return false;
        }

        for (i = 0; i < n; i++) {
            char currPatternChar = pattern[i];
            string currWord = words[i];
            if (!patternMap.ContainsKey(currPatternChar)) {
                patternMap[currPatternChar] = i;
            }
            if (!wordMap.ContainsKey(currWord)) {
                wordMap[currWord] = i;
            }
            if (patternMap[currPatternChar] != wordMap[currWord]) {
                return false;
            }
        }
        return true;
    }
}