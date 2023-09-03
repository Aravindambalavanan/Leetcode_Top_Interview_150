class Solution {
  public:
    int calculate(string s) {
        stack<int> stack;

        long result = 0;
        auto sign = 1;
        long number = 0;

        for (auto i = 0; i < s.size(); i++) {
            switch (s[i]) {
            case ' ':
                continue;

            case '+':
            case '-':
                result += number * sign;
                sign = s[i] == '+' ? 1 : -1;
                number = 0;
                break;

            case '(':
                stack.push(result);
                stack.push(sign);
                result = 0;
                sign = 1;
                break;

            case ')':
                result += number * sign;
                result *= stack.top();
                stack.pop();
                result += stack.top();
                stack.pop();
                number = 0;
                break;

            default:
                while (i < s.size() && isdigit(s[i])) {
                    number = number * 10 + s[i] - '0';
                    i++;
                }
                i--;
            }
        }

        return result + (number * sign);
    }
};
