func maxPoints(points [][]int) int {
    counter := 1
	if len(points) < 2 {
		return 1
	}

	for i := 0; i < len(points); i++ {
		slope := make(map[float64]int)
		for j := i + 1; j < len(points); j++ {
			y := points[j][1] - points[i][1]
			x := points[j][0] - points[i][0]
			if x != 0 {
				currentSlope := float64(y) / float64(x)
				slope[currentSlope] = 1 + slope[currentSlope]
			} else {
				slope[math.Inf(1)] = 1 + slope[math.Inf(1)]
			}
		}
		for _, value := range slope {
			if value > counter {
				counter = value
			}
		}
	}

	return counter + 1
}