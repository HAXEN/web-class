using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using WebApplication3.Test;

namespace WebApplication3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var writer = new WriteFooContent();

            foreach (var foo in writer.GetAllFoos())
            {
                Console.WriteLine(foo.Name);
            }

            
            Console.ReadKey();

            //CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}