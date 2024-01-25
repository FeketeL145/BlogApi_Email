using BlogApi.Models;
using BlogApi.Models.Dtos;

namespace BlogApi
{
    public static class Extensions
    {
        public static BlogUserDto AsDto(this BlogUser blogUser) 
        {
            return new(blogUser.Id, blogUser.Username, blogUser.UserEmail,
                blogUser.UserPassword, blogUser.CreatedTime);
        }
        public static BlogPostDto AsDto(this BlogPost blogPost)
        {
            return new(blogPost.Id, blogPost.PostTitle, blogPost.PostContent, blogPost.BlogUserId, blogPost.CreatedTime);
        }
    }
}
