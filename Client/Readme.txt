**************************************************
Step (1)

Create a new project:

[ASP.NET Core Web App]
**************************************************

**************************************************
Step (2)

Clean [Program.cs]
**************************************************

**************************************************
Step (3)

Clean [Startup.cs] file
**************************************************

**************************************************
Step (4)

In [Pages] Folder -> In [Shared] Folder -> Update [_Layout.cshtml] file:

	@RenderSection("Scripts", required: false)
**************************************************

**************************************************
Step (5)

In [Pages] Folder -> Update [Index.cshtml] file:

	Adding TextBox and Button!

@section Scripts
{
	<!-- <snippet_CDN> -->
	<script src="https://cdnjs.cloudflare.com/ajax/libs/microsoft-signalr/5.0.7/signalr.min.js" integrity="sha512-oAPcE4NHy9W9BVJtctIMF0Ae2qSeNYwq976GWRQxiE3FhMvMYKlEOYkqbwzPKVFuoj8Z5zsPfasYZ8DwyU3rMg==" crossorigin="anonymous" referrerpolicy="no-referrer"></script>
	<!-- </snippet_CDN> -->

	<script src="~/js/chat.js"></script>
}
**************************************************

**************************************************
Step (6)

In wwwroot folder -> In [js] folder -> Create [chat.js] file
**************************************************
