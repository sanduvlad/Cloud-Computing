using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework_3.Classes
{
    public class Message
    {
        private string _msg;
        private string sender_Name;
        private string receiver_Name;

        public Message(string msg, string s, string r)
        {
            _msg = msg;
            sender_Name = s;
            receiver_Name = r;
        }

        public string GetMesage()
        {
            return _msg;
        }

        public List<string> GetSenderReceiver()
        {
            return new List<string>() { sender_Name, receiver_Name };
        }
    }
}