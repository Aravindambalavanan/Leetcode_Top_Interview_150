func wordPattern(pattern string, s string) bool {
	patternMap := make(map[rune]int)
	wordMap := make(map[string]int)
	words := strings.Split(s, " ")
	n := len(pattern)

	if n != len(words) {
		return false
	}

	for i := 0; i < n; i++ {
		currPatternChar := rune(pattern[i])
		currWord := words[i]

		if _, exists := patternMap[currPatternChar]; !exists {
			patternMap[currPatternChar] = i
		}
		if _, exists := wordMap[currWord]; !exists {
			wordMap[currWord] = i
		}
		if patternMap[currPatternChar] != wordMap[currWord] {
			return false
		}
	}
	return true
}