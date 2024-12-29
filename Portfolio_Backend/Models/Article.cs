using MongoDB.Bson;

namespace Portfolio_Backend.Models;

public class Article
{
    public ObjectId Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime DateCreated { get; set; }
}