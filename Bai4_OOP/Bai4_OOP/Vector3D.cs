using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_OOP
{
    public class Vector3D : Vector
    {
        private float x;
        private float y;
        private float z;
        public float X { get => x; set => x = value; }
        public float Y { get => y; set => y = value; }
        public float Z { get => z; set => z = value; }
        public Vector3D()
        {
            x = 0f;
            y = 0f;
            z = 0f;
        }
        public Vector3D(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public override void showinfo()
        {
            Console.WriteLine($"Vector3D: ({x}, {y}, {z})");
        }
        public override void sum(Vector other, Vector result)
        {
            if (other is Vector3D v3 && result is Vector3D r3)
            {
                r3.x = x + v3.x;
                r3.y = y + v3.y;
                r3.z = z + v3.z;
                Console.WriteLine($"Sum 3D: ({r3.x}, {r3.y}, {r3.z})");
            }
        }
        public override void orth(Vector other)
        {
            if (other is Vector3D v3)
            {
                if ((x * v3.x + y * v3.y + z * v3.z) == 0)
                {
                    Console.WriteLine($"Orth 3D: ({x}, {y}, {z}) ; ({v3.x}, {v3.y}, {v3.z})");
                }
                else
                {
                    Console.WriteLine("Khong co cap truc giao 3D");
                }
            }
        }
    }
}
