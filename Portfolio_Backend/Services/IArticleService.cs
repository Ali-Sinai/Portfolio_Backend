using MongoDB.Bson;
using Portfolio_Backend.Models;

namespace Portfolio_Backend.Services;

public interface IArticleService
{
    List<IArticle> GetAllArticles();
    IArticle GetArticleById(ObjectId id);
    IArticle GetArticleById(Guid id);
}