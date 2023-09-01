func evalRPN(tokens []string) int {
	st := []int{}
	for _, token := range tokens {
		if isOperator(token) {
			operand2 := st[len(st)-1]
			st = st[:len(st)-1]
			operand1 := st[len(st)-1]
			st = st[:len(st)-1]
			st = append(st, performOperation(operand1, operand2, token))
		} else {
			num, _ := strconv.Atoi(token)
			st = append(st, num)
		}
	}
	return st[0]
}

func isOperator(token string) bool {
	return token == "+" || token == "-" || token == "*" || token == "/"
}

func performOperation(operand1, operand2 int, op string) int {
	switch op {
	case "+":
		return operand1 + operand2
	case "-":
		return operand1 - operand2
	case "*":
		return operand1 * operand2
	case "/":
		return operand1 / operand2
	}
	return 0
}