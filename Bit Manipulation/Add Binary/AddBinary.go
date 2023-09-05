func addBinary(a string, b string) string {
    i, j, carry := len(a)-1, len(b)-1, 0
	var result strings.Builder
	for i >= 0 || j >= 0 || carry > 0 {
		bitA, bitB := 0, 0
		
        if i >= 0 {
			bitA = int(a[i] - '0')
		}
		
        if j >= 0 {
			bitB = int(b[j] - '0')
		}

		sum := bitA + bitB + carry
		result.WriteString(fmt.Sprintf("%d", sum%2))
		carry = sum / 2
		i--
		j--
	}
	return reverse(result.String())
}

func reverse(s string) string {
	runes := []rune(s)
	for i, j := 0, len(runes)-1; i < j; i, j = i+1, j-1 {
		runes[i], runes[j] = runes[j], runes[i]
	}
	return string(runes)
}