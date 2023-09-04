def is_subsequence(s, t)
  s.each_char do |c|
    i = t.index(c)
    return false if i.nil?
    t = t[i + 1..-1]
  end
  true
end
