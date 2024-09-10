using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6_OOP
{
    public class Library
    {
        private List<Book> books = new List<Book>();
        private List<User> users = new List<User>();
        private List<Book> borrowedBooks = new List<Book>();
        public List<Book> Books { get => books; set => books = value; }
        public List<User> Users { get => users; set => users = value; }
        public Library() 
        {
            Books = books;
            Users = users;
        }
        public void addBook(Book book)
        {
            books.Add(book);
        }
        public void addUser(User user)
        {
            users.Add(user);
        }
        public List<Book> find(string keyword)
        {
            List<Book> result = new List<Book>();
            foreach (Book b in books)
                if (b.find(keyword))
                    result.Add(b);
            return result;
        }
        public void checkAvailability()
        {
            foreach (Book b in books)
            {
                if (b.Quantity > 0)
                {
                    Console.WriteLine($"Check: {b.Id}, {b.Title}, con lai {b.Quantity} sach");
                }
                else
                {
                    Console.WriteLine($"Check: {b.Id}, {b.Title}, da het sach");
                }
            }
        }     
        public void borrowBook(Book book, User user)
        {
            if (book.Quantity > 0)
            {
                borrowedBooks.Add(book);
                book.Quantity--;
                Console.WriteLine($"Borrow: {user.UserId}, {user.Username} da muon sach {book.Id}, {book.Title}");
            }
            else
            {
                Console.WriteLine($"!! Sach {user.UserId}, {user.Username} muon da het !!");
            }
        }
        public void returnBook(Book book, User user)
        {
            if (borrowedBooks.Contains(book))
            {
                borrowedBooks.Remove(book);
                book.Quantity++;
                Console.WriteLine($"Return: {user.UserId}, {user.Username} da tra sach {book.Id}, {book.Title}");
            }
            else
            {
                Console.WriteLine($"!! {user.UserId}, {user.Username} khong muon sach {book.Id}, {book.Title} !!");
            }
        }
    }
}
