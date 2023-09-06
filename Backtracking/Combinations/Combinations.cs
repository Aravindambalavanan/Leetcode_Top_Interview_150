public class Solution {
   public IList<IList<int>> Combine(int n, int k) {
        List<IList<int>> result = new List<IList<int>>();
        List<int> current = new List<int>();
        Combination(result, current, n, k, 1);
        return result;
    }

    private void Combination(List<IList<int>> result, List<int> current, int n, int k, int start) {
        if (k == 0) {
            result.Add(new List<int>(current));
            return;
        }
        for (int i = start; i <= n; ++i) {
            current.Add(i);
            Combination(result, current, n, k - 1, i + 1);
            current.RemoveAt(current.Count - 1);
        }
    }
}