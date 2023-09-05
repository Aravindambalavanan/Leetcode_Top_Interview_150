public class Solution {

    public int hammingWeight(int n) {
        int count = 0, mask = 1;
        for (int i = 1; i <= 32; i++) {
            if ((n & mask) != 0) {
                count++;
            }
            mask = mask << 1;
        }
        return count;
    }
}