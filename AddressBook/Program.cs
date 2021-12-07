using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            BookEntry bookEntry1 = new BookEntry("Quentin", "Sims", "076 955 3787");
            Console.WriteLine(bookEntry1.FirstName);
        }
    }
}
