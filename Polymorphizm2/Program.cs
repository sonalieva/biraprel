using System;

namespace Polymorphizm2
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            Console.WriteLine("Zehmet olmasa name ni daxil edin");
            string name = Console.ReadLine();
            Console.WriteLine("Zehmet olmasa genre ni daxil edin");
            string genre = Console.ReadLine();
            Console.WriteLine("Zehmet olmasa author u daxil edin");
            string author = Console.ReadLine();
            Console.WriteLine("Zehmet olmasa price ni daxil edin");
            double price = Convert.ToDouble(Console.ReadLine());

            Book book = new Book();
            book.Name = name;
            book.Price = price;
            book.Genre = genre;
            book.Author = author;
            library.AddProduct(book);
            foreach(var item in library.GetProductByName("smth"))
            {
                item.GetInfo();
            }
            foreach(var item in library.GetProductsByPrice(67,78))
            {
                item.GetInfo();
            }
        }
    }
}
