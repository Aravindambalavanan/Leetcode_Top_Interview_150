import java.util.*;

class Solution {
    public List<List<String>> groupAnagrams(String[] strs) {
        if (strs == null || strs.length == 0)
            return null;

        ArrayList<List<String>> list = new ArrayList<>();

        HashMap<String, List<String>> map = new HashMap<>();

        for (String word : strs) {
            char[] sortedList = word.toCharArray();
            Arrays.sort(sortedList);
            String sortedString = new String(sortedList);

            if (map.containsKey(sortedString)) {
                map.get(sortedString).add(word);
            } else {
                map.put(sortedString, new ArrayList<String>());
                map.get(sortedString).add(word);
            }
        }
        for (List<String> x : map.values()) {
            list.add(x);
        }
        return list;
    }
}