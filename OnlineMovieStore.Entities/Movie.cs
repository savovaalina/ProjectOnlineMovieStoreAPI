namespace OnlineMovieStore.Entities
{
	using System.ComponentModel.DataAnnotations;
	public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        #region Movie Details

        [StringLength(250)]
        public string MovieName { get; set; } = null!;

        public string? MovePart { get; set; }
        public int MovieLength { get; set; }

        public int MovieRating { get; set; }

        [StringLength(100)]
        public string? MovieCountry { get; set; }
        public DateTime MovieYearOfRelease { get; set; }  // godina na izdavenje

        [StringLength(100)]
        public string? MovieDirector { get; set; }

        [StringLength(100)]
        public string? MovieProducer { get; set; }

        [StringLength(250)]
        public string? MovieActors { get; set; }

        [StringLength(450)]
        public string? MovieDescription { get; set; }

        [StringLength(100)]
        public string? MovieLanguage { get; set; }
        #endregion

        #region Category Details
        public string? CategoryGenre { get; set; }

        public int CategoryMovieId { get; set; }

        public MovieCategory? Category { get; set; }
        #endregion

        #region Sales Details

        public double Price { get; set; }
        public int SoldMovies { get; set; }
        public int SoldShows { get; set; }

        public int SoldParts { get; set; }

        #endregion


        public bool IsPopular { get; set; } // top 10 popularni movie (moze i da go staime a moze i ne)

        public virtual ICollection<PhotoMovie>? Photos { get; set; }

    }
}
