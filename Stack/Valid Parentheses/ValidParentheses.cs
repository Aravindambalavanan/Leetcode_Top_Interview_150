public class Solution {
    public bool IsValid(string s) {
        Stack<char> st = new Stack<char>();
        foreach (char i in s)
        {
            if (st.Count == 0 && (i == ')' || i == ']' || i == '}'))
            {
                return false;
            }
            else if (i == '(' || i == '[' || i == '{')
            {
                st.Push(i);
            }
            else if (st.Count > 0 && st.Peek() == '[' && i == ']')
            {
                st.Pop();
            }
            else if (st.Count > 0 && st.Peek() == '(' && i == ')')
            {
                st.Pop();
            }
            else if (st.Count > 0 && st.Peek() == '{' && i == '}')
            {
                st.Pop();
            }
            else
            {
                return false;
            }
        }
        if (st.Count == 0)
            return true;
        return false;
    }
}