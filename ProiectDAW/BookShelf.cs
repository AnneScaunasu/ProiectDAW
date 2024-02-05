using System.ComponentModel.DataAnnotations;

namespace ProiectDAW
{
    public class BookShelf
    {
        [Key]
        public int Id { get; set; }

        [StringLength(20)]
        public string Name { get; set; } = string.Empty;

        public int UserId { get; set; }

        public NormalUser? NormalUser { get; set; }
    }
}
