func hammingWeight(num uint32) int {
    count := 0
	for num != 0 {
		count += int(num & 1)
		num >>= 1
	}
	return count
}