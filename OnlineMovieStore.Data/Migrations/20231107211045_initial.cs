using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineMovieStore.Data.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    IsPopular = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookmarkMovies",
                columns: table => new
                {
                    BookmarkMovieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WatchLater = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookmarkMovies", x => x.BookmarkMovieId);
                });

            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    LoginMovieId = table.Column<int>(type: "int", maxLength: 100, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoginUsername = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.LoginMovieId);
                });

            migrationBuilder.CreateTable(
                name: "MovieCategories",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genre = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: true),
                    LastUpdate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieCategories", x => x.MovieId);
                });

            migrationBuilder.CreateTable(
                name: "MovieSearches",
                columns: table => new
                {
                    SearchMovieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieGenre = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    MovieMovieName = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    MovieIsPopular = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieSearches", x => x.SearchMovieId);
                });

            migrationBuilder.CreateTable(
                name: "Producer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shows",
                columns: table => new
                {
                    ShowMovieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShowMovieName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ShowDescription = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    ShowType = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shows", x => x.ShowMovieId);
                });

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<double>(type: "float", nullable: false),
                    SoldSubscriptions = table.Column<int>(type: "int", nullable: false),
                    SubscriptionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    MovieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: true),
                    UserAdress = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: true),
                    UserCountry = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    UserCity = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(650)", maxLength: 650, nullable: true),
                    UserCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    UserAge = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.MovieId);
                });

            migrationBuilder.CreateTable(
                name: "webLanguages",
                columns: table => new
                {
                    LanguageMovieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageMovieName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_webLanguages", x => x.LanguageMovieId);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovieName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    MovePart = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovieLength = table.Column<int>(type: "int", nullable: false),
                    MovieRating = table.Column<int>(type: "int", nullable: false),
                    MovieCountry = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MovieYearOfRelease = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MovieDirector = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MovieProducer = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MovieActors = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    MovieDescription = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    MovieLanguage = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CategoryGenre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryMovieId = table.Column<int>(type: "int", nullable: false),
                    PhotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    SoldSubscriptions = table.Column<int>(type: "int", nullable: false),
                    IsPopular = table.Column<bool>(type: "bit", nullable: false),
                    ActorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieId);
                    table.ForeignKey(
                        name: "FK_Movies_Actor_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actor",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Movies_MovieCategories_CategoryMovieId",
                        column: x => x.CategoryMovieId,
                        principalTable: "MovieCategories",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhotoMovies",
                columns: table => new
                {
                    PhotoMovieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(650)", maxLength: 650, nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsMain = table.Column<bool>(type: "bit", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotoMovies", x => x.PhotoMovieId);
                    table.ForeignKey(
                        name: "FK_PhotoMovies_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId");
                });

            migrationBuilder.InsertData(
                table: "Actor",
                columns: new[] { "Id", "IsPopular", "Name", "ShortDescription" },
                values: new object[,]
                {
                    { 1, true, "Richard Tiffany Gere", "Richard Tiffany Gere is an American actor. He began in films in the 1970s, playing a supporting role in Looking for Mr. Goodbar and a starring role in Days of Heaven. He came to prominence with his role in the film American Gigolo, which established him as a leading man and a sex symbol." },
                    { 2, true, "Thomas Cruise", "Thomas Cruise Mapother IV is an American actor, producer and pilot. One of the world's highest-paid actors, he has received various accolades, including an Honorary Palme d'Or and three Golden Globe Awards, in addition to nominations for four Academy Awards." },
                    { 3, true, "Morgan Freeman", "Morgan Freeman is an American actor, producer, and narrator. He is known for his distinctive deep voice and various roles in a wide variety of film genres" },
                    { 4, true, "Alfredo James Pacino", "Alfredo James Pacino is an American actor. Considered one of the greatest and most influential actors of the 20th century, Pacino has received numerous accolades: including an Academy Award" },
                    { 5, true, "Christian Charles Philip Bale", "Christian Charles Philip Bale is an English actor. Known for his versatility and physical transformations for his roles, he has been a leading man in films of several genres. He has received various accolades, including an Academy Award and two Golden Globe Awards." },
                    { 6, false, "James Eugene Carrey", "James Eugene Carrey is a Canadian and American actor and comedian. Known for his energetic slapstick performances, Carrey first gained recognition in 1990, after landing a role in the American sketch comedy television series In Living Color." },
                    { 7, false, "Ryan Thomas Gosling", "Ryan Thomas Gosling is a Canadian actor. Prominent in both independent film and major studio features of varying genres, his films have accrued a worldwide box office gross of over 1.9 billion USD." },
                    { 8, false, "Robbie Robertson", "Jaime Royal \"Robbie\" Robertson OC was a Canadian musician. He was lead guitarist for Bob Dylan in the mid-late 1960s and early-mid 1970s, guitarist and songwriter with the Band from their inception until 1978, and a solo artist. Robertson's work with the Band was instrumental in creating the Americana music genre." },
                    { 9, false, "Bill Istvan Günther Skarsgård", "Bill Istvan Günther Skarsgård is a Swedish actor. He is best known for portraying Pennywise in the horror films It and It Chapter Two, based on Stephen King's novel of the same name. Other horror appearances were in the film Barbarian and the series Hemlock Grove and Castle Rock." },
                    { 10, false, "Noah Leslie Hathaway", "Noah Leslie Hathaway is an American actor and a former teen idol. He is best known for his roles as Atreyu in the 1984 film The NeverEnding Story and for portraying Boxey on the original television series Battlestar Galactica. His work in The NeverEnding Story made him particularly popular as a teen idol in Europe" }
                });

            migrationBuilder.InsertData(
                table: "MovieCategories",
                columns: new[] { "MovieId", "Genre", "LastUpdate", "MovieName" },
                values: new object[,]
                {
                    { 1, null, null, "Fiction" },
                    { 2, null, null, "Action" },
                    { 3, null, null, "Crime" },
                    { 4, null, null, "Adventure" },
                    { 5, null, null, "Drama" },
                    { 6, null, null, "Fantasy" },
                    { 7, null, null, "Thrillers" },
                    { 8, null, null, "General" },
                    { 9, null, null, "Horror" },
                    { 10, null, null, "Uncategorised" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "ActorId", "ActorName", "CategoryGenre", "CategoryMovieId", "IsPopular", "MovePart", "MovieActors", "MovieCountry", "MovieDescription", "MovieDirector", "MovieLanguage", "MovieLength", "MovieName", "MovieProducer", "MovieRating", "MovieYearOfRelease", "PhotoUrl", "Price", "SoldSubscriptions" },
                values: new object[,]
                {
                    { 1, null, null, null, 0, true, null, null, "Japan", "Synopsis. This heartwarming true story is an American adaptation of a Japanese tale about a loyal dog named Hachiko. This very special friend would accompany his master to the train station every day and return each afternoon to greet him after work.", "Lasse Hallström", null, 0, "Hachiko", null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.0, 0 },
                    { 2, null, null, null, 0, true, null, null, "USA", "An American agent, under false suspicion of disloyalty, must discover and expose the real spy without the help of his organization. Ethan Hunt (Tom Cruise) and his I.M.F. team go undercover to bring down the N.O.C. list, a list of every Agent and spy in the I.M.F.", "Tom Cruise", null, 0, "Mission Impossible", null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.0, 0 },
                    { 3, null, null, null, 0, true, null, null, "USA", "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion.", "Frank Darabont", null, 0, "The Shawshank Redemption", null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.0, 0 },
                    { 4, null, null, null, 0, true, null, null, "USA", "Don Vito Corleone, head of a mafia family, decides to hand over his empire to his youngest son Michael. However, his decision unintentionally puts the lives of his loved ones in grave danger.", "Francis Ford Coppola", null, 0, "The Godfather", null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.0, 0 },
                    { 5, null, null, null, 0, false, null, null, "USA", "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.", "Christopher Nolan", null, 0, "The Dark Knight", null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.0, 0 },
                    { 6, null, null, null, 0, false, null, null, "USA", "Imbecilic best friends Lloyd Christmas (Jim Carrey) and Harry Dunne (Jeff Daniels) stumble across a suitcase full of money left behind in Harry's car by Mary Swanson (Lauren Holly), who was on her way to the airport. The pair decide to go to Aspen, Colo., to return the money, unaware that it is connected to a kidnapping. As Harry and Lloyd -- who has fallen in love with Mary -- are pursued across the country by hired killers and police, they find both their friendship and their brains tested.", "Peter Farrelly", null, 0, "Dumb and dumber", null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.0, 0 },
                    { 7, null, null, null, 0, false, null, null, "USA", "In 1940s South Carolina, mill worker Noah Calhoun (Ryan Gosling) and rich girl Allie (Rachel McAdams) are desperately in love. But her parents don't approve. When Noah goes off to serve in World War II, it seems to mark the end of their love affair. In the interim, Allie becomes involved with another man (James Marsden). But when Noah returns to their small town years later, on the cusp of Allie's marriage, it soon becomes clear that their romance is anything but over.", "Nick Cassavetes", null, 0, "The Notebook", null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.0, 0 },
                    { 8, null, null, null, 0, true, null, null, "USA", "Seventeen years after joining forces as the backing band for rockabilly cult hero Ronnie Hawkins, Canadian roots rockers The Band call it quits with a lavish farewell show at San Francisco's Winterland Ballroom on Nov. 25, 1976. Filmed by Martin Scorsese, this documentary features standout performances by rock legends such as Bob Dylan, Van Morrison, Eric Clapton, Joni Mitchell and Muddy Waters, as well as interviews tracing the group's history and discussing road life.", "Martin Scorsese", null, 0, "The Last Waltz", null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.0, 0 },
                    { 9, null, null, null, 0, false, null, null, "USA", "A young woman discovers the rental home she booked is already occupied by a stranger. Against her better judgment, she decides to spend the night but soon discovers there's a lot more to fear than just an unexpected house guest.", "Zach Cregger", null, 0, "Barbarian", null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.0, 0 },
                    { 10, null, null, null, 0, false, null, null, "USA", "On his way to school, Bastian (Barret Oliver) ducks into a bookstore to avoid bullies. Sneaking away with a book called The Neverending Story, Bastian begins reading it in the school attic. The novel is about Fantasia, a fantasy land threatened by The Nothing, a darkness that destroys everything it touches. The kingdom needs the help of a human child to survive. When Bastian reads a description of himself in the book, he begins to wonder if Fantasia is real and needs him to survive.", "Wolfgang Petersen", null, 0, "TheNeverEnding Story", null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Producer",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Richard Gere" },
                    { 2, "Tom Cruise" },
                    { 3, "Niki Marvin" },
                    { 4, "Francis Ford Coppola" },
                    { 5, "Christopher Nolan" },
                    { 6, "Peter Farrelly" },
                    { 7, "Mark Johnson" },
                    { 8, "Garth Hudson" },
                    { 9, "Roy Lee" },
                    { 10, "Bernd Eichinger" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "MovieId", "Description", "IsAdmin", "PasswordHash", "PasswordSalt", "Phone", "UserAdress", "UserAge", "UserCity", "UserCountry", "UserCreated", "UserEmail", "UserName" },
                values: new object[] { new Guid("5fb79765-7acc-495c-84f9-33052e87cf53"), "****Admin User ****", true, new byte[] { 205, 180, 199, 254, 212, 49, 143, 84, 112, 247, 251, 226, 112, 44, 121, 223, 23, 8, 142, 15, 156, 244, 113, 84, 158, 52, 168, 64, 26, 164, 129, 95, 146, 9, 54, 15, 9, 179, 116, 165, 177, 200, 147, 7, 91, 0, 83, 43, 64, 145, 238, 221, 174, 213, 132, 85, 216, 24, 16, 41, 153, 198, 146, 189 }, new byte[] { 228, 10, 166, 123, 8, 238, 185, 189, 201, 214, 239, 67, 128, 3, 249, 137, 88, 230, 83, 122, 194, 63, 226, 84, 36, 95, 27, 114, 13, 107, 40, 107, 156, 25, 244, 192, 124, 175, 192, 58, 109, 77, 240, 198, 41, 23, 112, 233, 250, 176, 18, 43, 208, 135, 178, 148, 205, 135, 47, 23, 10, 183, 20, 3, 53, 21, 122, 35, 227, 82, 205, 80, 205, 195, 130, 151, 231, 48, 75, 171, 155, 15, 244, 74, 8, 223, 35, 104, 0, 16, 153, 240, 12, 150, 91, 242, 182, 225, 199, 218, 136, 62, 75, 74, 193, 16, 131, 161, 234, 43, 47, 184, 51, 144, 219, 14, 209, 77, 51, 77, 239, 239, 87, 8, 164, 3, 39, 220 }, "22332025", "/", 0, "Skopje", "Macedonia", new DateTime(2023, 11, 7, 22, 10, 45, 523, DateTimeKind.Local).AddTicks(1159), "smx.test@smx.com", "onlineMoviestoreUsername" });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_ActorId",
                table: "Movies",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CategoryMovieId",
                table: "Movies",
                column: "CategoryMovieId");

            migrationBuilder.CreateIndex(
                name: "IX_PhotoMovies_MovieId",
                table: "PhotoMovies",
                column: "MovieId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookmarkMovies");

            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.DropTable(
                name: "MovieSearches");

            migrationBuilder.DropTable(
                name: "PhotoMovies");

            migrationBuilder.DropTable(
                name: "Producer");

            migrationBuilder.DropTable(
                name: "Shows");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "webLanguages");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Actor");

            migrationBuilder.DropTable(
                name: "MovieCategories");
        }
    }
}
