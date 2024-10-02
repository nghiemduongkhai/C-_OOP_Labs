using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Bai10_OOP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            StudentList studentList;
            if (File.Exists("data.dat"))
            {
                string json_ = File.ReadAllText("data.dat");
                studentList = JsonSerializer.Deserialize<StudentList>(json_);
                Console.WriteLine("\nĐọc dữ liệu từ file data.dat:");
                Console.WriteLine(json_);
            }
            else
            {
                studentList = new StudentList();
                studentList.Add(new Student { Id = 1, Name = "Nam", Age = 20 });
                studentList.Add(new Student { Id = 2, Name = "Binh", Age = 21 });
                studentList.Add(new Student { Id = 3, Name = "Minh", Age = 22 });

                string json = JsonSerializer.Serialize(studentList, new JsonSerializerOptions { WriteIndented = true });
                StudentList deserializedStudentList = JsonSerializer.Deserialize<StudentList>(json);
                Console.WriteLine("\nDeserialized Students:");
                foreach (Student student in deserializedStudentList.Students)
                {
                    Console.WriteLine(student);
                }

                File.WriteAllText("data.dat", json);
                Console.WriteLine("\nDữ liệu đã được ghi vào file data.dat");

                string newjson = File.ReadAllText("data.dat");
                Console.WriteLine("\nĐọc dữ liệu file data.dat");

                StudentList stlist = JsonSerializer.Deserialize<StudentList>(newjson);
                stlist.Add(new Student { Id = 4, Name = "Anh", Age = 23 });
                stlist.Add(new Student { Id = 5, Name = "Sang", Age = 24 });

                string updatedjson = JsonSerializer.Serialize(stlist, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText("data.dat", updatedjson);
                Console.WriteLine("\nDữ liệu mới đã được ghi vào file data.dat");

                string newupdatedjson = File.ReadAllText("data.dat");
                Console.WriteLine("\nĐọc dữ liệu file data.dat mới");
                Console.WriteLine(newupdatedjson);
            }
            //--Khi cần cập nhật thêm vào dữ liệu mới--
            //string newjson = File.ReadAllText("data.dat");
            //Console.WriteLine("\nĐọc dữ liệu file data.dat");

            //StudentList stlist = JsonSerializer.Deserialize<StudentList>(newjson);
            //stlist.Add(new Student { Id = 4, Name = "Anh", Age = 23 });
            //stlist.Add(new Student { Id = 5, Name = "Sang", Age = 24 });

            //string updatedjson = JsonSerializer.Serialize(stlist, new JsonSerializerOptions { WriteIndented = true });
            //File.WriteAllText("data.dat", updatedjson);
            //Console.WriteLine("\nDữ liệu mới đã được ghi vào file data.dat");

            //string newupdatedjson = File.ReadAllText("data.dat");
            //Console.WriteLine("\nĐọc dữ liệu file data.dat mới");
            //Console.WriteLine(newupdatedjson);

            Console.ReadKey();
        }
    }
}
