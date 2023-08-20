using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieStore.Entities
{
    public class BookmarkMovie
    {
        public int BookmarkMovieId { get; set; } // da zacuvas podocna da gledas neso kao Watch leter

        public string? WatchLater { get; set; }
    }
}
