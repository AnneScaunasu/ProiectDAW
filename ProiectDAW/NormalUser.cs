using System.ComponentModel.DataAnnotations;

namespace ProiectDAW
{
    public class NormalUser
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string userName { get; set; } = string.Empty;

        [StringLength(50)]
        public string Password { get; set; } = string.Empty;

        [StringLength(50)]
        public string Email { get; set; } = string.Empty;
    }
}
