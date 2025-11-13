using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pair_Project_FilomenoMatugas.Models
{
    public class Movie
    {
        [Key]
        public string MovieId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateOnly Released { get; set; }
        public string Poster { get; set; }
        [Display(Name = "Country")]
        public int CountryId { get; set; }

        [ForeignKey("CountryId")]
        public Country Country { get; set; }
        public string Plot { get; set; }
        public string Rating { get; set; }
        public string Votes { get; set; }


    }
}
