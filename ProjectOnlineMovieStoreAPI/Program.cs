using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption;
using Microsoft.EntityFrameworkCore;
using OnlineMovieStore.Data;
using OnlineMovieStore.Repositories;
using OnlineMovieStore.Repository.Interfaces;
using OnlineMovieStore.Service.Interfaces;
using OnlineMovieStore.Services;

var builder = WebApplication.CreateBuilder(args);

// Ovde gi spremame site servisi i
// konfiguracii koisto sakame da gi
// koristime vo nashata aplikacija

ConfigurationManager configuration = builder.Configuration; // access and setup the config
IWebHostEnvironment environment = builder.Environment; // acess and setup the envirement
// Add/ register services to the container.

builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IMovieService, MovieService>();
builder.Services.AddScoped<IMovieCategoryService, MovieCategoryService>();
builder.Services.AddScoped<IBookmarkMovieService, BookmarkMovieService>();  
builder.Services.AddScoped<ILanguageService, LanguageService>();    
builder.Services.AddScoped<IMovieSearchService, MovieSearchService>();
builder.Services.AddScoped<IPhotoMovieService, PhotoMovieService>();
builder.Services.AddScoped<IShowsService, ShowsService>();
builder.Services.AddScoped<IUserService, UserService>();

//Add/ register repositories to the container

builder.Services.AddScoped<IAuthRepository, AuthRepository>();
builder.Services.AddScoped<IBookmarkMovieRepository, BookmarkMovieRepository>();
builder.Services.AddScoped<ILanguageRepository, LanguageRepository>();
builder.Services.AddScoped<IMovieCategoryRepository, MovieCategoryRepository>();
builder.Services.AddScoped<IMovieSearchRepository, MovieSearchRepository>();
builder.Services.AddScoped<IPhotoMovieRepository, PhotoMovieRepository>();
builder.Services.AddScoped<IShowsRepository, ShowsRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddCors(c => c.AddPolicy("OnlineMoviestoreCorsPolicy", builder =>
{
    builder
    //.WithOrigins()
    .AllowAnyHeader()
    .AllowAnyMethod()
    .AllowAnyOrigin();
}));

builder.Services.AddDbContext<OnlineMovieStoreDbContext>(options =>
{
    if (environment.EnvironmentName.Equals("Production"))
    {
        options.UseSqlServer(configuration.GetValue<string>("Configuration:ConnectionStringProduction"),
        sqlServerOptionsAction: sqlOptions =>
        {
            sqlOptions.EnableRetryOnFailure();

        });
        options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);//TODO
    }
    else
    {
        options.UseSqlServer(configuration.GetValue<string>("Configuration:ConnectionString"),
        sqlServerOptionsAction: sqlOptions =>
        {
            sqlOptions.EnableRetryOnFailure();

        });
        options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);//TODO

    }
});


// ------------------------------------------------------------------------------------------



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors("OnlineMoviestoreCorsPolicy");

app.Run();
