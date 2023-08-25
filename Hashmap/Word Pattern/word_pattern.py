class Solution:
    def wordPattern(self, pattern: str, s: str) -> bool:
        if not str or not pattern:
            return False
        strings = s.split()
        if len(strings) != len(pattern):
            return False
        str2pat = {}
        pat2str = {}
        for i in range(len(pattern)):
            if strings[i] in str2pat:
                if str2pat[strings[i]] != pattern[i]:
                    return False
            else:
                str2pat[strings[i]] = pattern[i]
            if pattern[i] in pat2str:
                if pat2str[pattern[i]] != strings[i]:
                    return False
            else:
                pat2str[pattern[i]] = strings[i]
        return True
