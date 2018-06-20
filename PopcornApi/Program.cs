using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace PopcornApi
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseApplicationInsights()
                .Build();

            await host.RunAsync();
        }
    }
}
