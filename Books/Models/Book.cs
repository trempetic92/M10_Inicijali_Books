using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Books.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public DateTime DateOfPublished { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        public int BookCount { get; set; }

        [Required]
        public int AuthorId { get; set; }

        [ForeignKey("AuthorId")]
        public Author Author { get; set; }

        [Required]
        public int PublisherId { get; set; }

        [ForeignKey("PublisherId")]
        public Publisher Publisher { get; set; }
    }
}
