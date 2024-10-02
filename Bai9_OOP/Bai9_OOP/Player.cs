using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Bai9_OOP
{
    [Serializable]
    public class Player : ISerializable
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
        public void GetObjectData(SerializationInfo info, StreamingContext context) 
        { 
            info.AddValue("username", username);
            info.AddValue("reward", reward);
        }
        public Player(SerializationInfo info, StreamingContext context) 
        { 
            Username = info.GetString("username");
            Reward = info.GetInt32("reward");
        }
    }

}
