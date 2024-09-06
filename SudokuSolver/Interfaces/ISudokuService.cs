using SudokuSolver.Database;

namespace SudokuSolver.Interfaces;

public interface ISudokuService
{
    public Task<SudokuDto> UploadSudokuAsync(Sudoku sudoku);
    // public Task<Sudoku> UploadSudokuFileAsync(IFormFile file);
    public Task<SudokuDto?> GetSudokuByIdAsync(int id);
    // public Task<string> SolveSudokuAsync(int id);
}