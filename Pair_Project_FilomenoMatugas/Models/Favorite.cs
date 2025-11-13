using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pair_Project_FilomenoMatugas.Models
{
    public class Favorite
    {
        [Key]
        public string? FavoriteId { get; set; }
        
        [ForeignKey("MovieId")]
        public Movie? Movie { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }
    }
}
