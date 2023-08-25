import java.util.HashMap;

class Solution {
    public boolean wordPattern(String pattern, String s) {
        String[] array = s.split(" ");

        if (pattern.length() != array.length)
            return false;

        HashMap<Character, String> map = new HashMap<>();

        for (int i = 0; i < pattern.length(); i++) {
            char currentChar = pattern.charAt(i);
            if (map.containsKey(currentChar)) {
                if (!map.get(currentChar).equals(array[i])) {
                    return false;
                }
            } else {
                if (map.containsValue(array[i])) {
                    return false;
                }
            }
            map.put(currentChar, array[i]);
        }
        return true;
    }
}