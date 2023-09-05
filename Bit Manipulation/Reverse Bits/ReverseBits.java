public class Solution {

    public int reverseBits(int n) {
        int result = 0;
        for (int i = 1; i <= 32; i++) {
            result += n & 1;
            n = n >> 1;
            if (i <= 31) {
                result = result << 1;
            }
        }
        return result;
    }
}