using Microsoft.EntityFrameworkCore;

namespace SudokuSolver.Database;

public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<Sudoku>()
            .HasData(
                new Sudoku()
                {
                    Id = 1,
                    Board = "530070000600195000098000060800060003400803001700020006060000280000419005000080079",
                });
        modelBuilder
            .Entity<SudokuTile>()
            .HasData(
                new SudokuTile { Id = 1, X = 1, Y = 1, Value = 5, SudokuId = 1 },
                new SudokuTile { Id = 2, X = 2, Y = 1, Value = 3, SudokuId = 1 },
                new SudokuTile { Id = 3, X = 3, Y = 1, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 4, X = 4, Y = 1, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 5, X = 5, Y = 1, Value = 7, SudokuId = 1 },
                new SudokuTile { Id = 6, X = 6, Y = 1, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 7, X = 7, Y = 1, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 8, X = 8, Y = 1, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 9, X = 9, Y = 1, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 10, X = 1, Y = 2, Value = 6, SudokuId = 1 },
                new SudokuTile { Id = 11, X = 2, Y = 2, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 12, X = 3, Y = 2, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 13, X = 4, Y = 2, Value = 1, SudokuId = 1 },
                new SudokuTile { Id = 14, X = 5, Y = 2, Value = 9, SudokuId = 1 },
                new SudokuTile { Id = 15, X = 6, Y = 2, Value = 5, SudokuId = 1 },
                new SudokuTile { Id = 16, X = 7, Y = 2, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 17, X = 8, Y = 2, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 18, X = 9, Y = 2, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 19, X = 1, Y = 3, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 20, X = 2, Y = 3, Value = 9, SudokuId = 1 },
                new SudokuTile { Id = 21, X = 3, Y = 3, Value = 8, SudokuId = 1 },
                new SudokuTile { Id = 22, X = 4, Y = 3, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 23, X = 5, Y = 3, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 24, X = 6, Y = 3, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 25, X = 7, Y = 3, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 26, X = 8, Y = 3, Value = 6, SudokuId = 1 },
                new SudokuTile { Id = 27, X = 9, Y = 3, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 28, X = 1, Y = 4, Value = 8, SudokuId = 1 },
                new SudokuTile { Id = 29, X = 2, Y = 4, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 30, X = 3, Y = 4, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 31, X = 4, Y = 4, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 32, X = 5, Y = 4, Value = 6, SudokuId = 1 },
                new SudokuTile { Id = 33, X = 6, Y = 4, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 34, X = 7, Y = 4, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 35, X = 8, Y = 4, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 36, X = 9, Y = 4, Value = 3, SudokuId = 1 },
                new SudokuTile { Id = 37, X = 1, Y = 5, Value = 4, SudokuId = 1 },
                new SudokuTile { Id = 38, X = 2, Y = 5, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 39, X = 3, Y = 5, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 40, X = 4, Y = 5, Value = 8, SudokuId = 1 },
                new SudokuTile { Id = 41, X = 5, Y = 5, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 42, X = 6, Y = 5, Value = 3, SudokuId = 1 },
                new SudokuTile { Id = 43, X = 7, Y = 5, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 44, X = 8, Y = 5, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 45, X = 9, Y = 5, Value = 1, SudokuId = 1 },
                new SudokuTile { Id = 46, X = 1, Y = 6, Value = 7, SudokuId = 1 },
                new SudokuTile { Id = 47, X = 2, Y = 6, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 48, X = 3, Y = 6, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 49, X = 4, Y = 6, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 50, X = 5, Y = 6, Value = 2, SudokuId = 1 },
                new SudokuTile { Id = 51, X = 6, Y = 6, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 52, X = 7, Y = 6, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 53, X = 8, Y = 6, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 54, X = 9, Y = 6, Value = 6, SudokuId = 1 },
                new SudokuTile { Id = 55, X = 1, Y = 7, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 56, X = 2, Y = 7, Value = 6, SudokuId = 1 },
                new SudokuTile { Id = 57, X = 3, Y = 7, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 58, X = 4, Y = 7, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 59, X = 5, Y = 7, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 60, X = 6, Y = 7, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 61, X = 7, Y = 7, Value = 2, SudokuId = 1 },
                new SudokuTile { Id = 62, X = 8, Y = 7, Value = 8, SudokuId = 1 },
                new SudokuTile { Id = 63, X = 9, Y = 7, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 64, X = 1, Y = 8, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 65, X = 2, Y = 8, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 66, X = 3, Y = 8, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 67, X = 4, Y = 8, Value = 4, SudokuId = 1 },
                new SudokuTile { Id = 68, X = 5, Y = 8, Value = 1, SudokuId = 1 },
                new SudokuTile { Id = 69, X = 6, Y = 8, Value = 9, SudokuId = 1 },
                new SudokuTile { Id = 70, X = 7, Y = 8, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 71, X = 8, Y = 8, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 72, X = 9, Y = 8, Value = 5, SudokuId = 1 },
                new SudokuTile { Id = 73, X = 1, Y = 9, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 74, X = 2, Y = 9, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 75, X = 3, Y = 9, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 76, X = 4, Y = 9, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 77, X = 5, Y = 9, Value = 8, SudokuId = 1 },
                new SudokuTile { Id = 78, X = 6, Y = 9, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 79, X = 7, Y = 9, Value = 0, SudokuId = 1 },
                new SudokuTile { Id = 80, X = 8, Y = 9, Value = 7, SudokuId = 1 },
                new SudokuTile { Id = 81, X = 9, Y = 9, Value = 9, SudokuId = 1 }
            );

    }
}