using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9_OOP
{
    public class Wheat : Product
    {
        private int num_fertilizer;
        private int num_water;
        private int num_harvest;
        public Wheat()
        {
            Cost = 500;
            Value = 1600;
            Duration = new TimeSpan(0, 0, 75);
            num_fertilizer = 0;
            num_water = 0;
            num_harvest = 0;
        }
        public Wheat(int num_fertilizer, int num_water)
        {
            this.num_fertilizer = num_fertilizer;
            this.num_water = num_water;
        }
        public override string seed()
        {
            Start = DateTime.Now;
            return $"Đã trồng Wheat. ({Start}) {Duration}s";
        }
        public override int harvest()
        {
            if (DateTime.Now - Start >= Duration && num_harvest == 0)
            {
                num_harvest++;
                Console.WriteLine("Đã thu hoạch Wheat.");
                return Value - (Fertilizer * num_fertilizer + Water * num_water + Cost);
            }
            else if (DateTime.Now - Start >= Duration && num_harvest > 0)
            {
                Console.WriteLine("Bạn đã thu hoạch Wheat này rồi!!");
                return 0;
            }
            else
            {
                Console.WriteLine($"Wheat chưa chín, không thể thu hoạch. Còn {Duration - (DateTime.Now - Start)} giây... ");
                return 0;
            }
        }
        public void feed()
        {
            if (num_fertilizer < 2)
            {
                num_fertilizer++;
                TimeSpan timeFer = new TimeSpan(0, 0, 20);
                Duration -= timeFer;
                Console.WriteLine($"Đã bón phân cho Wheat. ({num_fertilizer}/2)");
            }
            else
            {
                Console.WriteLine("Cây đã hết lượt bón phân!");
            }
        }
        public void prov_water()
        {
            if (num_water < 3)
            {
                num_water++;
                TimeSpan timeWat = new TimeSpan(0, 0, 10);
                Duration -= timeWat;
                Console.WriteLine($"Đã tưới nước cho Wheat. ({num_water}/3)");
            }
            else
            {
                Console.WriteLine("Cây đã hết lượt tưới nước!");
            }
        }
    }
}
