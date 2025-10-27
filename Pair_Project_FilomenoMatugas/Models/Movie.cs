using System.ComponentModel.DataAnnotations;

namespace Pair_Project_FilomenoMatugas.Models
{
    public class Movie
    {
        [Key]
        public string MovieId { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        [DataType(DataType.Date)]
        public DateOnly Released { get; set; }
        public string Poster { get; set; }
        public string Country { get; set; }
        public string Plot { get; set; }
        public string Rating { get; set; }
        public string Votes { get; set; }


    }
}
