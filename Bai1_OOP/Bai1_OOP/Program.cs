using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bai1_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[10];
            students[0] = new Student("Nguyen An", 3.2f);
            students[1] = new Student("Tran Ba", 3.8f);
            students[2] = new Student("Nguyen Thu", 3.4f);
            students[3] = new Student("Ha Trung", 3.3f);
            students[4] = new Student("Van Vu", 3.0f);
            students[5] = new Student("Thu Tho", 3.6f); 
            students[6] = new Student("Duong Ta", 3.9f);
            students[7] = new Student("Bao Ban", 3.1f); 
            students[8] = new Student("Pham Bao", 2.9f);
            students[9] = new Student("Nguy Gia", 3.5f);
            Student.Sort(students);
            Console.WriteLine("+---+---------------------+-----+");
            Console.WriteLine($"|{"STT",3}| {"HoTen",-20}| {"GPA",3} |");
            Console.WriteLine("+---+---------------------+-----+");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"|{i+1, 3}");
                Student.PrintInfo(students[i].Name, students[i].Gpa);
            }
            Console.WriteLine("+---+---------------------+-----+");

            Console.ReadKey();
        }
    }
}
