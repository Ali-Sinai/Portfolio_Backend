using Microsoft.EntityFrameworkCore;
using Portfolio_Backend.Models;
using MongoDB.EntityFrameworkCore.Extensions;

namespace Portfolio_Backend.Context;

public class PortfolioContextMongo : DbContext
{
    public PortfolioContextMongo()
    {
    }

    public PortfolioContextMongo(DbContextOptions<PortfolioContextMongo> options)
    : base(options)
    {
        
    }
    
    public DbSet<ArticleMongo> Articles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ArticleMongo>(entity =>
        {
            entity.ToCollection("Articles");
            
            entity.HasKey(e => e.Id);

            entity.Property(e => e.Title);
            entity.Property(e => e.Content);
            entity.Property(e => e.DateCreated);

        });
    }
}