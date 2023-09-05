def length_of_last_word(s)
  s.to_s.split.last&.length || 0
end
