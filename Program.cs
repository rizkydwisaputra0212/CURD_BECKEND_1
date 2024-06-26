using Microsoft.EntityFrameworkCore;
using db_siswa_api.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Configure DbContext with PostgreSQL
builder.Services.AddDbContext<SiswaContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();

//disini pastikan bahwa siswacontext sudah di konfigurasi spt berikut

/*==============================================
// Configure DbContext with PostgreSQL
builder.Services.AddDbContext<SiswaContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
    
    */

//kemudian bikin controller untuk CURD disini kita akan bikin siswacontroller.cs
//pindah ke siswa controller