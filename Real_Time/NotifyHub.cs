using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Real_Time
{
    public class NotifyHub:Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
            //await Clients.All.SendAsync("ReceiveMessage1", user, message);
        }
        public async Task SendMessage1(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage1", user, message);
            //await Clients.All.SendAsync("ReceiveMessage1", user, message);
        }
    }
}
