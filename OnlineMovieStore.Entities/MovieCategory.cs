using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieStore.Entities
{
    public class MovieCategory
    {
        [Key]
        public int MovieId { get; set; }

        public string? MovieName { get; set; }

        [StringLength(90)]
        public string Genre { get; set; } = null!; //zhanr


        public string? LastUpdate { get; set; } //najnov dodaden film


        //TODO: Relation with other tabeles-> Tuka ke ja praime relacijata podocna
        public virtual ICollection<Movie>? Movie { get; set; }


    }
}
