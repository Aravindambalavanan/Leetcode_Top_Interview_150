def merge(nums1, m, nums2, n)
  nums1.replace(nums1[0...m] + nums2).sort!
end
