using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework_3.Classes
{
    public class User
    {
        private string Name;
        private int ID;

        public User(string name, int id)
        {
            Name = name;
            ID = id;
        }

        public string GetName()
        {
            return Name;
        }

        public int GetID()
        {
            return ID;
        }
    }
}