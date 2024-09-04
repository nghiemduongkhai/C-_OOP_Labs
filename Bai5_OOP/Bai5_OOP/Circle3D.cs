using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_OOP
{
    public class Circle3D : Point3D , ICircle
    {
        private float bkinh;
        public float Bkinh { get => bkinh; set => bkinh = value; }
        public Circle3D() 
        { 
            bkinh = 0f;
        }
        public Circle3D(Point3D point, float bkinh) : base(point.X, point.Y, point.Z)
        {
            this.bkinh = bkinh;
        }
        public void showCircle()
        {
            Console.WriteLine($"Circle3D ({X},{Y},{Z}) radius = {bkinh}");
        }
        public float cal_area(ref float area)
        {
            return area = (float)(4 * Math.PI * Math.Pow(bkinh, 2));
        }
        public void relPosition(Object other, float d)
        {
            if (other is Point3D p3)
            {
                if (d < bkinh)
                {
                    Console.WriteLine($"Điểm ({p3.X},{p3.Y},{p3.Z}) trong đường tròn tâm ({X},{Y},{Z}) bán kính {bkinh}\n");
                }
                else if (d > bkinh)
                {
                    Console.WriteLine($"Điểm ({p3.X},{p3.Y},{p3.Z}) ngoài đường tròn tâm ({X},{Y},{Z}) bán kính {bkinh}\n");
                }
                else
                {
                    Console.WriteLine($"Điểm ({p3.X},{p3.Y},{p3.Z}) trên đường tròn tâm ({X},{Y},{Z}) bán kính {bkinh}\n");
                }
            }
        }
    }
}
