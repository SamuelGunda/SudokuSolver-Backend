using Microsoft.AspNetCore.Mvc;
using SudokuSolver.Database;
using SudokuSolver.Interfaces;

namespace SudokuSolver.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SudokuController(ISudokuService sudokuService) : ControllerBase
{
    // 530070000600195000098000060800060003400803001700020006060000280000419005000080079 example sudoku board
    
    [HttpPut]
    public async Task<IActionResult> UploadSudoku(string sudokuBoard)
    {
        if (sudokuBoard.Length != 81)
        {
            return BadRequest("Invalid sudoku board");
        }
        
        var sudoku = new Sudoku()
        {
            Board = sudokuBoard
        };
        
        try
        {
            var uploadedSudoku = await sudokuService.UploadSudokuAsync(sudoku);
            return Ok(uploadedSudoku);

        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    
    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetSudokuById(int id)
    {
        var sudoku = await sudokuService.GetSudokuByIdAsync(id);
        
        if (sudoku == null)
        {
            return NotFound($"Sudoku with id '{id}' not found");
        }
        
        return Ok(sudoku);
    }
    
    [HttpGet("solve/{id:int}")]
    public async Task<IActionResult> SolveSudoku(int id)
    {
        try
        {
            var solvedSudoku = await sudokuService.SolveSudokuAsync(id);
            return Ok(solvedSudoku);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}