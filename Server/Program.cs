using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Server
{
	public class Program : object
	{
		public Program() : base()
		{
		}

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
