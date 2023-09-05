func rangeBitwiseAnd(left, right int) int {
    count := 0
    for left != right {
        left >>= 1
        right >>= 1
        count++
    }
    return left << count
}