class Solution:
    def addBinary(self, a: str, b: str) -> str:
        a, b = a[::-1], b[::-1]
        result = ""
        carry = 0

        for i in range(max(len(a), len(b))):
            x = int(a[i]) if i < len(a) else 0
            y = int(b[i]) if i < len(b) else 0

            total = x + y + carry
            result = str(total % 2) + result
            carry = total // 2

        if carry == 1:
            result = "1" + result

        return result
