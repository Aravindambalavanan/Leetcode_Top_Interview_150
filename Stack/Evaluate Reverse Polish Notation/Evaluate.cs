class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> st = new Stack<int>();
        
        foreach (string token in tokens) {
            if (IsOperator(token)) {
                int operand2 = st.Pop();
                int operand1 = st.Pop();
                st.Push(PerformOperation(operand1, operand2, token));
            } else {
                st.Push(int.Parse(token));
            }
        }
        
        return st.Pop();
    }

    private bool IsOperator(string token) {
        return (token == "+" || token == "-" || token == "*" || token == "/");
    }

    private int PerformOperation(int operand1, int operand2, string op) {
        switch (op) {
            case "+":
                return operand1 + operand2;
            case "-":
                return operand1 - operand2;
            case "*":
                return operand1 * operand2;
            case "/":
                return operand1 / operand2;
            default:
                return 0;
        }
    }
}