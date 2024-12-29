using MongoDB.Bson;
using Portfolio_Backend.Context;
using Portfolio_Backend.Models;

namespace Portfolio_Backend.Services;

public class ArticleServices : IArticleService
{
    private readonly PortfolioContextMongo _dbContextMongo;

    public ArticleServices(PortfolioContextMongo portfolioContextMongo)
    {
        _dbContextMongo = portfolioContextMongo;
    }
    
    public List<Article> GetAllArticles()
    {
        List<Article> result = _dbContextMongo.Articles.ToList();
        return result;
    }

    public Article GetArticleById(ObjectId id)
    {
        Article result = _dbContextMongo.Articles.FirstOrDefault(x => x.Id == id);
        return result;
    }
}