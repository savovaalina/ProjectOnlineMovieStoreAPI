using Microsoft.EntityFrameworkCore;
using OnlineMovieStore.Data;

var builder = WebApplication.CreateBuilder(args);

// Ovde gi spremame site servisi i
// konfiguracii koisto sakame da gi
// koristime vo nashata aplikacija

ConfigurationManager configuration = builder.Configuration; // access and setup the config
IWebHostEnvironment environment = builder.Environment; // acess and setup the envirement
// Add services to the container.

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
