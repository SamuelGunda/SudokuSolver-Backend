using Microsoft.EntityFrameworkCore;
using SudokuSolver.Database;
using SudokuSolver.Interfaces;

namespace SudokuSolver.Services;

public class SudokuService : ISudokuService
{
    private readonly DatabaseContext _context;
    
    public SudokuService(DatabaseContext context)
    {
        _context = context;
        
        _context.Database.EnsureCreated();
    }
    
    public async Task<SudokuDto> UploadSudokuAsync(Sudoku sudoku)
    {
        _context.Sudokus.Add(sudoku);
        await _context.SaveChangesAsync();
        
        var sudokuId = sudoku.Id;
        var sudokuBoardToArray = sudoku.Board.ToCharArray();
        
        var x = 1;
        var y = 1;
        
        foreach (var c in sudokuBoardToArray)
        {
            if (!char.IsDigit(c))
            {
                throw new Exception("Invalid sudoku board");
            }
            
            var sudokuTile = new SudokuTile
            {
                Value = int.Parse(c.ToString()),
                X = x,
                Y = y,
                SudokuId = sudokuId,
                Sudoku = sudoku
            };
            
            x++;
            if (x > 9)
            {
                x = 1;
                y++;
            }
            
            await _context.SudokuTiles.AddAsync(sudokuTile);
        }
        
        await _context.SaveChangesAsync();
        
        var uploadedSudoku = await _context.Sudokus
            .Include(s => s.Tiles)
            .FirstOrDefaultAsync(s => s.Id == sudokuId);
        
        return uploadedSudoku!.ToDto();
    }
    
    public async Task<SudokuDto?> GetSudokuByIdAsync(int id)
    {
        var sudoku = await _context.Sudokus
            .Include(s => s.Tiles)
            .FirstOrDefaultAsync(s => s.Id == id);

        return sudoku?.ToDto();
    }
    
    // public async Task<String> SolveSudokuAsync(int id)
    // {
    //     var sudoku = await _context.Sudokus
    //         .Include(s => s.Tiles)
    //         .FirstOrDefaultAsync(s => s.Id == id);
    //
    //     if (sudoku == null)
    //     {
    //         throw new Exception($"Sudoku with id '{id}' not found");
    //     }
    //     
    //     
    // }
}