namespace SudokuSolver.Database;

public class Sudoku
{
    public int Id { get; set; }
    public string Board { get; set; }
    public string? Solution { get; set; }
    public List<SudokuTile> Tiles { get; set; } = new();
    
    public SudokuDto ToDto()
    {
        return new SudokuDto
        {
            Board = Board,
            Tiles = Tiles.Select(tile => tile.ToDto()).ToList(),
        };
    }
}

public class SudokuDto
{
    public string Board { get; set; }
    public List<SudokuTileDto> Tiles { get; set; } = new();
}