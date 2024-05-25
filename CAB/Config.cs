using System;
using System.Net.Http;
using SocketIOClient;
using SocketClient = SocketIOClient.SocketIO;

namespace CAB
{
    internal class Config
    {
        public static SocketClient Socket { get; private set; }
        public static HttpClient HttpClient { get; private set; }
        public static string Host { get; private set; }

        static Config()
        {
            var host = "http://localhost:3000";

            var httpClient = new HttpClient
            {
                BaseAddress = new Uri(host),
                Timeout = TimeSpan.FromSeconds(10),
                DefaultRequestHeaders = { { "User-Agent", "CABClient" } }
            };
            var socket = new SocketClient(host, new SocketIOOptions
            {
                Reconnection = false
            });

            /*
            * bind variables
            */

            HttpClient = httpClient;
            Socket = socket;
            Host = host;
        }
    }
}
