using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8_OOP
{
    public class Player
    {
        private string username;
        private int reward;
        public string Username { get => username; set => username = value; }
        public int Reward { get => reward; set => reward = value; }

        public Player(string username) 
        {
            this.username = username;
            reward = 2000;
        }
        public bool Login(string username) 
        {
            return Username == username;
        }
    }
}
