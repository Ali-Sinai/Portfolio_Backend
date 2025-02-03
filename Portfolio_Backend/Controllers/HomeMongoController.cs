using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Portfolio_Backend.Models;
using Portfolio_Backend.Services;

namespace Portfolio_Backend.Controllers;

[ApiController]
public class HomeMongoController : Controller
{
    private readonly IArticleService _articleService;

    public HomeMongoController(ArticleServicesMongo articleService)
    {
        _articleService = articleService;
    }
    
    [HttpGet("/blog")]
    public IActionResult GetAllArticles()
    {
        List<IArticle> articles = _articleService.GetAllArticles();
        return Ok(articles);
    }

    [HttpGet("/article/v1/{id}")]
    public IActionResult GetArticleById(ObjectId id)
    {
        IArticle article = _articleService.GetArticleById(id);
        return Ok(article);
    }
}