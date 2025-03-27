using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;

namespace MVC_Train_Routing
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();


            var app = builder.Build();


            app.MapGet("/", () => "Hello World!");


            //app.MapGet(pattern: "/CEO/{ID}", requestDelegate: async context =>
            //{
            //    //First way to Route 
            //    var name /* = context.GetRouteValue("name")*/
            //    //second way ..              // it's indexer
            //              = context.Request.RouteValues["ID"];
            //    await context.Response.WriteAsync($"hello {name}");
            //});
           

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller}/{action}/{id?}",
                defaults: new { Controller = "Movie", action = "GETMovie" }
              //  constraints: new { id = new IntRouteConstraint() }
             // constraints :new {id =@"\d{2}"}
             );


            app.Run();
        }
    }
}
