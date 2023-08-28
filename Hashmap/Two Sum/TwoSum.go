func twoSum(nums []int, target int) []int {
	d := make(map[int]int)
	var result []int

	for index, num := range nums {
		if idx, exists := d[target-num]; exists {
			result = append(result, idx, index)
			break
		}
		d[num] = index
	}
	return result
}