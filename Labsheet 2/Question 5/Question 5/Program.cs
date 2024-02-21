using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_5
{
    public class LibraryBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool Available { get; set; }

        public void BorrowBook()
        {
            if (Available)
            {
                Available = false;
                Console.WriteLine($"The book '{Title}' has been borrowed.");
            }
            else
            {
                Console.WriteLine($"The book '{Title}' is currently unavailable.");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            LibraryBook book1 = new LibraryBook { Title = "Book1", Author = "Author1", Available = true };
            LibraryBook book2 = new LibraryBook { Title = "Book2", Author = "Author2", Available = true };

            // Display initial status
            Console.WriteLine($"Initial status: Book1 - {(book1.Available ? "Available" : "Unavailable")}, Book2 - {(book2.Available ? "Available" : "Unavailable")}");

            // Borrow books
            book1.BorrowBook();
            book2.BorrowBook();

            // Display updated status
            Console.WriteLine($"Updated status: Book1 - {(book1.Available ? "Available" : "Unavailable")}, Book2 - {(book2.Available ? "Available" : "Unavailable")}");
            Console.ReadLine();
        }
    }
}
