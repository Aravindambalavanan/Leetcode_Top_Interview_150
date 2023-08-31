type StackElement struct {
	Value     int
	MinValue  int
}

type MinStack struct {
	minStack *arraystack.Stack
}

func Constructor() MinStack {
	return MinStack{
		minStack: arraystack.New(),
	}
}

func (ms *MinStack) Push(val int) {
	if ms.minStack.Empty() {
		ms.minStack.Push(StackElement{Value: val, MinValue: val})
	} else {
		topElem, _ := ms.minStack.Peek()
		newMin := int(math.Min(float64(val), float64(topElem.(StackElement).MinValue)))
		ms.minStack.Push(StackElement{Value: val, MinValue: newMin})
	}
}

func (ms *MinStack) Pop() {
	if !ms.minStack.Empty() {
		ms.minStack.Pop()
	}
}

func (ms *MinStack) Top() int {
	if topElem, ok := ms.minStack.Peek(); ok {
		return topElem.(StackElement).Value
	}
	return 0
}

func (ms *MinStack) GetMin() int {
	if topElem, ok := ms.minStack.Peek(); ok {
		return topElem.(StackElement).MinValue
	}
	return 0
}