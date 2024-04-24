using BlogApp.Interfaces;
using BlogApp.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : Controller
    {
        private readonly IPostRepository _postRepository;
        public PostController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        [HttpGet]
        public IActionResult GetPosts()
        {
            var posts = _postRepository.GetPosts();

            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(posts);
        }
    }
}
