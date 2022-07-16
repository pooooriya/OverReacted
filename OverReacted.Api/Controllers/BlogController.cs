using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OverReacted.Application.Dtos.Article;
using OverReacted.Application.Services;
using System.Security.Claims;

namespace OverReacted.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IArticleService ArticleService;

        public BlogController(IArticleService ArticleService)
        {
            this.ArticleService = ArticleService;
        }
        [HttpGet("posts")]
        public async Task<IActionResult> GetAllBlogPosts(CancellationToken cancellationToken)
        {
            return Ok(await ArticleService.GetAllBlogPost(cancellationToken));
        }

        [HttpGet("post/{Id:Guid}")]
        public async Task<IActionResult> GetPost([FromRoute] Guid Id)
        {
            return Ok(await ArticleService.GetPost(Id));
        }

        [HttpPost("post/new")]
        [Authorize(Roles = "Author,God")]
        public async Task<IActionResult> CreateNewPost(CreateNewPostDto post, CancellationToken cancellationToken)
        {
            var UserId = HttpContext.User.Claims.Where(n => n.Type == ClaimTypes.NameIdentifier).SingleOrDefault();
            return Ok(await ArticleService.CreatePost(post, new Guid(UserId?.Value), cancellationToken));
        }

        [HttpDelete("post/{Id:Guid}")]
        [Authorize(Roles = "Author,God")]
        public async Task<IActionResult> RemovePost([FromRoute] Guid Id, CancellationToken cancellationToken)
        {
            var RemovePost = await ArticleService.RemovePost(Id, cancellationToken);
            if (RemovePost == true)
            {
                return NoContent();
            }
            return BadRequest();
        }


        [HttpPut("post/{Id:Guid}")]
        [Authorize(Roles = "Author,God")]
        public async Task<IActionResult> UpdatePost([FromRoute] Guid Id, CreateNewPostDto post, CancellationToken cancellationToken)
        {
            var UpdatePost = await ArticleService.UpdatePost(Id,post, cancellationToken);
            if (UpdatePost == false)
                return BadRequest();
            return Ok(UpdatePost);
        }
    }
}
