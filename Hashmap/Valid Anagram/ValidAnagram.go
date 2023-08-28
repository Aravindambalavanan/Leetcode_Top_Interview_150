func isAnagram(s string, t string) bool {
	if len(s) != len(t) {
		return false
	}
	counter1 := make(map[rune]int)
	counter2 := make(map[rune]int)
	
	for _, c := range s {
		counter1[c]++
	}
	for _, c := range t {
		counter2[c]++
	}
	
	return equalMaps(counter1, counter2)
}

func equalMaps(map1, map2 map[rune]int) bool {
	if len(map1) != len(map2) {
		return false
	}
	for k, v1 := range map1 {
		v2, ok := map2[k]
		if !ok || v1 != v2 {
			return false
		}
	}
	return true
}