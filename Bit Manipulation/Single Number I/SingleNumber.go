func singleNumber(nums []int) int {
    ones, twos := 0, 0
    for _, num := range nums {
        ones = (ones ^ num) &^ twos
        twos = (twos ^ num) &^ ones
    }
    return ones
}