using System.ComponentModel.DataAnnotations;

namespace BookDash.Data
{
    public class LoginViewModel
    {
        [Required] public string Name { get; set; }
        [Required] public string Email { get; set; }
        [Required] public string Phone { get; set; }
        [Required] public string Password { get; set; }
    }
}

