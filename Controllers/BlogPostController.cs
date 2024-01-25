using BlogApi.Models.Dtos;
using BlogApi.Models;
using BlogApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogPostController : ControllerBase
    {
        private readonly IBlogPostInterface blogPostInterface;

        public BlogPostController(IBlogPostInterface blogPostInterface)
        {
            this.blogPostInterface = blogPostInterface;
        }
        [HttpPost]
        public async Task<ActionResult<BlogPost>> Post(CreateBlogPostDto createBlogPostDto)
        {
            return StatusCode(201, await blogPostInterface.Post(createBlogPostDto));
        }
        [HttpGet]
        public async Task<ActionResult<BlogPost>> Get()
        {
            return StatusCode(201, await blogPostInterface.Get());
        }
        [HttpGet("id")]
        public async Task<ActionResult<BlogPost>> GetById(Guid Id)
        {
            return await blogPostInterface.GetById(Id);
        }
        [HttpPut]
        public async Task<ActionResult<BlogPost>> Put(Guid Id, UpdateBlogPostDto updateBlogPostDto)
        {
            var result = await blogPostInterface.Put(Id, updateBlogPostDto);
            return StatusCode(201, result);
        }
        [HttpDelete]
        public async Task<ActionResult> Delete(Guid Id)
        {
            await blogPostInterface.Delete(Id);
            return Ok();
        }
    }
}
