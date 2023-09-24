public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        Dictionary<char, int> charCount = new Dictionary<char, int>();
        foreach (char word in magazine) {
            if (charCount.ContainsKey(word)) {
                charCount[word]++;
            } else {
                charCount[word] = 1;
            }
        }

        foreach (char word in ransomNote) {
            if (charCount.ContainsKey(word)) {
                charCount[word]--;
            } else {
                charCount[word] = -1;
            }
        }

        foreach (var entry in charCount) {
            if (entry.Value < 0) {
                return false;
            }
        }

        return true;
    }
}