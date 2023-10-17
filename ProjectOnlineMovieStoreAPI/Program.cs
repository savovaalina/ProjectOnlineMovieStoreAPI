var builder = WebApplication.CreateBuilder(args);

// Ovde gi spremame site servisi i
// konfiguracii koisto sakame da gi
// koristime vo nashata aplikacija


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
