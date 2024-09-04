using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];
            students[0] = new Student("Anh", "Tp HCM", new DateTime(2005, 3, 10), "123", 3.2f);
            students[1] = new Student("Ban", "Tp HCM", new DateTime(2005, 4, 30), "124", 3.8f);
            students[2] = new Student("Nam", "Tp HCM", new DateTime(2005, 9, 2), "125", 3.3f);
            students[3] = new Student("Men", "Tp HCM", new DateTime(2005, 8, 20), "126", 3.1f);
            students[4] = new Student("Van", "Tp HCM", new DateTime(2005, 11, 15), "127", 3.5f);
            Student.Sort(students);
            Console.WriteLine($"|{"STT",-3}| {"Name",-5}| {"PlaceOfBirth",-13}| {"Birthday",-10}| {"ID",-3}| {"GPA",-3}|");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"|{i + 1,3}");
                Student.PrintInf(students[i].Name, students[i].Place_of_birth, students[i].Birthday, students[i].Id, students[i].Gpa);
            }
            Console.ReadKey();
        }
    }
}
