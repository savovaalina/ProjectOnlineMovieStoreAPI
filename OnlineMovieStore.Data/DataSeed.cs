using Microsoft.EntityFrameworkCore;
using OnlineMovieStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieStore.Data
{
    public class DataSeed
    {
        public static void Seed(ModelBuilder builder, string username, byte[] passwordHash, byte[] passwordSalt)
        {
            #region User Admin Seed
            builder.Entity<User>().HasData(
                new User
                {
                    MovieId = Guid.NewGuid(),
                    UserName = username,
                    UserEmail = "smx.test@smx.com",
                    UserCity = "Skopje",
                    UserCountry = "Macedonia",
                    UserAdress = "/",
                    UserCreated = DateTime.Now,
                    Description = "****Admin User ****",
                    Phone = "22332025",
                    PasswordHash = passwordHash,
                    PasswordSalt = passwordSalt,
                    IsAdmin = true,
                });
            #endregion

            #region Movie Category Seed Data
            builder.Entity<MovieCategory>().HasData
               (new MovieCategory
               {
                   MovieId = 1,
                   MovieName = "Fiction"
               },
               new MovieCategory
               {
                   MovieId = 2,
                   MovieName = "Action"
               },
               new MovieCategory
               {
                   MovieId = 3,
                   MovieName = "Crime"
               },
               new MovieCategory
               {
                   MovieId = 4,
                   MovieName = "Adventure"
               },
               new MovieCategory
               {
                   MovieId = 5,
                   MovieName = "Drama"
               },
               new MovieCategory
               {
                   MovieId = 6,
                   MovieName = "Fantasy"
               },
               new MovieCategory
               {
                   MovieId = 7,
                   MovieName = "Thrillers"
               },
               new MovieCategory
               {
                   MovieId = 8,
                   MovieName = "General"
               },
               new MovieCategory
               {
                   MovieId = 9,
                   MovieName = "Horror"
               },
               new MovieCategory
               {
                   MovieId = 10,
                   MovieName = "Uncategorised"
               });
            #endregion

            #region Movie Seed Data
            builder.Entity<Movie>().HasData(
              new Movie
              {
                  MovieId = 1,
                  MovieName = "Hachiko",
                  MovieDescription = "Synopsis. This heartwarming true story is an American adaptation of " +
                  "a Japanese tale about a loyal dog named Hachiko. This very special friend would accompany " +
                  "his master to the train station every day and return each afternoon to greet him after work.",
                  MovieDirector = "Lasse Hallström",
                  MovieCountry = "Japan",
                  IsPopular = true,
              },
              new Movie
              {
                  MovieId = 2,
                  MovieName = "Mission Impossible",
                  MovieDescription = "An American agent, under false suspicion of disloyalty, must discover and expose " +
                  "the real spy without the help of his organization. Ethan Hunt (Tom Cruise) and his I.M.F. team go " +
                  "undercover to bring down the N.O.C. list, a list of every Agent and spy in the I.M.F.",
                  MovieDirector = "Tom Cruise",
                  MovieCountry = "USA",
                  IsPopular = true,
              },
              new Movie
              {
                  MovieId = 3,
                  MovieName = "The Shawshank Redemption",
                  MovieDescription = "Over the course of several years, two convicts form a friendship," +
                  " seeking consolation and, eventually, redemption through basic compassion.",
                  MovieDirector = "Frank Darabont",
                  MovieCountry = "USA",
                  IsPopular = true,
              },
              new Movie
              {
                  MovieId = 4,
                  MovieName = "The Godfather",
                  MovieDescription = "Don Vito Corleone, head of a mafia family, decides to hand over his " +
                  "empire to his youngest son Michael. However, his decision unintentionally puts the lives of " +
                  "his loved ones in grave danger.",
                  MovieDirector = "Francis Ford Coppola",
                  MovieCountry = "USA",
                  IsPopular = true,
              },
              new Movie
              {
                  MovieId = 5,
                  MovieName = "The Dark Knight",
                  MovieDescription = "When the menace known as the Joker wreaks havoc and chaos on the people " +
                  "of Gotham, Batman must accept one of the greatest psychological and physical tests of his " +
                  "ability to fight injustice.",
                  MovieDirector = "Christopher Nolan",
                  MovieCountry = "USA",
                  IsPopular = false,
              },
              new Movie
              {
                  MovieId = 6,
                  MovieName = "Dumb and dumber",
                  MovieDescription = "Imbecilic best friends Lloyd Christmas (Jim Carrey) and Harry Dunne " +
                  "(Jeff Daniels) stumble across a suitcase full of money left behind in Harry's car " +
                  "by Mary Swanson (Lauren Holly), who was on her way to the airport. The pair decide " +
                  "to go to Aspen, Colo., to return the money, unaware that it is connected to a kidnapping. " +
                  "As Harry and Lloyd -- who has fallen in love with Mary -- are pursued across the country " +
                  "by hired killers and police, they find both their friendship and their brains tested.",
                  MovieDirector = "Peter Farrelly",
                  MovieCountry = "USA",
                  IsPopular = false,
              },
              new Movie
              {
                  MovieId = 7,
                  MovieName = "The Notebook",
                  MovieDescription = "In 1940s South Carolina, mill worker Noah Calhoun (Ryan Gosling) and rich girl " +
                  "Allie (Rachel McAdams) are desperately in love. But her parents don't approve. " +
                  "When Noah goes off to serve in World War II, it seems to mark the end of their love " +
                  "affair. In the interim, Allie becomes involved with another man (James Marsden). " +
                  "But when Noah returns to their small town years later, on the cusp of Allie's marriage, " +
                  "it soon becomes clear that their romance is anything but over.",
                  MovieDirector = "Nick Cassavetes",
                  MovieCountry = "USA",
                  IsPopular = false,
              },
              new Movie
              {
                  MovieId = 8,
                  MovieName = "The Last Waltz",
                  MovieDescription = "Seventeen years after joining forces as the backing band for rockabilly cult hero" +
                  " Ronnie Hawkins, Canadian roots rockers The Band call it quits with a lavish farewell show at San Francisco" +
                  "'s Winterland Ballroom on Nov. 25, 1976. Filmed by Martin Scorsese, this documentary features standout " +
                  "performances by rock legends such as Bob Dylan, Van Morrison, Eric Clapton, Joni Mitchell and " +
                  "Muddy Waters, as well as interviews tracing the group's history and discussing road life.",
                  MovieDirector = "Martin Scorsese",
                  MovieCountry = "USA",
                  IsPopular = true,
              },
              new Movie
              {
                  MovieId = 9,
                  MovieName = "Barbarian",
                  MovieDescription = "A young woman discovers the rental home she booked is already occupied " +
                  "by a stranger. Against her better judgment, she decides to spend the night but soon " +
                  "discovers there's a lot more to fear than just an unexpected house guest.",
                  MovieDirector = "Zach Cregger",
                  MovieCountry = "USA",
                  IsPopular = false,
              },
              new Movie
              {
                  MovieId = 10,
                  MovieName = "TheNeverEnding Story",
                  MovieDescription = "On his way to school, Bastian (Barret Oliver) ducks into a bookstore " +
                  "to avoid bullies. Sneaking away with a book called The Neverending Story," +
                  " Bastian begins reading it in the school attic. The novel is about Fantasia, " +
                  "a fantasy land threatened by The Nothing," +
                  " a darkness that destroys everything it touches. The kingdom needs the help " +
                  "of a human child to survive. When Bastian reads a description of himself in the book, " +
                  "he begins to wonder if Fantasia is real and needs him to survive.",
                  MovieDirector = "Wolfgang Petersen",
                  MovieCountry = "USA",
                  IsPopular = false,
              }
          );
            #endregion

            #region Actor
            builder.Entity<Actor>().HasData(
                new Actor
                {
                    Id = 1,
                    Name = "Richard Tiffany Gere",
                    ShortDescription = "Richard Tiffany Gere is an American actor. He began in films in the 1970s," +
                    " playing a supporting role in Looking for Mr. Goodbar and a starring role in Days of Heaven. " +
                    "He came to prominence with his role in the film American Gigolo, which established him as a leading " +
                    "man and a sex symbol.",
                    IsPopular = true,

                },
                new Actor
                {
                    Id = 2,
                    Name = "Thomas Cruise",
                    ShortDescription = "Thomas Cruise Mapother IV is an American actor, producer and pilot. " +
                    "One of the world's highest-paid actors, he has received various accolades, " +
                    "including an Honorary Palme d'Or and three Golden Globe Awards, in addition to nominations for " +
                    "four Academy Awards.",
                    IsPopular = true,
                },
                new Actor
                {
                    Id = 3,
                    Name = "Morgan Freeman",
                    ShortDescription = "Morgan Freeman is an American actor, producer, and narrator. " +
                    "He is known for his distinctive deep voice and various roles in a wide variety of film genres",
                    IsPopular = true,
                },
                new Actor
                {
                    Id = 4,
                    Name = "Alfredo James Pacino",
                    ShortDescription = "Alfredo James Pacino is an American actor. " +
                    "Considered one of the greatest and most influential actors of the 20th century, " +
                    "Pacino has received numerous accolades: including an Academy Award",
                    IsPopular = true,
                },
                new Actor {
                    Id = 5,
                    Name = "Christian Charles Philip Bale",
                    ShortDescription = "Christian Charles Philip Bale is an English actor." +
                    " Known for his versatility and physical transformations for his roles, " +
                    "he has been a leading man in films of several genres. He has received various accolades, " +
                    "including an Academy Award and two Golden Globe Awards.",
                    IsPopular = true,
                },
                new Actor
                {
                    Id = 6,
                    Name = "James Eugene Carrey",
                    ShortDescription = "James Eugene Carrey is a Canadian and American actor and comedian. " +
                    "Known for his energetic slapstick performances, Carrey first gained recognition in 1990, " +
                    "after landing a role in the American sketch comedy television series In Living Color.",
                    IsPopular = false,
                },
                new Actor
                {
                    Id = 7,
                    Name = "Ryan Thomas Gosling",
                    ShortDescription = "Ryan Thomas Gosling is a Canadian actor. Prominent in both independent film " +
                    "and major studio features of varying genres, his films have accrued a worldwide box " +
                    "office gross of over 1.9 billion USD.",
                    IsPopular = false,
                },
                new Actor
                {
                    Id = 8,
                    Name = "Robbie Robertson",
                    ShortDescription = "Jaime Royal \"Robbie\" Robertson OC was a Canadian musician. He was lead " +
                    "guitarist for Bob Dylan in the mid-late 1960s and early-mid 1970s, guitarist and songwriter " +
                    "with the Band from their inception until 1978, and a solo artist. Robertson's work with " +
                    "the Band was instrumental in creating the Americana music genre.",
                    IsPopular = false,
                },
                new Actor
                {
                    Id = 9,
                    Name = "Bill Istvan Günther Skarsgård",
                    ShortDescription = "Bill Istvan Günther Skarsgård is a Swedish actor. He is best known for " +
                    "portraying Pennywise in the horror films It and It Chapter Two, based on Stephen King's novel " +
                    "of the same name. Other horror appearances were in the film Barbarian and the series Hemlock Grove " +
                    "and Castle Rock.",
                },
                new Actor
                {
                    Id = 10,
                    Name = "Noah Leslie Hathaway",
                    ShortDescription = "Noah Leslie Hathaway is an American actor and a former teen idol. He is best known for his roles " +
                    "as Atreyu in the 1984 film The NeverEnding Story and for portraying Boxey on the original television series " +
                    "Battlestar Galactica. His work in The NeverEnding Story made him particularly popular as a teen idol in Europe"
                });
            #endregion

            #region Producer
            builder.Entity<Producer>().HasData(
                new Producer
                {
                    Id = 1,
                    Name = "Richard Gere",
                },
                new Producer
                {
                    Id = 2,
                    Name = "Tom Cruise",
                },
                new Producer
                {
                    Id = 3,
                    Name = "Niki Marvin"
                },
                new Producer
                {
                    Id = 4,
                    Name = "Francis Ford Coppola",
                },
                new Producer
                {
                    Id = 5,
                    Name = "Christopher Nolan",
                },
                new Producer
                {
                    Id = 6,
                    Name = "Peter Farrelly",
                },
                new Producer
                {
                    Id = 7,
                    Name = "Mark Johnson",
                },
                new Producer
                {
                    Id = 8,
                    Name = "Garth Hudson",
                },
                new Producer
                {
                    Id = 9,
                    Name = "Roy Lee",
                },
                new Producer
                {
                    Id = 10,
                    Name = "Bernd Eichinger",
                });


			#endregion

		}
	}
};