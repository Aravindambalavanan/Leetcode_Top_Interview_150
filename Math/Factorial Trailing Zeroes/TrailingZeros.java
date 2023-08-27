class Solution {
    public int trailingZeroes(int n) {
        int sum = 0;

        if (n < 5) {
            return 0;
        }
        while (n >= 5) {
            sum = sum + n / 5;
            n = n / 5;
        }
        return sum;
    }

}