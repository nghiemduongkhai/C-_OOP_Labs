using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_oop
{
    public class Vector
    {
        private float x;
        private float y;
        public float X { get => x; set => x = value; }
        public float Y { get => y; set => y = value; }
        public Vector()
        {
            x = 0.0f;
            y = 0.0f;
        }
        public Vector(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public static void printVector(float x, float y)
        {
            Console.WriteLine($"({x} ; {y})");
        }
        public static void add(Vector v1, Vector v2, Vector r)
        {
            r.x = v1.x + v2.x;
            r.y = v1.y + v2.y;
        }
        public static void sub(Vector v1, Vector v2, Vector r)
        {
            r.x = v1.x - v2.x;
            r.y = v1.y - v2.y;
        }
        public static float mul(Vector v1, Vector v2, ref float result)
        {
            return result = (v1.x * v2.x) + (v1.y * v2.y);
        }
        public static bool orth(Vector v1, Vector v2, ref float result)
        {
            if(Vector.mul(v1, v2, ref result) == 0.0f)
            {
                return true;
            }
            return false;
        }
    }
}
