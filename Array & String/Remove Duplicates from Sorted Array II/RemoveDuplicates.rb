def remove_duplicates(nums)
  return nums.length if nums.length <= 2
  unique_count = 2
  (2...nums.length).each do |i|
    if nums[i] != nums[unique_count - 2]
      nums[unique_count] = nums[i]
      unique_count += 1
    end
  end
  unique_count
end
