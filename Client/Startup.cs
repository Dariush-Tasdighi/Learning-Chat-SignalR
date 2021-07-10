using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Client
{
	public class Startup : object
	{
		public Startup(Microsoft.Extensions.Configuration.IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public Microsoft.Extensions.Configuration.IConfiguration Configuration { get; }

		public void ConfigureServices
			(Microsoft.Extensions.DependencyInjection.IServiceCollection services)
		{
			// using Microsoft.Extensions.DependencyInjection;
			services.AddRazorPages();
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
			else
			{
				// using Microsoft.AspNetCore.Builder;
				app.UseExceptionHandler("/Error");

				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				// using Microsoft.AspNetCore.Builder;
				app.UseHsts();
			}

			// using Microsoft.AspNetCore.Builder;
			app.UseHttpsRedirection();

			// using Microsoft.AspNetCore.Builder;
			app.UseStaticFiles();

			// using Microsoft.AspNetCore.Builder;
			app.UseRouting();

			// using Microsoft.AspNetCore.Builder;
			app.UseAuthorization();

			// using Microsoft.AspNetCore.Builder;
			app.UseEndpoints(endpoints =>
			{
				endpoints.MapRazorPages();
			});
		}
	}
}
