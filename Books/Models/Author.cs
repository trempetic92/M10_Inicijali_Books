using System.ComponentModel.DataAnnotations;

namespace Books.Models
{
    public class Author
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 2)]
        public string? Name { get; set; }
        public DateTime? DateOfBirth { get; set; }
        
    }
}
