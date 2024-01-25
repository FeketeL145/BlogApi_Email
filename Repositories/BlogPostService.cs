using BlogApi.Models;
using BlogApi.Models.Dtos;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace BlogApi.Repositories
{
    public class BlogPostService : IBlogPostInterface
    {
        private readonly BlogDbContext dbContext;
        public BlogPostService(BlogDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Delete(Guid Id)
        {
            await dbContext.BlogPosts.Where(x => x.Id == Id).ExecuteDeleteAsync();
            await dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<BlogPost>> Get()
        {
            return dbContext.BlogPosts.ToList();
        }

        public async Task<BlogPost> GetById(Guid Id)
        {
            return dbContext.BlogPosts.SingleOrDefault(x => x.Id.Equals(Id));
        }

        public async Task<BlogPost> Post(CreateBlogPostDto createBlogPostDto)
        {
            var post = new BlogPost
            {
                Id = Guid.NewGuid(),
                PostTitle = createBlogPostDto.PostTitle,
                PostContent = createBlogPostDto.PostContent,
                BlogUserId = createBlogPostDto.BlogUserId,
                CreatedTime = DateTime.Now,
            };
            await dbContext.BlogPosts.AddAsync(post);
            await dbContext.SaveChangesAsync();

            return post;
        }

        public async Task<BlogPost> Put(Guid Id, UpdateBlogPostDto updateBlogPostDto)
        {
            var findid = dbContext.BlogPosts.FirstOrDefault(x => x.Id.Equals(Id));
            findid.PostTitle = updateBlogPostDto.PostTitle;
            findid.PostContent = updateBlogPostDto.PostContent;

            await dbContext.SaveChangesAsync();

            return findid;
        }
    }
}
