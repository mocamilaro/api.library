using api.library.DAL;
using api.library.LibraryMapper;
using api.library.Repository;
using api.library.Repository.IRepository;
using api.library.Services.IServices;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<ApplicationDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

builder.Services.AddAutoMapper(x => x.AddProfile<Mappers>());

// Dependency injection for services
builder.Services.AddScoped<IBookService, IBookService>();
builder.Services.AddScoped<IBorrowService, IBorrowService>();
builder.Services.AddScoped<ICopyService, ICopyService>();
builder.Services.AddScoped<IDetailService, IDetailService>();
builder.Services.AddScoped<IPersonService, IPersonService>();
builder.Services.AddScoped<IUserService, IUserService>();
// Dependency injection for repositories
builder.Services.AddScoped<IBookRepository, IBookRepository>();
builder.Services.AddScoped<IBorrowRepository, IBorrowRepository>();
builder.Services.AddScoped<ICopyRepository, ICopyRepository>();
builder.Services.AddScoped<IDetailRepository, IDetailRepository>();
builder.Services.AddScoped<IPersonRepository, IPersonRepository>();
builder.Services.AddScoped<IUserRepository, IUserRepository>();



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

app.Run();
