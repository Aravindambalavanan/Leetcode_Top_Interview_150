class Solution {
public:
    vector<vector<int>> combine(int n, int k) {
        vector<vector<int>> result;
        vector<int> current;
        combinations(result, current, n, k, 1);
        return result;
    }

private:
    void combinations(vector<vector<int>>& result, vector<int>& current, int n, int k, int start) {
        if (k == 0) {
            result.push_back(current);
            return;
        }
        for (int i = start; i <= n; ++i) {
            current.push_back(i);
            combinations(result, current, n, k - 1, i + 1);
            current.pop_back();
        }
    }
};