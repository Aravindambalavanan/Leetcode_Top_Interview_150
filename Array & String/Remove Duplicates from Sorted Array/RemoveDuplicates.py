from typing import List


class Solution:
    def removeDuplicates(self, nums: List[int]) -> int:
        i, j = 1, 1

        while i < len(nums):
            if nums[i - 1] != nums[i]:
                nums[j] = nums[i]
                j += 1
            i += 1

        return j
