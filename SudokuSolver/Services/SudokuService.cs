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
        return null;
    }
    
    public async Task<SudokuDto?> GetSudokuByIdAsync(int id)
    {
        var sudoku = await _context.Sudokus
            .FirstOrDefaultAsync(s => s.Id == id);

        return sudoku?.ToDto();
    }
    
}