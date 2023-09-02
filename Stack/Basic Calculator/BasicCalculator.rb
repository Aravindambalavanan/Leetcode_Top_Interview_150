def calculate(s)
  output, curr, sign, stack = 0, 0, 1, []
  (0...s.length).each do |i|
    c = s[i]
    if c.match?(/\d/)
      curr = (curr * 10) + c.to_i
    elsif c.match?(/[+\-]/)
      output += curr * sign
      curr = 0
      sign = 1 if c == "+"
      sign = -1 if c == "-"
    elsif c == "("
      stack.push(output)
      stack.push(sign)
      output = 0
      sign = 1
    elsif c == ")"
      output += curr * sign
      output *= stack.pop
      output += stack.pop
      curr = 0
    end
  end
  output + (curr * sign)
end
