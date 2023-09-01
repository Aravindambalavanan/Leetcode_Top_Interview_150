import java.util.Stack;

class MinStack {
    Stack<PairStack> stack;

    public MinStack() {
        stack = new Stack<>();
    }

    public void push(int val) {
        if (stack.isEmpty()) {
            stack.push(new PairStack(val, val));
        } else {
            int currentMinInStack = stack.peek().min;
            stack.push(new PairStack(val, Math.min(currentMinInStack, val)));
        }
    }

    public void pop() {
        if (!stack.isEmpty()) {
            stack.pop();
        }
    }

    public int top() {
        return stack.peek().val;
    }

    public int getMin() {
        return stack.peek().min;
    }

    class PairStack {
        int val;
        int min;

        PairStack(int val, int min) {
            this.val = val;
            this.min = min;
        }
    }
}

