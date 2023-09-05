def is_palindrome(s)
  res = s.scan(/[a-zA-Z0-9]/).join.downcase
  res == res.reverse
end
