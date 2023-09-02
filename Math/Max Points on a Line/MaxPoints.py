class Solution:
    def maxPoints(self, points: List[List[int]]) -> int:
        if len(points) <= 2:
            return len(points)

        result = 0
        for p1 in points:
            collinear_points = {}
            for p2 in points:
                if p1 == p2:
                    continue

                slope = 0
                if p2[0] == p1[0]:
                    slope = float("inf")
                else:
                    slope = (p2[1] - p1[1]) / (p2[0] - p1[0])

                collinear_points[slope] = collinear_points.get(slope, 0) + 1

                if collinear_points[slope] > result:
                    result = collinear_points[slope]

        return result + 1
