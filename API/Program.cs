using Application;
using Application.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddServices(builder.Configuration);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));

builder.Services.AddCors(options => options.AddDefaultPolicy(
    policy => policy.AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod()));

builder.Services.AddSwaggerGen(c => c.SwaggerDoc("v1", new OpenApiInfo { Title = "nFlow", Version = "v1" }));
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlite("Data Source=./nflow.db");

    //options.UseNpgsql(configuration.GetConnectionString("localdb"));
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.ConfigObject.AdditionalItems.Add("syntaxHighlight", false); //Turns off syntax highlight which causing performance issues...
    });
}

app.MapControllers();

app.Run();