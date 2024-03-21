using System.ComponentModel.DataAnnotations;

namespace BookDash.Models
{
    public class User
    {
        [Key] public int Id { get; set; }
        [Required] public string Name { get; set; }
        [Required] public string Email { get; set; }
        [Required] public string Phone { get; set; }
        [Required] public string Password { get; set; }
    }
}

