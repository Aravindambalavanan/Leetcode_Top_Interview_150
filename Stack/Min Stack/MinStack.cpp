class MinStack
{
private:
    struct StackElement
    {
        int value;
        int minValue;

        StackElement(int val, int minVal) : value(val), minValue(minVal) {}
    };
    
    stack<StackElement> minStack;

public:
    MinStack() {}

    void push(int val)
    {
        if (minStack.empty())
        {
            minStack.push(StackElement(val, val));
        }
        else
        {
            int newMin = std::min(val, minStack.top().minValue);
            minStack.push(StackElement(val, newMin));
        }
    }

    void pop()
    {
        if (!minStack.empty())
        {
            minStack.pop();
        }
    }

    int top()
    {
        return minStack.top().value;
    }

    int getMin()
    {
        return minStack.top().minValue;
    }
};