using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_OOP
{
    public class Vector2D : Vector
    {
        private float x;
        private float y;
        public float X { get => x; set => x = value; }
        public float Y { get => y; set => y = value; }
        public Vector2D()
        {
            x = 0f;
            y = 0f;
        }
        public Vector2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public override void showinfo()
        {
            Console.WriteLine($"Vector2D: ({x}, {y})");
        }
        public override void sum(Vector other, Vector result)
        {
            if (other is Vector2D v2 && result is Vector2D r2)
            {
                r2.x = x + v2.x;
                r2.y = y + v2.y;
                Console.WriteLine($"Sum 2D: ({r2.x}, {r2.y})");
            }
        }
        public override void orth(Vector other)
        {
            if (other is Vector2D v2)
            {
                if ((x * v2.x + y * v2.y) == 0)
                {
                    Console.WriteLine($"Orth 2D: ({x}, {y}) ; ({v2.x}, {v2.y})");
                }
                else
                {
                    Console.WriteLine("Khong co cap truc giao 2D");
                }
            }
        }
    }
}
