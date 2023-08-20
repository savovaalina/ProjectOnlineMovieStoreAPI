using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieStore.Entities
{

    public class User
    {
        public Guid MovieId { get; set; }

        [StringLength(250)]
        public string UserName { get; set; } = null!;

        [StringLength(350)]
        public string? UserEmail { get; set; }

        [StringLength(350)]
        public string? UserAdress { get; set; }

        [StringLength(150)]
        public string? UserCountry { get; set; }

        [StringLength(150)]
        public string? UserCity { get; set; }

        public byte[] PasswordHash { get; set; } = null!; //vaka e poso se enkriptira vo arrey od byte

        public byte[] PasswordSalt { get; set; } = null!;//random generiranje na brojce koi sto ke pomaga pri enkripcijata na PasswordHash

        [StringLength(250)]
        public string? Phone { get; set; }

        [StringLength(650)]
        public string? Description { get; set; }

        public DateTime UserCreated { get; set; }

        public bool IsAdmin { get; set; }

        public int UserAge { get; set; } // dodadeno od nasha strana



        //TODO: Relation with other tabeles-> Tuka ke ja praime relacijata podocna

    }
}
