class Solution:
    def simplifyPath(self, path: str) -> str:
        stack = deque()
        components = path.split("/")
        for component in components:
            if component == "..":
                if stack:
                    stack.pop()
            elif component and component != ".":
                stack.append(component)
        simplified_path = "/" + "/".join(stack)
        return simplified_path if simplified_path else "/"
