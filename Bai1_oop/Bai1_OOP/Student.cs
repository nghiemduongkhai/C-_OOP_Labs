using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_oop
{
    public class Student
    {
        //Field
        private string name;
        private float gpa;
        //Property
        public string Name { get => name; set => name = value; }
        public float Gpa { get => gpa; set => gpa = value; }
        //Constructor
        public Student()
        {
            name = "None";
            gpa = 0.0f;
        }
        public Student(string name, float gpa)
        {
            this.name = name;
            this.gpa = gpa;
        }
        //Method
        public static void Sort(Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                for (int j = i+1; j < students.Length; j++)
                {
                    if (students[i].gpa <= students[j].gpa)
                    {
                        float temp = students[i].gpa;
                        students[i].gpa = students[j].gpa;
                        students[j].gpa = temp; 
                        string temp1 = students[i].name;
                        students[i].name = students[j].name;
                        students[j].name = temp1;
                    }
                }
            }
        }
        public static void PrintInfo(string name, float gpa)
        {               
            Console.Write($"| {name,-20}");
            Console.Write($"| {gpa,3:F1} |"); //Console.Write($"| {Gpa.ToString("F1"), 3} |");               
            Console.WriteLine();
        }
    }
}
