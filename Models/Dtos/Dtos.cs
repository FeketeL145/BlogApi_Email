namespace BlogApi.Models.Dtos
{
    //BlogUser
    public record BlogUserDto(Guid Id, string Username, string UserEmail,
        string Password, DateTime CreatedTime);
    public record CreateBlogUserDto(string Username, string UserEmail,
        string Password);
    public record UpdateBlogUserDto(string Username, string UserEmail,
        string Password);
    //BlogPost
    public record BlogPostDto(Guid Id, string PostTitle, string PostContent, Guid BlogUserId, DateTime CreatedTime);
    public record CreateBlogPostDto(string PostTitle, string PostContent, Guid BlogUserId);
    public record UpdateBlogPostDto(string PostTitle, string PostContent);

    //EmailDto
    public record EmailDto(string To, string Subject, string Body);
}
