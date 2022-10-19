using System.ComponentModel.DataAnnotations;

namespace Watchlist.Data.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50,MinimumLength =5)]
        public string Name { get; set; }
        public ICollection<Movie> Movies { get; set; } = new List<Movie>();
    }
}