using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Book> library = new List<Book>();

        library.Add(new Book("1984", "George Orwell", "1"));
        library.Add(new Book("The Hobbit", "J.R.R. Tolkien", "2"));
        library.Add(new Book("Clean Code", "Robert Martin", "3"));
        library.Add(new Book("Harry Potter", "J.K. Rowling", "4"));
        library.Add(new Book("The Alchemist", "Paulo Coelho", "5"));

        while (true)
        {
            Console.WriteLine("\n--- Library Menu ---");
            Console.WriteLine("1. Kitablari goster");
            Console.WriteLine("2. Kitab goturmek");
            Console.WriteLine("3. Kitab qaytar");
            Console.WriteLine("4. Cixis");

            Console.Write("Seçiminiz: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                foreach (Book book in library)
                {
                    book.ShowInfo();
                }
            }
            else if (choice == 2)
            {
                Console.Write("Goturmek istediyiniz kitabin nomresi: ");
                int bookNumber = Convert.ToInt32(Console.ReadLine());

                library[bookNumber - 1].BorrowBook();
            }
            else if (choice == 3)
            {
                Console.Write("Qaytarmaq istediyiniz kitabin nomresi: ");
                int bookNumber = Convert.ToInt32(Console.ReadLine());

                library[bookNumber - 1].ReturnBook();
            }
            else if (choice == 4)
            {
                Console.WriteLine("Proqram bitdi");
                break;
            }
            else
            {
                Console.WriteLine("Yanlis secim");
            }
        }
    }
}