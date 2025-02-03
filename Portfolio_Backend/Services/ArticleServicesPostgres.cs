using MongoDB.Bson;
using Portfolio_Backend.Context;
using Portfolio_Backend.Models;

namespace Portfolio_Backend.Services
{
	public class ArticleServicesPostgres : IArticleService
	{
		private readonly PortfolioContextPostgres _dbContextPostgres;
		public ArticleServicesPostgres(PortfolioContextPostgres portfolioContextPostgres)
		{
			_dbContextPostgres = portfolioContextPostgres;
		}
		public List<ArticlePostgres> GetAllArticles()
		{
			List<ArticlePostgres> articles = _dbContextPostgres.Articles.ToList();
			return articles;
		}

		public ArticlePostgres GetArticleById(Guid id)
		{
			ArticlePostgres article = _dbContextPostgres.Articles.FirstOrDefault(x => x.Id == id);
			return article;
		}
	}
}
