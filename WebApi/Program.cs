using Application;
using Core.CrossCuttingConcerns.Exceptions.Extension;
using Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddApplicationServices();
builder.Services.AddPersistenceServices(builder.Configuration);

//builder.Services.AddDistributedMemoryCache();
builder.Services.AddStackExchangeRedisCache(opt => opt.Configuration = "localhost:6379");

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
//if (app.Environment.IsProduction())
//{
//    app.ConfigureCustomExceptionMiddleware();
//}
app.ConfigureCustomExceptionMiddleware();
//.Environment özelliði, uygulamanýn hangi çevrede (development, staging, production vb.) çalýþtýðýný belirlemek için kullanýlýr.

//.IsProduction() metodu ise, uygulamanýn þu anda üretim (production) çevresinde mi çalýþýp çalýþmadýðýný kontrol etmek için kullanýlýr. Eðer uygulama üretim çevresinde çalýþýyorsa, true deðeri döner; aksi halde, false deðeri döner.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
