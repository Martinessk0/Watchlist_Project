using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Watchlist.Data.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength =10)]
        public string Title { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string Director { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        [Range(0.0,10.0)]
        public decimal Rating { get; set; }
        [Required]
        public int GenreId { get; set; }
        [Required]
        [ForeignKey(nameof(GenreId))]
        public Genre Genre { get; set; }
        public ICollection<UserMovie> UsersMovies { get; set; } = new List<UserMovie>();
    }
}
