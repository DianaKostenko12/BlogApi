using BlogApp.Data;
using BlogApp.Interfaces;
using BlogApp.Models;

namespace BlogApp.Repository
{
    public class PostRepository :IPostRepository
    {
        private readonly DataContext _context;
        public PostRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Post> GetPosts() 
        {
            return _context.Posts.OrderBy(p => p.Id).ToList();
        }
    }
}
