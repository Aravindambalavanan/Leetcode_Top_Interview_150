class Solution {
    public boolean isPalindrome(int x) {
        int temp = x, sum = 0;
        while (temp > 0) {
            int digit = temp % 10;
            sum = (sum * 10) + digit;
            temp = temp / 10;
        }

        if (sum == x)
            return true;

        return false;
    }
}