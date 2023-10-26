namespace OnlineMovieStore.Entities
{
	using System.ComponentModel.DataAnnotations;
	public class MovieSearch
    {
        [Key]
        public int SearchMovieId { get; set; }

        [StringLength(450)]
        public string? MovieGenre { get; set; }

        [StringLength(450)]
        public string MovieMovieName { get; set; } = null!;

        public bool MovieIsPopular { get; set; }



    }
}
