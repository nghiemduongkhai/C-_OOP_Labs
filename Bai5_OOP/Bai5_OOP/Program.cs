using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            IPoint[] points = new IPoint[5];
            ICircle[] circles = new ICircle[5];
            Random random = new Random();
            for (int i = 0; i < points.Length; i++)
            {
                if (random.Next(2) == 0)
                {
                    points[i] = new Point2D(random.Next(-5, 5) * 1.0f, random.Next(-5, 5) * 1.0f);
                    Point2D point2 = (Point2D)points[i];
                    circles[i] = new Circle2D(point2, random.Next(1, 10) * 1.0f);
                }
                else
                {
                    points[i] = new Point3D(random.Next(-5, 5) * 1.0f, random.Next(-5, 5) * 1.0f, random.Next(-5, 5) * 1.0f);
                    Point3D point3 = (Point3D)points[i];
                    circles[i] = new Circle3D(point3, random.Next(1, 10) * 1.0f);
                }
                points[i].showinfo();
                circles[i].showCircle();
                Console.WriteLine();
            }
            //
            float dist = 0.0f;
            for (int i = 0;i < points.Length - 1;i++)
            {
                for (int j = i + 1;j < points.Length;j++)
                {
                    points[i].cal_dist(points[j], ref dist);
                    circles[i].relPosition(points[j], dist);
                }
            }
            Console.WriteLine();
            //
            float area = 0.0f;
            for (int i = 0; i < circles.Length; i++)
            {
                if (circles[i] is Circle2D c2)
                {
                    c2.cal_area(ref area);
                    c2.showCircle();
                    Console.WriteLine($"Area: {area}");
                }
                else if (circles[i] is Circle3D c3) 
                {
                    c3.cal_area(ref area);
                    c3.showCircle();
                    Console.WriteLine($"Area: {area}");
                }
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
