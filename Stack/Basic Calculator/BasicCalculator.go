func calculate(str string) int {
	output, curr, sign := 0, 0, 1
	stack := arraystack.New()
	for i := 0; i < len(str); i++ {
		c := str[i]
		if c >= '0' && c <= '9' {
			curr = (curr * 10) + int(c-'0')
		} else if c == '+' || c == '-' {
			output += curr * sign
			curr = 0
			if c == '+' {
				sign = 1
			} else {
				sign = -1
			}
		} else if c == '(' {
			stack.Push(output)
			stack.Push(sign)
			output = 0
			sign = 1
		} else if c == ')' {
			output += curr * sign
			prevSign, _ := stack.Pop()
			prevOutput, _ := stack.Pop()
			output *= prevSign.(int)
			output += prevOutput.(int)
			curr = 0
		}
	}
	return output + (curr * sign)
}