class Solution {
    public int lengthOfLastWord(String s) {
        String[] x = s.split(" +");
        StringBuilder sb = new StringBuilder();
        sb.append(x[x.length - 1]);
        return sb.length();
    }
}