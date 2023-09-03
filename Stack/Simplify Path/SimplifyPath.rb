def simplify_path(path)
  stack = []
  components = path.split("/")
  components.each do |component|
    if component == ".."
      stack.pop unless stack.empty?
    elsif !component.empty? && component != "."
      stack.push(component)
    end
  end
  simplified_path = "/" + stack.join("/")
  simplified_path.empty? ? "/" : simplified_path
end
