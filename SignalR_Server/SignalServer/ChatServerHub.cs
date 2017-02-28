using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SignalR_Server.SignalServer
{
    [HubName("ChatHub")]
    public class ChatServerHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }

        public void SendMessage(string message)
        {
            Clients.All.ReceiveMessage(message);
        }
    }
}