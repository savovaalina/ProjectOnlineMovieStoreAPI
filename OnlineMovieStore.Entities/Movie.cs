using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieStore.Entities
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        #region MovieDetails

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


        //TODO: Relation with other tabeles-> Tuka ke ja praime relacijata podocna
        public virtual ICollection<PhotoMovie>? Photos { get; set; }

    }
}
