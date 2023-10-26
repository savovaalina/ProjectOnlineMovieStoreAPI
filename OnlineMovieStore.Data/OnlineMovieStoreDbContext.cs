
    namespace OnlineMovieStore.Data
    {
    using Microsoft.EntityFrameworkCore;
	using Newtonsoft.Json;
	using OnlineMovieStore.Entities;
	using OnlineMovieStore.Entities.Config;
	using System;
    using System.Collections.Generic;
    using System.Linq;
	using System.Security.Cryptography;
	using System.Text;
    using System.Threading.Tasks;

    //tuka gi kostruirame tabelte koi sto treba da gi pustime na SQL
    //Gi kreirame site entitetski tabeli koi sto nie sme gi napraile
    //Nema potrerba site sto se klasi vo Enttities da gi pustime da se napravat kako tabeli vo SQL
    public class OnlineMovieStoreDbContext : DbContext
    {
        public OnlineMovieStoreDbContext(DbContextOptions options) : base(options)
        {
        }

        //here constract the db tables from entities classes

        public DbSet<User> Users { get; set; } //na User stavame control tocka za da go zeme od toj proekt
        public DbSet<BookmarkMovie> BookmarkMovies { get; set; }
        public DbSet<Language> webLanguages { get; set; }

        public DbSet<Login> Logins { get; set; }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<MovieCategory> MovieCategories { get; set; }

        public DbSet<MovieSearch> MovieSearches { get; set; }

        public DbSet<PhotoMovie> PhotoMovies { get; set; }

        public DbSet<Shows> Shows { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            byte[] passwordHash, passwordSalt;

            // uncomment for testing purposes
            //Debugger.Launch();

            var currentDirectory = Directory.GetCurrentDirectory();
            var filePath = Path.Combine(currentDirectory, "Settings", "user_settings.json");

            UserSettings userSettings = JsonConvert.DeserializeObject<UserSettings>(File.ReadAllText(filePath));

			CreatePasswords(userSettings.AdminCredentials.Password, out passwordHash, out passwordSalt);

            DataSeed.Seed(builder, userSettings.AdminCredentials.Username, passwordHash, passwordSalt);
            base.OnModelCreating(builder);

        }

        #region Helper Methods

        private void CreatePasswords(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
        	}
        }

		#endregion
    }
}
		//byte[] passwordHash, passwordSalt;

		//// comment/uncomment for testing purposes
		//// Debugger.Launch();

		//var currentDirectory = Directory.GetCurrentDirectory();
		//var filePath = Path.Combine(currentDirectory, "Settings", "user_settings.json");

		//UserSettings userSettings = JsonConvert.DeserializeObject<UserSettings>(File.ReadAllText(filePath));

		//CreatePasswords(userSettings.AdminCredentials.Password, out passwordHash, out passwordSalt);

		//DataSeed.Seed(builder, userSettings.AdminCredentials.Username, passwordHash, passwordSalt);

		//base.OnModelCreating(builder);
		//         }

		//#region Helper Methods

		//private void CreatePasswords(string password, out byte[] passwordHash, out byte[] passwordSalt)
		//{
		//	using (var hmac = new HMACSHA512())
		//	{
		//		passwordSalt = hmac.Key;
		//		passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
		//	}
		//}

		//#endregion



