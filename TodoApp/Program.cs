namespace TodoApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

             
            builder.Services.AddControllersWithViews();

            
            var app = builder.Build();

            //app.MapGet("/BDU", () => new
            //{
            //    name = "Lamiya",
            //    lesson = "MVC"
            //});

            //app.MapControllerRoute("default", "{controller=Home}/{action=Hi}/{id?}");


            app.MapControllerRoute("default", "{controller=Todo}/{action=Look}/{id?}");
            app.Run();
        }
    }
}
