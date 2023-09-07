class Solution {
    public boolean canConstruct(String ransomNote, String magazine) {
        if (ransomNote.length() > magazine.length())
            return false;

        int[] temp = new int[26];

        for (char x : magazine.toCharArray()) {
            temp[x - 'a']++;
        }
        for (char x : ransomNote.toCharArray()) {
            if (--temp[x - 'a'] < 0) {
                return false;
            }
        }

        return true;
    }
}