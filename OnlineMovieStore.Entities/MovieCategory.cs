﻿namespace OnlineMovieStore.Entities
{
	using System.ComponentModel.DataAnnotations;
	public class MovieCategory
    {
        [Key]
        public int Id { get; set; }
        //[Key]
        //public int MovieId { get; set; }

        public string? MovieName { get; set; }

        [StringLength(90)]
        public string? Genre { get; set; }  //zhanr


        public string? LastUpdate { get; set; } //najnov dodaden film


        //TODO: Relation with other tabeles-> Tuka ke ja praime relacijata podocna
        public virtual ICollection<Movie>? Movies { get; set; }


    }
}
