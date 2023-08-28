func rotate(nums []int, k int)  {
    n := len(nums)
	k %= n
	for x := 0; x < k; x++ {
		last := nums[n-1]
		copy(nums[1:], nums[:n-1])
		nums[0] = last
	}
}