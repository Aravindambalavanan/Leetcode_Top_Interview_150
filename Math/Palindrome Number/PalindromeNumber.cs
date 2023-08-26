public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0)
            return false;
        return x == Reverse(x);
    }

    public static int Reverse(int num) {
        int reversed = 0;
        while (num != 0) {
            int digit = num % 10;
            reversed = reversed * 10 + digit;
            num /= 10;
        }
        return reversed;
    }
}