using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_OOP
{
    public class Point2D : IPoint
    { 
        private float x;
        private float y;
        public float X { get => x; set => x = value; }
        public float Y { get => y; set => y = value; }
        public Point2D()
        {
            x = 0.0f;
            y = 0.0f;
        }
        public Point2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public void showinfo()
        {
            Console.WriteLine($"Point2D: ({x},{y})");
        }
        public void cal_dist(Object other, ref float dist)
        {
            if (other is Point2D p)
            {
                dist = (float)Math.Sqrt(Math.Pow(p.x - x, 2) + Math.Pow(p.y - y, 2));
                if (dist != 0)
                {
                    Console.WriteLine($"({x},{y}) ({p.x},{p.y}) Dist: {dist}");
                }
                else
                {
                    Console.WriteLine($"({x},{y}) ({p.x},{p.y}) Trùng nhau");
                }
            }
        }
    }
}
