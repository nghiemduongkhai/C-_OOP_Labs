using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9_OOP
{
    public class Tomato : Product
    {
        private int num_fertilizer;
        private int num_water;
        private int num_harvest;
        public Tomato()
        {
            Cost = 200;
            Value = 900;
            Duration = new TimeSpan(0, 0, 45);
            num_fertilizer = 0;
            num_water = 0;
            num_harvest = 0;
        }
        public Tomato(int num_fertilizer, int num_water)
        {
            this.num_fertilizer = num_fertilizer;
            this.num_water = num_water;
        }
        public override string seed()
        {
            Start = DateTime.Now;
            return $"Đã trồng Tomato. ({Start}) {Duration}s";
        }
        public override int harvest()
        {
            if (DateTime.Now - Start >= Duration && num_harvest == 0)
            {
                num_harvest++;
                Console.WriteLine("Đã thu hoạch Tomato.");
                return Value - (Fertilizer * num_fertilizer + Water * num_water + Cost);
            }
            else if (DateTime.Now - Start >= Duration && num_harvest > 0)
            {
                Console.WriteLine("Bạn đã thu hoạch Tomato này rồi!!");
                return 0;
            }
            else
            {
                Console.WriteLine($"Tomato chưa chín, không thể thu hoạch. Còn {Duration - (DateTime.Now - Start)} giây... ");
                return 0;
            }
        }
        public void feed()
        {
            if (num_fertilizer < 1)
            {
                num_fertilizer++;
                TimeSpan timeFer = new TimeSpan(0, 0, 20);
                Duration -= timeFer;
                Console.WriteLine($"Đã bón phân cho Tomato.({num_fertilizer}/1)");
            }
            else
            {
                Console.WriteLine("Cây đã hết lượt bón phân!");
            }
        }
        public void prov_water()
        {
            if (num_water < 2)
            {
                num_water++;
                TimeSpan timeWat = new TimeSpan(0, 0, 10);
                Duration -= timeWat;
                Console.WriteLine($"Đã tưới nước cho Tomato.({num_water}/2)");
            }
            else
            {
                Console.WriteLine("Cây đã hết lượt tưới nước!");
            }
        }
    }
}
