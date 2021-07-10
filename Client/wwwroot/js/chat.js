// Below code is similar to Document Ready in jQuery:

document.addEventListener("DOMContentLoaded", () => {

	// <snippet_Connection>
	const connection =
		new signalR.HubConnectionBuilder()
			.withUrl("https://localhost:44395/chathub")
			.configureLogging(signalR.LogLevel.Information)
			.build();
	// </snippet_Connection>

	document.getElementById("send").addEventListener("click", async () => {

		const fullName =
			document.getElementById("fullName").value;

		const message =
			document.getElementById("message").value;

		// <snippet_Invoke>
		try {

			await connection.invoke("SendMessage", fullName, message);

		} catch (err) {

			console.error(err);

		}
		// </snippet_Invoke>

	});

	async function start() {

		try {

			await connection.start();
			console.log("SignalR Connected.");

		} catch (err) {

			console.log(err);
			setTimeout(start, 5000);

		}

	};

	// <snippet_ReceiveMessage>
	connection.on("ReceiveMessage", (fullName, message) => {

		const li =
			document.createElement("li");

		//li.textContent =
		//	`<b>${fullName}:</b> ${message}`;

		li.innerHTML =
			`<b>${fullName}:</b> ${message}`;

		document.getElementById("messageList").appendChild(li);

	});
	// </snippet_ReceiveMessage>


	connection.onclose(function (error) {

		if (error) {

			console.log(`Connection closed with error: ${error}`);

		}
		else {

			console.log("Connection closed.");

		}

	});

	// Start the connection.
	start();

});
