using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vector> vectors = new List<Vector>();
            for (int i = 0; i < 10; i++)
            {
                vectors.Add(new Vector(i, i * 2));
            }
            /*foreach (Vector v in vectors)
            {
                Vector.printVector(v.X, v.Y);
            }*/
            //for (int i = 0; i < vectors.Count; i++)
            //{
            //    Console.Write($"Vector {i}: ");
            //    Vector.printVector(vectors[i].X, vectors[i].Y);
            //}
            //Console.WriteLine();
            Vector result = new Vector();
            //Add
            for (int i = 0; i < vectors.Count - 1; i += 2)
            {
                Vector.add(vectors[i], vectors[i + 1], result);
                Console.Write($"Vector {i} + Vector {i + 1} : ");
                Vector.printVector(result.X, result.Y);
            }
            Console.WriteLine();
            //Sub
            for (int i = 0; i < vectors.Count - 1; i += 2)
            {
                Vector.sub(vectors[i], vectors[i + 1], result);
                Console.Write($"Vector {i} - Vector {i + 1} : ");
                Vector.printVector(result.X, result.Y);
            }
            Console.WriteLine();
            //Mul
            float resultMul = 0.0f;
            for (int i = 0; i < vectors.Count - 1; i += 2)
            {
                Vector.mul(vectors[i], vectors[i + 1], ref resultMul);
                Console.Write($"Vector {i} * Vector {i + 1} = ");
                Console.WriteLine(resultMul);
            }
            Console.WriteLine();
            //Orth
            Console.WriteLine("Orthogonal Vectors");
            for (int i = 0; i < vectors.Count; i++)
            {
                for (int j = i + 1; j < vectors.Count; j++)
                {
                    if (Vector.orth(vectors[i], vectors[j], ref resultMul) == true)
                    {
                        Console.Write($"Vector {i}: ");
                        Vector.printVector(vectors[i].X, vectors[i].Y);
                        Console.Write($"Vector {j}: ");
                        Vector.printVector(vectors[j].X, vectors[j].Y);
                        Console.WriteLine();
                    }
                }
            }
            //
            Console.ReadKey();
        }
    }
}
