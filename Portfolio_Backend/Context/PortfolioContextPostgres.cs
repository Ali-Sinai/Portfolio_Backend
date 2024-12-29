using Microsoft.EntityFrameworkCore;
using Portfolio_Backend.Models;

namespace Portfolio_Backend.Context;

public class PortfolioContextPostgres : DbContext
{
    public PortfolioContextPostgres()
    {
        
    }

    public PortfolioContextPostgres(DbContextOptions<PortfolioContextPostgres> options)
    :base(options)
    {
        
    }
    
    public DbSet<Article> Articles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Article>(entity =>
        {
            entity.ToTable("Articles");
            entity.HasKey(e => e.Id);
            
            entity.Property(e => e.Title);
            entity.Property(e => e.Content);
            entity.Property(e => e.DateCreated);
        });
    }
}