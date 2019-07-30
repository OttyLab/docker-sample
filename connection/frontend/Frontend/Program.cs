using System.Net;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Frontend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseKestrel((context, options) =>
                {
                    options.Listen(IPAddress.Any, 8080, listenOptions =>
                    {
                        listenOptions.UseHttps("server.pfx", "");
                    });
                });
    }
}
