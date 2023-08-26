func isPalindrome(x int) bool {
	if x < 0 {
		return false
	}
	original := x
	reversed := 0
	for x != 0 {
		digit := x % 10
		reversed = reversed*10 + digit
		x /= 10
	}
	return original == reversed
}