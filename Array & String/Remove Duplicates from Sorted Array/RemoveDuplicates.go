func removeDuplicates(nums []int) int {
	uniqueMap := make(map[int]bool)
	var uniqueSlice []int

	for _, num := range nums {
		if !uniqueMap[num] {
			uniqueMap[num] = true
			uniqueSlice = append(uniqueSlice, num)
		}
	}

	copy(nums, uniqueSlice)
	return len(uniqueSlice)
}