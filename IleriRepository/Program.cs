using IleriRepository.Context;
using IleriRepository.Data;
using IleriRepository.Models;
using IleriRepository.Repositories.Abstract;
using IleriRepository.Repositories.Concretes;
using IleriRepository.UnitOfWork;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<MyContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("Baglanti")));
builder.Services.AddScoped<IPersonelRep, PersonelRep<Personel>>();//
builder.Services.AddScoped<ICityRep, CityRep<City>>();
builder.Services.AddScoped<ICountyRep,CountyRep<County>>();
builder.Services.AddScoped<IGradeRep, GradeRep<Grade>>();
builder.Services.AddScoped<IDepartmentRep, DepartmentRep<Department>>();
builder.Services.AddScoped<IUnit, Unit>();
builder.Services.AddScoped<CityModel>();
builder.Services.AddScoped<CountyModel>();
builder.Services.AddScoped<List<City>>();



var app = builder.Build();
//newLemek instance oluşturmaktır.
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
