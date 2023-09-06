class Solution {
  public:
    string simplifyPath(string path) {
        deque<string> queue;
        string current;
        for (const auto &p : path + "/") {
            if (p == '/') {
                if (current == ".." && !queue.empty())
                    queue.pop_back();
                else if (current != "" && current != "." && current != "..")
                    queue.push_back(current);
                current = "";
            } else
                current += p;
        }

        string result = {};

        if (queue.empty())
            result = "/";
        while (!queue.empty()) {
            result.append("/").append(queue.front());
            queue.pop_front();
        }

        return result;
    }
};
