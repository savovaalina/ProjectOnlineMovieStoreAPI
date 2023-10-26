namespace OnlineMovieStore.Entities
{
	using System.ComponentModel.DataAnnotations;
	public class Shows
    {

        [Key]
        public int ShowMovieId { get; set; }

        [StringLength(250)]
        public string ShowMovieName { get; set; } = null!;

        [StringLength(450)]
        public string? ShowDescription { get; set; }

        [StringLength(150)]
        public string? ShowType { get; set; }

    }
}
