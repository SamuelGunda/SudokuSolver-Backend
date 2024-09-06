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
                    },
                new Sudoku()
                    {
                        Id = 2,
                        Board = "800000000003600000070090200050007000000045700000100030001000068008500010090000400"
                    },
                new Sudoku()
                    {
                        Id = 3,
                        Board = "200080300060070084030500209000105408000000000402706000301007040720040060004010003"
                    }
                );

    }
}