func mySqrt(x int) int {
	if x == 0 || x == 1 {
		return x
	}
	first := 1
	last := x
	for first <= last {
		mid := first + (last-first)/2
		if mid == x/mid {
			return mid
		} else if mid > x/mid {
			last = mid - 1
		} else {
			first = mid + 1
		}
	}
	return last
}