using BlogApi.Models;
using BlogApi.Models.Dtos;

namespace BlogApi.Repositories
{
    public interface IBlogPostInterface
    {
        Task<IEnumerable<BlogPost>> Get();
        Task<BlogPost> GetById(Guid Id);
        Task<BlogPost> Post(CreateBlogPostDto createBlogPostDto);
        Task<BlogPost> Put(Guid Id,UpdateBlogPostDto updateBlogPostDto);
        Task Delete(Guid Id);
    }
}
