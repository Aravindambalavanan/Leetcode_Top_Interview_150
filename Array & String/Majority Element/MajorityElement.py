from typing import List


class Solution:
    def majorityElement(self, nums: List[int]) -> int:
        e = {}
        for n in nums:
            if n in e:
                e[n] += 1
            else:
                e[n] = 0

        return max(zip(e.values(), e.keys()))[1]
