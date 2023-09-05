def majority_element(nums)
  nums.each_with_object(Hash.new(0)) { |n, hash| hash[n] += 1 }.max_by { |_, count| count }[0]
end
