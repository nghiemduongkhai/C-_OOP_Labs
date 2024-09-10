using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6_OOP
{
    public class User
    {
        private string userId;
        private string username;
        public string UserId { get => userId; set => userId = value; }
        public string Username { get => username; set => username = value; }
        public User(string userId, string username)
        {
            this.userId = userId;
            this.username = username;
        }
        public override string ToString()
        {
            return "User("+ UserId+ ", "+ Username +")";
        }
    }
}
