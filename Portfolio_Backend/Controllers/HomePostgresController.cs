using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Portfolio_Backend.Models;
using Portfolio_Backend.Services;

namespace Portfolio_Backend.Controllers;

[ApiController]
public class HomePostgresController : Controller
{
    private readonly ArticleServiceAbstract _articleService;

	public HomePostgresController(ArticleServicesPostgres articleService)
	{
			_articleService = articleService;
	}

	[HttpGet("/v2/blog")]
    public IEnumerable<IArticle> GetAllArticles()
    {
		IEnumerable<IArticle> articles = _articleService.GetAllArticles();
        return articles;
    }

	[HttpGet("/article/v2/{id}")]
	public IArticle GetArticleById(Guid id)
	{
		IArticle article = _articleService.GetArticleById(id);
		return article;
	}
}