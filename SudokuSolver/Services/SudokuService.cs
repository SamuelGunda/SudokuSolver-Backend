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
        await _context.Sudokus.AddAsync(sudoku);
        await _context.SaveChangesAsync();
        
        return sudoku.ToDto();
    }
    
    public async Task<SudokuDto?> GetSudokuByIdAsync(int id)
    {
        var sudoku = await _context.Sudokus
            .FirstOrDefaultAsync(s => s.Id == id);

        return sudoku?.ToDto();
    }
    
    public async Task<SudokuDto> SolveSudokuAsync(int id)
    {
        var sudoku = await _context.Sudokus
            .FirstOrDefaultAsync(s => s.Id == id);

        if (sudoku == null)
        {
            throw new Exception($"Sudoku with id '{id}' not found");
        }

        var sudokuBoard = sudoku.ToDto().SudokuBoard;
        
        if (!SolveSudoku(sudokuBoard))
        {
            throw new Exception("No solution exists for the given Sudoku");
        }

        return new SudokuDto
        {
            SudokuBoard = sudokuBoard
        };
    }

    private bool SolveSudoku(int[][] board)
    {
        
        /*
         * We iterate through each cell in the board.
         */
        
        for (int row = 0; row < 9; row++)
        {
            for (int col = 0; col < 9; col++)
            {
                
                /*
                 * If the cell is empty, we try to fill it with a number from 1 to 9.
                 * If the number is valid, we fill the next cell.
                 * If the number is not valid, we backtrack and try the next number.
                 * If no number is valid, we backtrack further.
                 * If we reach the end of the board, we have solved the Sudoku.
                 */
                
                if (board[row][col] == 0) 
                {
                    for (int num = 1; num <= 9; num++)
                    {
                        if (IsValid(board, row, col, num))
                        {
                            board[row][col] = num;

                            if (SolveSudoku(board)) return true;
                            
                            board[row][col] = 0;
                        }
                    }
                    return false;
                }
            }
        }
        return true;
    }

    private bool IsValid(int[][] board, int row, int col, int num)
    {
        
        /*
         * We check if the number is already present in the row or column.
         * If the number is present, we return false.
         */
        
        for (int i = 0; i < 9; i++)
        {
            if (board[row][i] == num || board[i][col] == num)
            {
                return false;
            }
        }
        
        /*
         * We check if the number is already present in the subgrid.
         * If the number is present, we return false.
         */

        int subgridRowStart = (row / 3) * 3;
        int subgridColStart = (col / 3) * 3;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (board[subgridRowStart + i][subgridColStart + j] == num)
                {
                    return false;
                }
            }
        }

        return true;
    }
}