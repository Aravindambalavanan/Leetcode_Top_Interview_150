class Solution:
    def evalRPN(self, tokens: List[str]) -> int:
        operands = {
            '+': lambda x, y: x + y,
            '-': lambda x, y: x - y,
            '/': lambda x, y: int(x / y),
            '*': lambda x, y: x * y,
        }

        stack = []
        for token in tokens:
            if token in operands:
                x = stack.pop()
                y = stack.pop()
                result = operands[token](y, x)
                stack.append(result)
            else:
                stack.append(int(token))
        return stack.pop()