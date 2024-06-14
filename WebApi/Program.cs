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
//.Environment �zelli�i, uygulaman�n hangi �evrede (development, staging, production vb.) �al��t���n� belirlemek i�in kullan�l�r.

//.IsProduction() metodu ise, uygulaman�n �u anda �retim (production) �evresinde mi �al���p �al��mad���n� kontrol etmek i�in kullan�l�r. E�er uygulama �retim �evresinde �al���yorsa, true de�eri d�ner; aksi halde, false de�eri d�ner.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
