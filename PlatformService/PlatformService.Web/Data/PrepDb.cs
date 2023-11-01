using PlatformService.Web.Models;

namespace PlatformService.Web.Data;

public static class PrepDb
{
    public static void PrepPopulation(IApplicationBuilder app)
    {
        using(var scope = app.ApplicationServices.CreateScope())
        {
            SeedData(context: scope.ServiceProvider.GetService<AppDbContext>());
        }
    }

    private static void SeedData(AppDbContext context)
    {
        if(!context.Platforms.Any())
        {
            Console.WriteLine(" --> Seeding Data ...");
            context.Platforms.AddRange(
                new Platform() { Name = "Dot Net", Cost = "Free", Publisher = "Microsoft" },
                new Platform() { Name = "SQL Server Express", Cost = "Free", Publisher = "Microsoft" },
                new Platform() { Name = "Kubernetes", Cost = "Free", Publisher = "Cloud Native Computing Foundation" }
            );

            context.SaveChanges();
        }
        else
        {
            Console.WriteLine(" --> We already have data");
        }
    }
}
