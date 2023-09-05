class Solution:
    def isPalindrome(self, s: str) -> bool:
        res = "".join(x for x in s if x.isalnum()).lower()
        return res == res[::-1]
