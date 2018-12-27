using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace StarChart
{
    public class Program
    {
#pragma warning disable CS1591
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
#pragma warning restore CS1591
}
