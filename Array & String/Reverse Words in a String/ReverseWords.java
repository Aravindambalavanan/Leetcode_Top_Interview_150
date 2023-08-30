class Solution {
    public String reverseWords(String s) {
        String[] x = s.split(" +");
        StringBuilder sb = new StringBuilder();
        for (int i = x.length - 1; i >= 0; i--) {
            sb.append(x[i]);
            sb.append(" ");
        }
        return sb.toString().trim();
    }
}