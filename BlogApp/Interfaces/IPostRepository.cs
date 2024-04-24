using BlogApp.Models;

namespace BlogApp.Interfaces
{
    public interface IPostRepository
    {
        IEnumerable<Post> GetPosts();
    }
}
