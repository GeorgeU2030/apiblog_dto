
namespace BlogApi.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<Post> Posts { get; } = new List<Post>();
    }
}