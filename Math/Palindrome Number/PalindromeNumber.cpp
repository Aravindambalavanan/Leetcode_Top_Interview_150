class Solution {
public:
    bool isPalindrome(int x) {
        if (x < 0)
            return false;
        return x == reverse(x);
    }

    int reverse(int num) {
        int reversed = 0;
        while (num != 0) {
            int digit = num % 10;
            if (reversed > INT_MAX / 10 || (reversed == INT_MAX / 10 && digit > 7)) {
                return 0;
            }
            reversed = reversed * 10 + digit;
            num /= 10;
        }
        return reversed;
    }
};