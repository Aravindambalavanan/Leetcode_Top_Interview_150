public class Solution {
    public double MyPow(double x, int n) {
        if (n == Int32.MinValue) {
            n = -(n + 1);
            x = 1.0 / x;
            return x * x * MyPow(x * x, n / 2);
        }
        
        if (n == 0) {
            return 1.0;
        }
        
        if (n < 0) {
            x = 1.0 / x;
            n = -n;
        }

        if (n % 2 == 0) {
            double y = MyPow(x, n / 2);
            return y * y;
        } 
        else {
            double y = MyPow(x, (n - 1) / 2);
            return y * y * x;
        }
    }
}