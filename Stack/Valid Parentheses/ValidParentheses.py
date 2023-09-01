class Solution:
    def isValid(self, s: str) -> bool:
        if (len(s) % 2 != 0):
            return False

        pairs = {
            "}": "{",
            "]": "[",
            ")": "("
        }
        stack = []
        
        for i in s:
            if i in pairs:
                if len(stack) > 0 and pairs[i] == stack[-1]:
                    stack.pop()
                else:
                    return False
            else:
                stack.append(i)

        return len(stack) == 0
