using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR
{
    [HubName("TestHub")]
    public class TestHub : Hub
    {
        public void DetermineLength(string message)
        {
            Console.WriteLine(message.Length);

            Clients.All.ReceiveLength(message.Length);
        }
    }
}
