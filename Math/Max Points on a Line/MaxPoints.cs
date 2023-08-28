public class Solution {
    public int MaxPoints(int[][] points) {
        int counter = 1;
        if (points.Length < 2) {
            return 1;
        }
        
        for (int i = 0; i < points.Length; i++) {
            Dictionary<double, int> slope = new Dictionary<double, int>();
            for (int j = i + 1; j < points.Length; j++) {
                int y = points[j][1] - points[i][1];
                int x = points[j][0] - points[i][0];
                if (x != 0) {
                    double currentSlope = (double)y / x;
                    if (!slope.ContainsKey(currentSlope)) {
                        slope[currentSlope] = 0;
                    }
                    slope[currentSlope]++;
                } else {
                    if (!slope.ContainsKey(double.PositiveInfinity)) {
                        slope[double.PositiveInfinity] = 0;
                    }
                    slope[double.PositiveInfinity]++;
                }
            }
            foreach (var kvp in slope) {
                counter = Math.Max(counter, kvp.Value);
            }
        }
                
        return counter + 1;
    }
}