using System.ComponentModel.DataAnnotations;

namespace Pair_Project_FilomenoMatugas.Models
{
    public class User
    {
        [Key]
        public string UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    }
}
