public class Solution {
    public string SimplifyPath(string path) {
        Stack<string> stack = new Stack<string>();
        string[] components = path.Split('/');
        
        foreach (string component in components) {
            if (component == "..") {
                if (stack.Count > 0) {
                    stack.Pop();
                }
            } else if (!string.IsNullOrEmpty(component) && component != ".") {
                stack.Push(component);
            }
        }
        
        string[] simplifiedPathArray = stack.ToArray();
        Array.Reverse(simplifiedPathArray);
        string simplifiedPath = "/" + string.Join("/", simplifiedPathArray);
        
        return string.IsNullOrEmpty(simplifiedPath) ? "/" : simplifiedPath;
    }
}