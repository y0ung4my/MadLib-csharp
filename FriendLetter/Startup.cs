// import necessary dependencies,  .NET namespaces that are required for creating a web application
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

//It's standard practice to use a namespace that reflects the name of the project.
namespace FriendLetter
{
  public class Startup
  {
    // This constructor will create an iteration of the Startup class that contains specific settings and variables to run our project successfully.
    // Required for configuring a basic ASP.NET Core MVC project.
    public Startup(IWebHostEnvironment env)
    {
      var builder = new ConfigurationBuilder()
          .SetBasePath(env.ContentRootPath)
          .AddEnvironmentVariables();
      Configuration = builder.Build();
    }

    // This is part of adding custom configurations to the project
    public IConfigurationRoot Configuration { get; }
    // ConfigureServices() is a required built-in method to set up an application's server
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddMvc();
    }
    // The Configure() method is built-in and required in all ASP.NET Core apps. ASP.NET calls Configure() when the app launches. It's responsible for telling our app how to handle requests to the server.
    public void Configure(IApplicationBuilder app)
    {
      //states which area of our application should load by default when it launches:
      app.UseRouting();

      app.UseEndpoints(routes =>
      {
        routes.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
      });

      app.Run(async (context) =>
      {
        await context.Response.WriteAsync("Hello World!");
      });
    }
  }
}