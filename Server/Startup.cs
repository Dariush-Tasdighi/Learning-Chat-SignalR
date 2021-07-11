using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Server
{
	public class Startup : object
	{
		public const string MyAllowSpecificOrigins = "MyAllowSpecificOrigins";

		public Startup() : base()
		{
		}

		public void ConfigureServices
			(Microsoft.Extensions.DependencyInjection.IServiceCollection services)
		{
			// using Microsoft.Extensions.DependencyInjection;
			services.AddSignalR();

			// Enable CORS: Cross-Origin Requests

			// using Microsoft.Extensions.DependencyInjection;
			services.AddCors(options =>
			{
				options.AddPolicy(name: MyAllowSpecificOrigins,
					builder =>
					{
						builder
							.WithOrigins("https://localhost:44356", "https://googooli.ir")
							.AllowAnyHeader()
							.AllowAnyMethod()
							.AllowCredentials() // In SignalR is important!
							;
					});
			});
		}

		public void Configure
			(Microsoft.AspNetCore.Builder.IApplicationBuilder app,
			Microsoft.AspNetCore.Hosting.IWebHostEnvironment env)
		{
			// using Microsoft.Extensions.Hosting;
			if (env.IsDevelopment())
			{
				// using Microsoft.AspNetCore.Builder;
				app.UseDeveloperExceptionPage();
			}

			// using Microsoft.AspNetCore.Builder;
			app.UseRouting();

			// using Microsoft.AspNetCore.Builder;
			app.UseCors(policyName: MyAllowSpecificOrigins);

			// using Microsoft.AspNetCore.Builder;
			app.UseEndpoints(endpoints =>
			{
				// using Microsoft.AspNetCore.Builder;
				endpoints.MapHub<Hubs.ChatHub>(pattern: "/chathub");
			});
		}
	}
}
