using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Channels;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;

namespace SignalRClientExample
{
    class Program
    {
        // username and password of user with operator permissions
        private const string Username = "admin";
        private const string Password = "admin";

        static async Task Main(string[] args)
        {
            // serviceUrl is the URL of the CredoID server
            var serviceUrl = "https://demo.credoid.com";

            var httpClient = new HttpClient();

            // login to CredoID server
            var content = JsonContent.Create(new
            {
                username = Username,
                password = Password
            });

            var response = await httpClient.PostAsync($"{serviceUrl}/api/login", content);
            var responseContent = await response.Content.ReadFromJsonAsync<LoginResponse>();

            // create SignalR connection
            var connection = new HubConnectionBuilder()
                .WithUrl($"{serviceUrl}/event-stream",
                    options => { options.AccessTokenProvider = () => Task.FromResult(responseContent.Token); })
                .Build();

            try
            {
                // pass filter Id if you want get events by filter, otherwise pass null to get all events
                // note: available events will vary depending on operator permissions
                int? filterId = null;

                await connection.StartAsync();

                ChannelReader<Event> channel = await connection.StreamAsChannelAsync<Event>(
                    "GetStream", filterId);

                // wait asynchronously for data to become available
                while (await channel.WaitToReadAsync())
                {
                    // read all currently available data synchronously, before waiting for more data
                    while (channel.TryRead(out var received))
                    {
                        Console.WriteLine($"Received event: {received.LocalizedTypeName}");
                    }
                }

                await connection.StopAsync();

                Console.WriteLine("Streaming completed");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }
    }
}