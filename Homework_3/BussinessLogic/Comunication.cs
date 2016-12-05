using Homework_3.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework_3.BussinessLogic
{
    public class Comunication
    {
        private List<User> CurrentUsers;
        private List<Message> Messages;
        //private HttpSessionStateBase _Session;

        public Comunication()
        {
            CurrentUsers = new List<User>();
            Messages = new List<Message>();
            //_Session.Add("Users", CurrentUsers);
            //_Session.Add("Messages", Messages);
        }

        public void SendMessage(string msg, string sender, string receiver)
        {
            Messages.Add(new Message(msg, sender,receiver));
        }

        public List<User> GetAllUsers()
        {
            return CurrentUsers;
        }

        public Message GetMessage(string sender)
        {
            Message msg = null;
            for (int i = 0; i < Messages.Count; i++)
            {
                if (Messages[i].GetSenderReceiver()[1] == sender)
                {
                    msg = Messages[i];
                    Messages.RemoveAt(i);
                    break;
                }
            }
            return msg;
        }

        public void RegisterNewUser(string name)
        {
            CurrentUsers.Add(new User(name, new Random().Next()));
        }
    }
}