func isPalindrome(str string) bool {
    var res strings.Builder
    for _, char := range str {
        if isAlphaNumeric(char) {
            res.WriteRune(char)
        }
    }
    s1 := strings.ToLower(res.String())
    s2 := reverse(s1)
    return s1 == s2
}

func isAlphaNumeric(char rune) bool {
    return (char >= 'a' && char <= 'z') || (char >= 'A' && char <= 'Z') || (char >= '0' && char <= '9')
}

func reverse(str string) string {
    runes := []rune(str)
    n := len(runes)
    for i := 0; i < n/2; i++ {
        runes[i], runes[n-i-1] = runes[n-i-1], runes[i]
    }
    return string(runes)
}