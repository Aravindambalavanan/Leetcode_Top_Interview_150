from typing import List


def remove_duplicates(nums: List[int]) -> int:
    if len(nums) <= 2:
        return len(nums)

    i = 2
    for j in range(i):
        if nums[j] != nums[i - 2]:
            nums[i] = nums[j]
            i += 1

    return i
