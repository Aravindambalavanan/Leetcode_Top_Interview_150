use std::collections::VecDeque;

impl Solution {
    pub fn simplify_path(path: String) -> String {
        let mut stack: VecDeque<String> = VecDeque::new();
        
        let components: Vec<&str> = path.split('/').collect();
        for component in components {
            if component == ".." {
                if !stack.is_empty() {
                    stack.pop_back();
                }
            } else if !component.is_empty() && component != "." {
                stack.push_back(component.to_string());
            }
        }

        let simplified_path: String = format!("/{}", stack.into_iter().collect::<Vec<String>>().join("/"));
        
        if simplified_path.is_empty() {
            return "/".to_string();
        }
        
        simplified_path
    }
}