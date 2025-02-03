using MongoDB.Bson;
using Portfolio_Backend.Context;
using Portfolio_Backend.Models;

namespace Portfolio_Backend.Services;

public class ArticleServicesMongo : IArticleService
{
    private readonly PortfolioContextMongo _dbContextMongo;

    public ArticleServicesMongo(PortfolioContextMongo portfolioContextMongo)
    {
        _dbContextMongo = portfolioContextMongo;
    }
    
    public List<ArticleMongo> GetAllArticles()
    {
        List<ArticleMongo> result = _dbContextMongo.Articles.ToList();
        return result;
    }

    public ArticleMongo GetArticleById(ObjectId id)
    {
        ArticleMongo result = _dbContextMongo.Articles.FirstOrDefault(x => x.Id == id);
        return result;
    }
}