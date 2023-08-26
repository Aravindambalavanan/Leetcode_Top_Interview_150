class Solution {
public:
    double myPow(double x, int n) {
        if (n == INT_MIN) {
            n = -(n + 1);
            x = 1.0 / x;
            return x * x * myPow(x * x, n / 2);
        }

        if (n == 0) {
            return 1.0;
        }

        if (n < 0) {
            x = 1.0 / x;
            n = -n;
        }

        if (n % 2 == 0) {
            double y = myPow(x, n / 2);
            return y * y;
        }
        else {
            double y = myPow(x, (n - 1) / 2);
            return y * y * x;
        }
    }
};