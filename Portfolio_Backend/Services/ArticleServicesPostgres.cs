using MongoDB.Bson;
using Portfolio_Backend.Context;
using Portfolio_Backend.Models;

namespace Portfolio_Backend.Services
{
	public class ArticleServicesPostgres : ArticleServiceAbstract
	{
		private readonly PortfolioContextPostgres _dbContextPostgres;
		public ArticleServicesPostgres(PortfolioContextPostgres portfolioContextPostgres)
		{
			_dbContextPostgres = portfolioContextPostgres;
		}
		public override IEnumerable<ArticlePostgres> GetAllArticles()
		{
			List<ArticlePostgres> articles = _dbContextPostgres.Articles.ToList();
			return articles;
		}

		public override ArticlePostgres GetArticleById(Guid id)
		{
			ArticlePostgres article = _dbContextPostgres.Articles.FirstOrDefault(x => x.Id == id);
			return article ?? throw new Exception("404 Article Not Found!");
		}

		public override IArticle GetArticleById(ObjectId id)
		{
			throw new NotImplementedException();
		}
	}
}
