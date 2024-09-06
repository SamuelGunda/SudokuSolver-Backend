namespace SudokuSolver.Database;

public class Sudoku
{
    public int Id { get; set; }
    public string Board { get; set; }
    public string? Solution { get; set; }

    private int[][] GetSudokuBoard()
    {
        var board = new int[9][];
        var boardArray = Board.ToCharArray();

        for (var row = 0; row < 9; row++)
        {
            board[row] = new int[9];
            for (var col = 0; col < 9; col++)
            {
                board[row][col] = int.Parse(boardArray[row * 9 + col].ToString());
            }
        }

        return board;
    }

    public SudokuDto ToDto()
    {
        return new SudokuDto
        {
            Board = Board,
            SudokuBoard = GetSudokuBoard(),
        };
    }
}

public class SudokuDto
{
    public string Board { get; set; }
    public int[][] SudokuBoard { get; set; }
}