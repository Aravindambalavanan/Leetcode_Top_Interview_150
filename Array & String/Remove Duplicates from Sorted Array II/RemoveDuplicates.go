func removeDuplicates(nums []int) int {
	if len(nums) <= 2 {
		return len(nums)
	}
	
	uniqueCount := 2
	for i := 2; i < len(nums); i++ {
		if nums[i] != nums[uniqueCount-2] {
			nums[uniqueCount] = nums[i]
			uniqueCount++
		}
	}
	
	return uniqueCount
}