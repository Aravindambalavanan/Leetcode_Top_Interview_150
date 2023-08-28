import java.util.HashMap;

class Solution {
    public int maxPoints(int[][] points) {
        if (points.length <= 0)
            return 0;
        if (points.length <= 2)
            return points.length;

        int max = 0;

        for (int[] point1 : points) {
            HashMap<Double, Integer> map = new HashMap<>();
            for (int[] point2 : points) {
                if (point1 == point2)
                    continue;

                double slope = 0;

                if (point2[0] == point1[0]) {
                    slope = Double.POSITIVE_INFINITY;
                } else {
                    slope = (point2[1] - point1[1]) / (double) (point2[0] - point1[0]);
                }
                map.put(slope, map.getOrDefault(slope, 0) + 1);
                if (map.get(slope) > max) {
                    max = map.get(slope);
                }
            }
        }
        return max + 1;
    }
}