using Microsoft.AspNetCore.Hosting;
using System;
using WebApiTutorial.Services.Products.Core;

namespace WebApiTutorial.Services.Products.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseUrls("http://*:5000")
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
