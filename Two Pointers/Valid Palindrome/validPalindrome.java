class Solution {
    public boolean isPalindrome(String s) {
        String fixed = "";

        for (char x : s.toCharArray()) {
            if (Character.isLetterOrDigit(x)) {
                fixed += x;
            }
        }
        fixed = fixed.toLowerCase();
        int i = 0;
        int j = fixed.length() - 1;

        while (i <= j) {
            if (fixed.charAt(i) != fixed.charAt(j)) {
                return false;
            }
            j--;
            i++;
        }
        return true;
    }
}