func groupAnagrams(strs []string) [][]string {
	group := make(map[string][]string)

	for _, element := range strs {
		sortedElement := []rune(element)
		sort.Slice(sortedElement, func(i, j int) bool {
			return sortedElement[i] < sortedElement[j]
		})
		sortedStr := string(sortedElement)

		if _, exists := group[sortedStr]; !exists {
			group[sortedStr] = []string{element}
		} else {
			group[sortedStr] = append(group[sortedStr], element)
		}
	}

	var result [][]string
	for _, v := range group {
		result = append(result, v)
	}

	return result
}