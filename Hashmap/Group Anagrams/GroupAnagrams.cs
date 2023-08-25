public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> group = new Dictionary<string, List<string>>();
        
        foreach (string element in strs) {
            string sortedElement = new string(element.ToCharArray().OrderBy(c => c).ToArray());
            
            if (!group.ContainsKey(sortedElement)) {
                group[sortedElement] = new List<string> { element };
            } else {
                group[sortedElement].Add(element);
            }
        }
        
        IList<IList<string>> result = new List<IList<string>>();
        foreach (var kv in group) {
            result.Add(kv.Value);
        }
        
        return result;
    }
}