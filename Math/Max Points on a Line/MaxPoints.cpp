class Solution {
public:
    int maxPoints(vector<vector<int>>& points) {
        int counter = 1;
        if (points.size() < 2) {
            return 1;
        }
        for (int i = 0; i < points.size(); ++i) {
            unordered_map<double, int> slope;
            for (int j = i + 1; j < points.size(); ++j) {
                int y = points[j][1] - points[i][1];
                int x = points[j][0] - points[i][0];
                if (x != 0) {
                    slope[static_cast<double>(y) / x] = 1 + slope[static_cast<double>(y) / x];
                } else {
                    slope[numeric_limits<double>::infinity()] = 1 + slope[numeric_limits<double>::infinity()];
                }
            }
            for (const auto& kv : slope) {
                counter = max(counter, kv.second);
            }
        }        
        return counter + 1;
    }
};