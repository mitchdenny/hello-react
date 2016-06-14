using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace HelloReact
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>();

            using (var host = builder.Build())
            {
                host.Start();

                Console.WriteLine("Press ENTER to stop.");
                Console.ReadLine();
            }
        }
    }
}
