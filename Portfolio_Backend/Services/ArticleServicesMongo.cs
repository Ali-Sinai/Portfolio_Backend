using MongoDB.Bson;
using Portfolio_Backend.Context;
using Portfolio_Backend.Models;

namespace Portfolio_Backend.Services;

public class ArticleServicesMongo : ArticleServiceAbstract
{
    private readonly PortfolioContextMongo _dbContextMongo;

    public ArticleServicesMongo(PortfolioContextMongo portfolioContextMongo)
    {
        _dbContextMongo = portfolioContextMongo;
    }
    
    public override IEnumerable<IArticle> GetAllArticles()
    {
        List<ArticleMongo> result = _dbContextMongo.Articles.ToList();
        return result;
    }

    public override IArticle GetArticleById(ObjectId id)
    {
        ArticleMongo result = _dbContextMongo.Articles.FirstOrDefault(x => x.Id == id);
        return result ?? throw new Exception("404 Article Not Found!");
    }

	public override IArticle GetArticleById(Guid id)
	{
		throw new NotImplementedException();
	}
}