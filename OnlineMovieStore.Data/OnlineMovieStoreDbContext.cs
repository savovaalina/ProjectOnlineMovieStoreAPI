
    namespace OnlineMovieStore.Data
    {
        using Microsoft.EntityFrameworkCore;
        using OnlineMovieStore.Entities;
        using System;
        using System.Collections.Generic;
        using System.Linq;
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
                base.OnModelCreating(builder);


            }



        }
    }