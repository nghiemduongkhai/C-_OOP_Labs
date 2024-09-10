using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6_OOP
{
    internal class Program
    {
        public static void PrintBooks(List<Book> bks)
        {
            foreach (Book book in bks)
                Console.WriteLine(book);
        }
        public static void PrintUsers(List<User> urs)
        {
            foreach (User user in urs)
                Console.WriteLine(user);
        }
        static void Main(string[] args)
        {
            Console.Clear();

            Library lib = new Library();
            lib.addBook(new Book("B01", "Lap trinh HDT", "Nguyen Van At", new DateTime(2023, 12, 20), "NXB DHQG HN", 240, 210000, 23));
            lib.addBook(new Book("B02", "Ly thuyet do thi", "Nguyen Van Mau", new DateTime(2022, 10, 12), "NXB DHBK HN", 250, 230000, 25));
            lib.addBook(new Book("B03", "Tri tue nhan tao", "Nguyen Van Lam", new DateTime(2022, 4, 19), "NXB DHBK HCM", 255, 250000, 1));
            PrintBooks(lib.Books);
            Console.WriteLine(); //
            lib.addUser(new User("U01", "Nguyen Van A"));
            lib.addUser(new User("U02", "Tran Van B"));
            lib.addUser(new User("U03", "Duong Van C"));
            PrintUsers(lib.Users);
            Console.WriteLine();//
            lib.checkAvailability();
            Console.WriteLine(); // Muon
            for (int i = 0; i < lib.Books.Count; i++)
            {
                lib.borrowBook(lib.Books[i], lib.Users[i]);
            }
            Console.WriteLine();
            lib.checkAvailability();
            Console.WriteLine(); // Tra
            for (int i = 0; i < lib.Books.Count; i++)
            {
                lib.returnBook(lib.Books[i], lib.Users[i]);
            }
            Console.WriteLine();
            lib.checkAvailability();
            Console.ReadKey();
        }
    }
}
