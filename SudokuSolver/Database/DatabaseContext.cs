using Microsoft.EntityFrameworkCore;

namespace SudokuSolver.Database;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options) { }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Sudoku>(s =>
        {
            s.HasKey(e => e.Id);
            s.HasMany(e => e.Tiles)
                .WithOne(e => e.Sudoku)
                .HasForeignKey(e => e.SudokuId)
                .IsRequired();
        });
        
        modelBuilder.Entity<SudokuTile>(st =>
        {
            st.HasKey(e => e.Id);
            st.Property(e => e.X);
            st.Property(e => e.Y);
            st.Property(e => e.Value);
            st.HasOne(e => e.Sudoku)
                .WithMany(e => e.Tiles)
                .HasForeignKey(e => e.SudokuId)
                .IsRequired();
        });
        
        modelBuilder.Seed();
    }
    
    public DbSet<Sudoku> Sudokus { get; set; }
    public DbSet<SudokuTile> SudokuTiles { get; set; }
} 