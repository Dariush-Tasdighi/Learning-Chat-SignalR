**************************************************
Step (1)

Create a new project:

[ASP.NET Core Empty]
**************************************************

**************************************************
Step (2)

Clean [Program.cs]
**************************************************

**************************************************
Step (3)

Clean [Startup.cs]
**************************************************

**************************************************
Step (4)

Create a folder: [Hubs]
**************************************************

**************************************************
Step (5)

In [Hubs] Folder, Create a class: [ChatHub.cs]
**************************************************

**************************************************
Step (6)

Update class: [Startup.cs]

Startup:

	public const string MyAllowSpecificOrigins = "MyAllowSpecificOrigins";

	ConfigureServices:

		services.AddSignalR();

		services.AddCors(options =>
		{
			options.AddPolicy(name: MyAllowSpecificOrigins,
				builder =>
				{
					builder
						.WithOrigins("https://localhost:44356")
						.AllowAnyHeader()
						.AllowAnyMethod()
						.AllowCredentials() // In SignalR is important!
						;
				});
		});

	Configure:

		app.UseCors(policyName: MyAllowSpecificOrigins);

		app.UseEndpoints(endpoints =>
		{
			endpoints.MapHub<Hubs.ChatHub>("/chathub");
		});
**************************************************
