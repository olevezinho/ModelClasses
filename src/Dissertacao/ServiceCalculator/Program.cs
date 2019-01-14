namespace ServiceCalculator
{
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.DependencyInjection;

    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            IWebHostBuilder hostBuilder = WebHost.CreateDefaultBuilder(args).UseStartup<Startup>();

            IWebHost host = hostBuilder.Build();

            //using (var scope = host.Services.CreateScope())
            //{
            //    var db = scope.ServiceProvider.GetService<ModelClassesContext>();
            //    db.Migrate();
            //}

            return host;
        }
    }
}
