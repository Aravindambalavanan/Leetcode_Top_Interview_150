class Solution
{
public:
    bool isValid(string s)
    {
        stack<char> st;
        for (auto i : s)
        {
            if (st.empty() && (i == ')' || i == ']' || i == '}'))
            {
                return false;
            }
            else if (i == '(' || i == '[' || i == '{')
            {
                st.push(i);
            }
            else if (!st.empty() && st.top() == '[' && i == ']')
            {
                st.pop();
            }
            else if (!st.empty() && st.top() == '(' && i == ')')
            {
                st.pop();
            }
            else if (!st.empty() && st.top() == '{' && i == '}')
            {
                st.pop();
            }
            else
                return false;
        }
        if (st.size() == 0)
            return true;
        return false;
    }
};