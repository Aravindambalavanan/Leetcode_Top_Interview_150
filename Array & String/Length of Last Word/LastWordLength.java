class Solution {
    public int lengthOfLastWord(String s) {
        String[] x = s.split(" +");
        return x[x.length - 1].length();
    }
}