using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector[] vectors = new Vector[10];
            Random random = new Random();
            Vector2D r2 = new Vector2D();
            Vector3D r3 = new Vector3D();
            for (int i = 0; i < vectors.Length; i++)
            {
                if (random.Next(2) == 0)
                {
                    vectors[i] = new Vector2D(random.Next(-4, 4)*1.0f, random.Next(-4, 4)*1.0f);
                }
                else
                {
                    vectors[i] = new Vector3D(random.Next(-4, 4) * 1.0f, random.Next(-4, 4) * 1.0f, random.Next(-4, 4) * 1.0f);
                }
                vectors[i].showinfo();
            }
            //Sum
            Console.WriteLine();
            for (int i = 0; i < vectors.Length - 1; i++)
            {
                for (int j = i + 1; j < vectors.Length; j++)
                {
                    vectors[i].sum(vectors[j], r2);
                    vectors[i].sum(vectors[j], r3);
                }
            }
            //Orth
            Console.WriteLine();
            for (int i = 0;i < vectors.Length-1;i++)
            {
                for (int j = i + 1; j < vectors.Length; j++)
                {
                    vectors[i].orth(vectors[j]);
                }
            }

            Console.ReadKey();
        }
    }
}
