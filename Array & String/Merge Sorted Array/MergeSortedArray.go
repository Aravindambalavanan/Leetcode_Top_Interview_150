func merge(nums1 []int, m int, nums2 []int, n int) {
	for i := 0; i < n; i++ {
		nums1[i+m] = nums2[i]
	}
	sort.Ints(nums1)
}