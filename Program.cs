using WinFormsApp1.Classes;

namespace OOP_2_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArmWritedBook book = new ArmWritedBook();
            Bookcase bookcase = new Bookcase('a', 1);
            Book book1 = new Book();
            bookcase._books.Add(book);
            bookcase._books.Add(book1);
            foreach (var item in bookcase._books)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}