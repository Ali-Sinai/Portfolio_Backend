using Microsoft.EntityFrameworkCore;
using Portfolio_Backend.Context;
using Portfolio_Backend.Services;

namespace Portfolio_Backend;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddAuthorization();

        builder.Services.AddControllers();

        // MongoDb
        builder.Services.AddDbContext<PortfolioContextMongo>(options =>
        {
            options.UseMongoDB(
                builder.Configuration.GetConnectionString("MongoDbConnectionString"),
                "Portfolio");
        });
        
        // Postgresql
        builder.Services.AddDbContext<PortfolioContextPostgres>(options =>
        {
            options.UseNpgsql(builder.Configuration.GetConnectionString("PostgresConnectionString"));
        });
        
        builder.Services.AddScoped<IArticleService, ArticleServices>();
        
        // add swagger
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        
        // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
        //builder.Services.AddOpenApi();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            //app.MapOpenApi();
        }
        
        app.MapControllers();
        app.UseSwagger();
        app.UseSwaggerUI(options =>
        {
            options.SwaggerEndpoint("/swagger/v1/swagger.json", "Portfolio API");
            options.RoutePrefix = string.Empty;
        });

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.Run();
    }
}