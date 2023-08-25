public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }
        
        Dictionary<char, int> counter1 = new Dictionary<char, int>();
        Dictionary<char, int> counter2 = new Dictionary<char, int>();
        
        foreach (char c in s) {
            if (counter1.ContainsKey(c)) {
                counter1[c]++;
            } else {
                counter1[c] = 1;
            }
        }
        
        foreach (char c in t) {
            if (counter2.ContainsKey(c)) {
                counter2[c]++;
            } else {
                counter2[c] = 1;
            }
        }
        
        return counter1.OrderBy(kv => kv.Key)
                       .SequenceEqual(counter2.OrderBy(kv => kv.Key));
    }
}