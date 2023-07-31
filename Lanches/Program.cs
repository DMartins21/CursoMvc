using Lanches;
using System.Security.Cryptography.X509Certificates;
namespace Program;

public class Program 
{
    public static IHostBuilder CreateHostBuilder(string[] args) => 
        Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder => 
        { 
            webBuilder.UseStartup<Startup>(); 
        });

    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }
}