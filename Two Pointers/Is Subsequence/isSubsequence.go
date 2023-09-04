func isSubsequence(sub string, str string) bool {
	for _, c := range sub {
		i := strings.IndexRune(str, c)
		if i == -1 {
			return false
		}
		str = str[i+1:]
	}
	return true
}