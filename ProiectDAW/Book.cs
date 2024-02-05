using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ProiectDAW
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string Title { get; set; } = string.Empty;

        [StringLength(100)]
        public string Author { get; set; } =  string.Empty;

        [StringLength(300)]
        public string Description { get; set; } = string.Empty;

        public int BookTypeId { get; set; }

        public BookType? BookType { get; set; }
    }
}
