using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Bai9_OOP
{
    [Serializable]
    public abstract class Product : ISerializable
    {
        private int cost;
        private int value;
        private DateTime start;
        private TimeSpan duration;
        private int fertilizer = 200;
        private int water = 100;
        public int Cost { get => cost; set => cost = value; }
        public int Value { get => value; set => this.value = value; }
        public DateTime Start { get => start; set => start = value; }
        public TimeSpan Duration { get => duration; set => duration = value; }
        public int Fertilizer { get => fertilizer; set => fertilizer = value; }
        public int Water { get => water; set => water = value; }
        public abstract string seed();
        public abstract int harvest();
        public Product() { }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("cost", cost);
            info.AddValue("value", value);
            info.AddValue("start", start);
            info.AddValue("duration", duration);
            info.AddValue("fertilizer", fertilizer);
            info.AddValue("water", water);
        }
        public Product(SerializationInfo info, StreamingContext context) 
        {
            Cost = info.GetInt32("cost");
            Value = info.GetInt32("value");
            Start = info.GetDateTime("start");
            Duration = (TimeSpan)info.GetValue("duration", typeof(TimeSpan)); ;
            Fertilizer = info.GetInt32("Fertilizer");
            Water = info.GetInt32("water");
        }
    }
}
