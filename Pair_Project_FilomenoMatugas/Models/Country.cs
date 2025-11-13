using System.ComponentModel.DataAnnotations;

namespace Pair_Project_FilomenoMatugas.Models
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }
        public string? CountryName { get; set; }
    }
}
