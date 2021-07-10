namespace Client.Pages
{
	[Microsoft.AspNetCore.Mvc.ResponseCache
		(Duration = 0, Location = Microsoft.AspNetCore.Mvc.ResponseCacheLocation.None, NoStore = true)]
	[Microsoft.AspNetCore.Mvc.IgnoreAntiforgeryToken]
	public class ErrorModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
	{
		public ErrorModel(Microsoft.Extensions.Logging.ILogger<ErrorModel> logger)
		{
			Logger = logger;
		}

		public string RequestId { get; set; }

		public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

		private Microsoft.Extensions.Logging.ILogger<ErrorModel> Logger { get; }

		public void OnGet()
		{
			RequestId =
				System.Diagnostics.Activity.Current?.Id ?? HttpContext.TraceIdentifier;
		}
	}
}
