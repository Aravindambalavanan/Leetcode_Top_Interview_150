public class MinStack
{
    private class StackElement
    {
        public int Value { get; }
        public int MinValue { get; }

        public StackElement(int value, int minValue)
        {
            Value = value;
            MinValue = minValue;
        }
    }

    private Stack<StackElement> minStack;

    public MinStack()
    {
        minStack = new Stack<StackElement>();
    }

    public void Push(int val)
    {
        if (minStack.Count == 0)
        {
            minStack.Push(new StackElement(val, val));
        }
        else
        {
            int newMin = Math.Min(val, minStack.Peek().MinValue);
            minStack.Push(new StackElement(val, newMin));
        }
    }

    public void Pop()
    {
        if (minStack.Count > 0)
        {
            minStack.Pop();
        }
    }

    public int Top()
    {
        return minStack.Peek().Value;
    }

    public int GetMin()
    {
        return minStack.Peek().MinValue;
    }
}