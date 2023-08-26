class Solution:
    def mySqrt(self, x: int) -> int:
        if x == 0 or x == 1:
            return x

        guess = x
        while abs(x - guess * guess) > 1e-6:
            guess = (guess + (x / guess)) / 2
        return math.floor(guess)
