public class Solution {
    public int TotalNQueens(int n) {
        bool[] col = new bool[n];
        bool[] diag = new bool[2 * n - 1];
        bool[] anti_diag = new bool[2 * n - 1];
        return SolveNQueens(col, diag, anti_diag, 0);
    }

    private int SolveNQueens(bool[] col, bool[] diag, bool[] anti_diag, int row) {
        int n = col.Length;
        int count = 0;
        if (row == n) {
            return 1;
        }
        for (int column = 0; column < n; column++) {
            if (CanPlaceQueen(col, diag, anti_diag, row, column)) {
                PlaceQueen(col, diag, anti_diag, row, column);
                count += SolveNQueens(col, diag, anti_diag, row + 1);
                RemoveQueen(col, diag, anti_diag, row, column);
            }
        }
        return count;
    }

    private bool CanPlaceQueen(bool[] col, bool[] diag, bool[] anti_diag, int row, int column) {
        return !col[column] && !diag[row + column] && !anti_diag[row - column + col.Length - 1];
    }

    private void PlaceQueen(bool[] col, bool[] diag, bool[] anti_diag, int row, int column) {
        col[column] = diag[row + column] = anti_diag[row - column + col.Length - 1] = true;
    }

    private void RemoveQueen(bool[] col, bool[] diag, bool[] anti_diag, int row, int column) {
        col[column] = diag[row + column] = anti_diag[row - column + col.Length - 1] = false;
    }
}