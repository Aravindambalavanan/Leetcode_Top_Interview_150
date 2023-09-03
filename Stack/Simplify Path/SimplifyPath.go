func simplifyPath(path string) string {
	stack := []string{}
	components := strings.Split(path, "/")

	for _, component := range components {
		if component == ".." {
			if len(stack) > 0 {
				stack = stack[:len(stack)-1]
			}
		} else if component != "" && component != "." {
			stack = append(stack, component)
		}
	}

	simplifiedPath := "/" + strings.Join(stack, "/")

	if simplifiedPath == "" {
		return "/"
	}

	return simplifiedPath
}