using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogApi.Models
{
    public class BlogPost
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string? PostTitle { get; set; }
        [Required]
        [Column(TypeName = "longtext")]
        public string? PostContent { get; set; }
        public Guid BlogUserId { get; set; }
        public BlogUser? BlogUser { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
