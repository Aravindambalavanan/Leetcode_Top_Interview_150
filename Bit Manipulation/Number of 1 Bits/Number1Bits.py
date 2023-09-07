class Solution:
    def hammingWeight(self, n: int) -> int:
        result = 0

        for i in range(32):
            bit = (n >> i) & 1
            if bit == 1:
                result += 1

        return result
