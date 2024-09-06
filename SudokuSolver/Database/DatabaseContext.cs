using Microsoft.EntityFrameworkCore;

namespace SudokuSolver.Database;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options) { }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Sudoku>(s => { s.HasKey(e => e.Id); });

        modelBuilder.Seed();
    }
    
    public DbSet<Sudoku> Sudokus { get; set; }
} 