using MongoDB.Bson;
using Portfolio_Backend.Models;

namespace Portfolio_Backend.Services;

public interface IArticleService
{
    List<Article> GetAllArticles();
    Article GetArticleById(ObjectId id);
}