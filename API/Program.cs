using System;
using API.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Build the project and store it in variable
            var host = CreateHostBuilder(args).Build();

            // Create a scope of the project
            var scope = host.Services.CreateScope();

            var context = scope.ServiceProvider.GetRequiredService<StoreContext>();

            var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();

            // Attempt to migrate any database changes on startup, and run the initializer method of DbInitializer class

            try
            {
                // Migrate any new changes to the database
                context.Database.Migrate();
                // Initialize and seed the database with product information
                DbInitializer.Initialize(context);
            }
            catch (Exception e)
            {
                logger.LogError(e, "Problem migrating data");
            }
            finally
            {
                // Free memory of scope after method completes
                scope.Dispose();
            }

            // Run the host application
            host.Run();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
