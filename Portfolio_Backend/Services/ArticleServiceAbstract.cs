using MongoDB.Bson;
using Portfolio_Backend.Models;

namespace Portfolio_Backend.Services;

public abstract class ArticleServiceAbstract
{
    public abstract IEnumerable<IArticle> GetAllArticles();
	public abstract IArticle GetArticleById(ObjectId id);
	public abstract IArticle GetArticleById(Guid id);
}