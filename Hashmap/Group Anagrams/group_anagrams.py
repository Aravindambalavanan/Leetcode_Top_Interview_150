class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        anagrams = {}

        for i in strs:
            id = "".join(sorted(i))
            items = anagrams.get(id, [])
            items.append(i)
            anagrams[id] = items
        return list(anagrams.values())
