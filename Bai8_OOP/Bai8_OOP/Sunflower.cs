using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8_OOP
{
    public class Sunflower : Product
    {
        private int num_fertilizer;
        private int num_water;
        public Sunflower()
        {
            Cost = 300;
            Value = 1200;
            Duration = new TimeSpan(0, 0, 65);
            num_fertilizer = 0;
            num_water = 0;
        }
        public Sunflower(int num_fertilizer, int num_water)
        {
            this.num_fertilizer = num_fertilizer;
            this.num_water = num_water;
        }
        public override string seed()
        {
            Start = DateTime.Now;
            return $"Đã trồng Sunflower. ({Start}) {Duration}s";
        }
        public override int harvest()
        {
            if (DateTime.Now - Start >= Duration)
            {
                Console.WriteLine("Đã thu hoạch Sunflower.");
                return Value - (Fertilizer * num_fertilizer + Water * num_water + Cost);
            }
            else
            {
                Console.WriteLine($"Sunflower chưa chín, không thể thu hoạch. Còn {Duration - (DateTime.Now - Start)} giây... ");
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
                Console.WriteLine($"Đã bón phân cho Sunflower. ({num_fertilizer}/2)");
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
                Console.WriteLine($"Đã tưới nước cho Sunflower. ({num_water}/2)");
            }
            else
            {
                Console.WriteLine("Cây đã hết lượt tưới nước!");
            }
        }
    }
}
