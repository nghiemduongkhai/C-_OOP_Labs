using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_OOP
{
    public class Student : Human
    {
        private string id;
        private float gpa;
        public string Id { get => id; set => id = value; }
        public float Gpa { get => gpa; set => gpa = value; }
        public Student()
        {
            id = "None";
            gpa = 0.0f;
        }
        public Student(string name,string place_of_birth,DateTime birthday,string id, float gpa) : base(name, place_of_birth, birthday)
        {
            this.id = id;
            this.gpa = gpa;
        }
        public static void Sort(Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                for (int j = i + 1; j < students.Length; j++)
                {
                    if (students[i].gpa <= students[j].gpa)
                    {
                        Student temp = students[i];
                        students[i] = students[j];
                        students[j] = temp;
                    }
                }
            }
        }
        public static void PrintInf(string name, string place_of_birth, DateTime birthday, string id, float gpa)
        {
            Console.Write($"| {name,-5}| {place_of_birth, -13}| {birthday.ToShortDateString(),-10}| {id,3}| {gpa,3:F1}|"); 
            //Console.Write($"| {Gpa.ToString("F1"), 3} |");               
            Console.WriteLine();
        }
    }
}
