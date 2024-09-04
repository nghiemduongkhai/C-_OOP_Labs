using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_OOP
{
    public class Circle2D : Point2D, ICircle
    {
        private float bkinh;
        public float Bkinh { get => bkinh; set => bkinh = value; }
        public Circle2D()
        {
            bkinh = 0f;
        }
        public Circle2D(Point2D point, float bkinh) : base(point.X, point.Y)
        {
            this.bkinh = bkinh;
        }
        public void showCircle()
        {
            Console.WriteLine($"Circle2D ({X},{Y}) radius = {bkinh}");
        }
        public float cal_area(ref float area)
        {
            return area = (float)(Math.PI * Math.Pow(bkinh, 2));
        }
        public void relPosition(Object other, float d)
        {
            if (other is Point2D p2)
            {
                if (d < this.bkinh)
                {
                    Console.WriteLine($"Điểm ({p2.X},{p2.Y}) trong đường tròn tâm ({X},{Y}) bán kính {bkinh}\n");
                }
                else if (d > this.bkinh)
                {
                    Console.WriteLine($"Điểm ({p2.X},{p2.Y}) ngoài đường tròn tâm ({X},{Y}) bán kính {bkinh}\n");
                }
                else
                {
                    Console.WriteLine($"Điểm ({p2.X},{p2.Y}) trên đường tròn tâm ({X},{Y}) bán kính {bkinh} \n");
                }
            }
        }
    }
}
