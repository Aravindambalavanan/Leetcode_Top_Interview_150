func trailingZeroes(n int) int {
    count, i := 0, 5
    for i <= n {
        count += n / i
        i *= 5
    }
    return count
}