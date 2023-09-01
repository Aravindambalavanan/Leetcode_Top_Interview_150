class Solution {
public:
    int evalRPN(vector<string> &tokens) {
        stack<int> st;
        
        for (const string& token : tokens) {
            if (isOperator(token)) {
                int operand2 = st.top(); st.pop();
                int operand1 = st.top(); st.pop();
                st.push(performOperation(operand1, operand2, token));
            } else {
                st.push(stoi(token));
            }
        }
        
        return st.top();
    }

private:
    bool isOperator(const string& token) {
        return (token == "+" || token == "-" || token == "*" || token == "/");
    }

    int performOperation(int operand1, int operand2, const string& op) {
        switch (op[0]) {
            case '+':
                return operand1 + operand2;
            case '-':
                return operand1 - operand2;
            case '*':
                return operand1 * operand2;
            case '/':
                return operand1 / operand2;
            default:
                return 0;
        }
    }
};