namespace SudokuSolver.Database;

public class Sudoku
{
    public int Id { get; set; }
    public string Board { get; set; } 
    public string? Solution { get; set; }
    public int[,] SudokuBoard = new int[9, 9];
    
    public SudokuDto ToDto()
    {
        return new SudokuDto
        {
            Board = Board,
            SudokuBoard = SudokuBoard,
        };
    }
}

public class SudokuDto
{
    public string Board { get; set; }
    public int[,] SudokuBoard { get; set; }
}