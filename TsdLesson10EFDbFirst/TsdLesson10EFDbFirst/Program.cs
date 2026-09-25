using Microsoft.EntityFrameworkCore;
using TsdLesson10EFDbFirst.Models;
namespace TsdLesson10EFDbFirst
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //Laays lien ket tu appsettings.json
            var connectionString = builder.Configuration.GetConnectionString("TsdK24cnt1lesson10EfdbConnection");
            builder.Services.AddDbContext<TsdK24cnt1lesson10EfdbContext>(x => x.UseSqlServer(connectionString));
            var app = builder.Build();

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
        }
    }
}
