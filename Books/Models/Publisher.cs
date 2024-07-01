using System.ComponentModel.DataAnnotations;

namespace Books.Models
{
    public class Publisher
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 2)]
        public string Title { get; set; }
        public string? Description { get; set; }
    }
}
