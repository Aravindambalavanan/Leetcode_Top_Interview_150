class Solution:
    def trailingZeroes(self, n: int) -> int:
        if n < 5:
            return 0

        count = 0
        for i in range(1, n + 1):
            j = i
            while j % 5 == 0:
                count += 1
                j //= 5
        return count
