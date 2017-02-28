using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignalR_Client
{
    public partial class Form1 : Form
    {
        IHubProxy _hub;
        public Form1()
        {
            InitializeComponent();

            string url = @"http://vlad-pc.code40.local/chat_server/";
            var connection = new HubConnection(url);
            _hub = connection.CreateHubProxy("ChatHub");
            connection.Start().Wait();

            _hub.On("ReceiveMessage", x => Console.WriteLine(x));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _hub.Invoke("SendMessage", textBox1.Text).Wait();

            textBox1.Text = string.Empty;
        }
    }
}
