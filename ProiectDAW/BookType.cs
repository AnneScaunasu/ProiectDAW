using System.ComponentModel.DataAnnotations;

namespace ProiectDAW
{
    public class BookType
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
    }
}
