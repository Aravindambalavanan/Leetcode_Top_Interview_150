class Solution {
public:
    int totalNQueens(int n) {
        vector<bool> col(n), diag(2 * n - 1), anti_diag(2 * n - 1);
        return solveNQueens(col, diag, anti_diag, 0);
    }

private:
    int solveNQueens(vector<bool>& col, vector<bool>& diag, vector<bool>& anti_diag, int row) {
        int n = col.size(), count = 0;
        if (row == n) {
            return 1;
        }
        for (int column = 0; column < n; column++) {
            if (canPlaceQueen(col, diag, anti_diag, row, column)) {
                placeQueen(col, diag, anti_diag, row, column);
                count += solveNQueens(col, diag, anti_diag, row + 1);
                removeQueen(col, diag, anti_diag, row, column);
            }
        }
        return count;
    }

    bool canPlaceQueen(const vector<bool>& col, const vector<bool>& diag, const vector<bool>& anti_diag, int row, int column) {
        return !col[column] && !diag[row + column] && !anti_diag[row - column + col.size() - 1];
    }

    void placeQueen(vector<bool>& col, vector<bool>& diag, vector<bool>& anti_diag, int row, int column) {
        col[column] = diag[row + column] = anti_diag[row - column + col.size() - 1] = true;
    }

    void removeQueen(vector<bool>& col, vector<bool>& diag, vector<bool>& anti_diag, int row, int column) {
        col[column] = diag[row + column] = anti_diag[row - column + col.size() - 1] = false;
    }
};