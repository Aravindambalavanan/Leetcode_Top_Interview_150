class Solution {
    public int strStr(String haystack, String needle) {
        for (int i = 0; i < haystack.length(); i++) {
            if (haystack.charAt(i) == needle.charAt(0)) {
                int j = 0;
                int k = i;
                while (k < haystack.length() && j < needle.length() && haystack.charAt(k) == needle.charAt(j)) {
                    k++;
                    j++;
                    if (j == needle.length())
                        return i;
                }
            }
        }
        return -1;
    }
}