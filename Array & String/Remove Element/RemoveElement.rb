def remove_element(nums, val)
  nums.delete(val) while nums.include?(val)
  nums.length
end
