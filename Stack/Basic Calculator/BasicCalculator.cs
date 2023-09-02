public class Solution
{
    public int Calculate(string s)
    {
        int output = 0, curr = 0, sign = 1;
        Stack<int> stack = new Stack<int>();
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if (char.IsDigit(c))
            {
                curr = (curr * 10) + (c - '0');
            }
            else if (c == '+' || c == '-')
            {
                output += curr * sign;
                curr = 0;
                sign = (c == '+') ? 1 : -1;
            }
            else if (c == '(')
            {
                stack.Push(output);
                stack.Push(sign);
                output = 0;
                sign = 1;
            }
            else if (c == ')')
            {
                output += curr * sign;
                output *= stack.Pop();
                output += stack.Pop();
                curr = 0;
            }
        }
        return output + (curr * sign);
    }
}