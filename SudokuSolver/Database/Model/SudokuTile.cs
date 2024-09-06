namespace SudokuSolver.Database;

public class SudokuTile
{
    public int Id { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    public int Value { get; set; }
    public int SudokuId { get; set; }
    public Sudoku Sudoku { get; set; } = null!;
    
    public SudokuTileDto ToDto()
    {
        return new SudokuTileDto
        {
            X = X,
            Y = Y,
            Value = Value,
        };
    }
}

public class SudokuTileDto
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Value { get; set; }
}