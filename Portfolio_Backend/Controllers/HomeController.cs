using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Portfolio_Backend.Models;
using Portfolio_Backend.Services;

namespace Portfolio_Backend.Controllers;

[ApiController]
public class HomeController : Controller
{
    private readonly IArticleService _articleService;

    public HomeController(IArticleService articleService)
    {
        _articleService = articleService;
    }
    
    [HttpGet("/blog")]
    public IActionResult GetAllArticles()
    {
        List<Article> articles = _articleService.GetAllArticles();
        return Ok(articles);
    }

    [HttpGet("/article/{id}")]
    public IActionResult GetArticleById(ObjectId id)
    {
        Article article = _articleService.GetArticleById(id);
        return Ok(article);
    }
}