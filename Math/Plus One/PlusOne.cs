public class Solution {
    public int[] PlusOne(int[] digits) {
        int carry = 1;
        for (int i = digits.Length - 1; i >= 0; i--) {
            int sum = digits[i] + carry;
            digits[i] = sum % 10;
            carry = sum / 10;
        }
        
        if (carry == 1) {
            List<int> result = new List<int>(digits);
            result.Insert(0, 1);
            return result.ToArray();
        }
        
        return digits;
    }
}