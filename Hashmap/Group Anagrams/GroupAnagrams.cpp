class Solution {
public:
    vector<vector<string>> groupAnagrams(vector<string>& strs) {
        unordered_map<string, vector<string>> group;
        
        for (const string& element : strs) {
            string sortedElement = element;
            sort(sortedElement.begin(), sortedElement.end());
            if (group.find(sortedElement) == group.end()) {
                group[sortedElement] = {element};
            } else {
                group[sortedElement].push_back(element);
            }
        }

        vector<vector<string>> result;
        for (const auto& kv : group) {
            result.push_back(kv.second);
        }
        
        return result;
    }
};