class Solution:
    def calculate(self, s: str) -> int:
        output, curr, sign, stack = 0, 0, 1, []
        for i in range(len(s)):
            c = s[i]
            if c.isdigit():
                curr = (curr * 10) + int(c)
            elif c in "+-":
                output += curr * sign
                curr = 0
                sign = 1 if c == "+" else -1
            elif c == "(":
                stack.append(output)
                stack.append(sign)
                output = 0
                sign = 1
            elif c == ")":
                output += curr * sign
                output *= stack.pop()
                output += stack.pop()
                curr = 0
        return output + (curr * sign)
