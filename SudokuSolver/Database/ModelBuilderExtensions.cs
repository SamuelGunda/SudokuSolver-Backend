﻿using Microsoft.EntityFrameworkCore;

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

    }
}