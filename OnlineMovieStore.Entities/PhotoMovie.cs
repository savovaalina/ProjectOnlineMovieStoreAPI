namespace OnlineMovieStore.Entities
{
	using System.ComponentModel.DataAnnotations;
	public class PhotoMovie
    {
        [Key]
        public int PhotoMovieId { get; set; }

        [StringLength(450)]
        public string Url { get; set; } = null!; // Ova ke ni kazuva kaj se naoga slikata

        [StringLength(650)]
        public string? Description { get; set; }

        public DateTime DateAdded { get; set; } //Koga e stavena slikata

        public bool IsMain { get; set; } //dali e cover slikata- udarna prva slika

        


    }
}
