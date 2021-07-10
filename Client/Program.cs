using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Client
{
	public class Program
	{
		public static void Main(string[] args)
		{
			// using Microsoft.Extensions.Hosting;
			CreateHostBuilder(args).Build().Run();
		}

		public static Microsoft.Extensions.Hosting.IHostBuilder CreateHostBuilder(string[] args) =>
			Microsoft.Extensions.Hosting.Host.CreateDefaultBuilder(args)
				.ConfigureWebHostDefaults(webBuilder =>
				{
					// using Microsoft.AspNetCore.Hosting;
					webBuilder.UseStartup<Startup>();
				});
	}
}
