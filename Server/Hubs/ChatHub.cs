using Microsoft.AspNetCore.SignalR;

namespace Server.Hubs
{
	public class ChatHub : Microsoft.AspNetCore.SignalR.Hub
	{
		public ChatHub() : base()
		{
		}

		public
			async
			System.Threading.Tasks.Task
			SendMessage(string fullName, string message)
		{
			// using Microsoft.AspNetCore.SignalR;
			await Clients.All.SendAsync("ReceiveMessage", fullName, message);
		}
	}
}
