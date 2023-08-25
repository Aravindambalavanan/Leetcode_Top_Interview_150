class Solution {
    public boolean isAnagram(String s, String t) {
        if (s.length() != t.length())
            return false;

        int[] charCount = new int[26];

        for (int x : s.toCharArray()) {
            charCount[x - 'a']++;
        }
        for (int x : t.toCharArray()) {
            charCount[x - 'a']--;
        }
        for (int i : charCount) {
            if (i != 0) {
                return false;
            }
        }
        return true;
    }
}