using MongoDB.Bson;

namespace Portfolio_Backend.Models
{
	public class ArticlePostgres : IArticle
	{
		public Guid Id { get; set; }
		public string Title { get; set; }
		public string Content { get; set; }
		public DateTime DateCreated { get; set; }
	}
}
