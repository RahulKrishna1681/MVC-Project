using System.ComponentModel.DataAnnotations;

namespace BookDash.Data
{
    public class Admin
    {
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        // You can include additional properties specific to admin users here
    }
}
