using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ToDoList.Models;
using Microsoft.AspNetCore.Identity;

namespace ToDoList
{
  class Program
  {
    static void Main(string[] args)
    {
      var builder = WebApplication.CreateBuilder(args);

      builder.Services.AddControllersWithViews();

      // DbContext (Pomelo MySQL)
      var cs = builder.Configuration["ConnectionStrings:DefaultConnection"];
      builder.Services.AddDbContext<ToDoListContext>(options =>
          options.UseMySql(cs, ServerVersion.AutoDetect(cs)));

      // Identity (uses ToDoListContext for stores)
      builder.Services
        .AddIdentity<ApplicationUser, IdentityRole>(options =>
        {
          options.Password.RequireNonAlphanumeric = false;
          options.Password.RequireUppercase = false;
          options.Password.RequireLowercase = false;
          options.Password.RequireDigit = false;
          options.Password.RequiredLength = 6;
        })
        .AddEntityFrameworkStores<ToDoListContext>()
        .AddDefaultTokenProviders();

      var app = builder.Build();

      // app.UseDeveloperExceptionPage(); // optional

      app.UseHttpsRedirection();
      app.UseStaticFiles();

      app.UseRouting();

      // Auth middleware
      app.UseAuthentication();
      app.UseAuthorization();

      app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
      );

      app.Run();
    }
  }
}


// using Microsoft.AspNetCore.Builder;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.Extensions.DependencyInjection;
// using ToDoList.Models;
// using Microsoft.AspNetCore.Identity;

// namespace ToDoList
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

//       builder.Services.AddControllersWithViews();

//       builder.Services.AddDbContext<ToDoListContext>(
//                         dbContextOptions => dbContextOptions
//                           .UseMySql(
//                             builder.Configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(builder.Configuration["ConnectionStrings:DefaultConnection"]
//                           )
//                         )
//                       );

//       WebApplication app = builder.Build();

//       // app.UseDeveloperExceptionPage();
//       app.UseHttpsRedirection();
//       app.UseStaticFiles();

//       app.UseRouting();

//       app.MapControllerRoute(
//           name: "default",
//           pattern: "{controller=Home}/{action=Index}/{id?}");

//       app.Run();
//     }
//   }
// }