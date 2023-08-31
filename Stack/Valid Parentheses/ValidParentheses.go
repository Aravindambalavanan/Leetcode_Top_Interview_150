func isValid(s string) bool {
	st := arraystack.New()
	for _, i := range s {
		if st.Empty() && (i == ')' || i == ']' || i == '}') {
			return false
		} else if i == '(' || i == '[' || i == '{' {
			st.Push(i)
		} else if value, ok := st.Peek(); !ok {
			return false
		} else if value == '[' && i == ']' {
			st.Pop()
		} else if value == '(' && i == ')' {
			st.Pop()
		} else if value == '{' && i == '}' {
			st.Pop()
		} else {
			return false
		}
	}
	if st.Empty() {
		return true
	}
	return false
}