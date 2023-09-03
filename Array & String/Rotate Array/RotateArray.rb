def rotate(nums, k)
  k.times do
    nums.unshift(nums.pop)
  end
end
