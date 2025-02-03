using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Portfolio_Backend.Models;
using Portfolio_Backend.Services;

namespace Portfolio_Backend.Controllers;

[ApiController]
public class HomeMongoController : Controller
{
    private readonly ArticleServiceAbstract _articleService;

    public HomeMongoController(ArticleServicesMongo articleService)
    {
        _articleService = articleService;
    }
    
    [HttpGet("/v1/blog")]
    public IEnumerable<IArticle> GetAllArticles()
    {
		IEnumerable<IArticle> articles = _articleService.GetAllArticles();
        return articles;
    }

    [HttpGet("/article/v1/{id}")]
    public IArticle GetArticleById(ObjectId id)
    {
        IArticle article = _articleService.GetArticleById(id);
        return article;
    }
}