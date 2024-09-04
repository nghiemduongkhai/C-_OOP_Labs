using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_OOP
{
    public class Point3D : IPoint
    {
        private float x;
        private float y;
        private float z;
        public float X { get => x; set => x = value; }
        public float Y { get => y; set => y = value; }
        public float Z { get => z; set => z = value; }
        public Point3D()
        {
            x = 0f;
            y = 0f;
            z = 0f;
        }
        public Point3D(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public void showinfo()
        {
            Console.WriteLine($"Point3D: ({x},{y},{z})");
        }
        public void cal_dist(Object other, ref float dist)
        {
            if (other is Point3D p)
            {
                dist = (float)Math.Sqrt(Math.Pow(p.x - x, 2) + Math.Pow(p.y - y, 2) + Math.Pow(p.z - z, 2));
                if (dist != 0)
                {
                    Console.WriteLine($"({x},{y},{z}) ({p.x},{p.y},{p.z}) Dist: {dist}");
                }
                else
                {
                    Console.WriteLine($"({x},{y},{z}) ({p.x},{p.y},{p.z}) Trùng nhau");
                }
            }
        }
    }
}
