using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieStore.Entities
{
    
    public class Language
    {
        [Key]

        public int LanguageMovieId { get; set; }

        public string? LanguageMovieName { get; set; }


    }
}
