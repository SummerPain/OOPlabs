using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3oop
{
    public class Program
    {
        public static void Main()
        {
            //аноним
            Anonimous();
            //out example
            int testnum;
            Book.outexample(out testnum);
            Console.WriteLine("out example = " + testnum);
            //objs
            object[] books = new object[] {
                new Book("b1", "a1", "p1", 2020, 400, 39.99f, "bb1"),
                new Book("b2", "a2", "p2", 2019, 365, 34.99f, "bb2"),
                new Book("b3", "a3", "p3", 2017, 312, 24.99f, "bb3"),
                new Book("b4", "a2", "p4", 2016, 15, 20f, "bb4"),
                new Book("b5", "a1", "p5", 2015, 2546, 100f, "bb5"),
                new Book("b6", "a2", "p6", 2014, 123, 999f, "bb6"),
                new Book("b7", "a4", "p7", 2013, 986, 49.99f, "bb7"),
                new Book("b8", "a3", "p8", 2012, 111, 1f, "bb8"),
            };
            // список книг заданного автора;
            Console.WriteLine("Поиск по автору, укажите автора: ");
            string a_search = Console.ReadLine();
            bool search_mark = false;
            foreach(Book baut in books)
            {
                if(string.Compare(baut.AuthorName, a_search) == 0)
                {
                    WriteBookData(baut);
                    search_mark = true;
                }
            }
            if(!search_mark)
            {
                Console.WriteLine("По данному автору ничего не найдено.\n");
            }
            // список книг после определённого года издания
            Console.WriteLine("Поиск по году издания, укажите год: ");
            search_mark = false;
            int y_search = Convert.ToInt16(Console.ReadLine());
            foreach (Book byear in books)
            {
                if (byear.PublishingYear >= y_search)
                {
                    WriteBookData(byear);
                    search_mark = true;
                }
            }
            if (!search_mark)
            {
                Console.WriteLine("По данному году издания ничего не найдено.\n");
            }
            //переопред
            Console.WriteLine("Результат переопределённой функции Equals: " + Convert.ToString(NewClass.Equals(books[0], books[1])));
            Console.ReadKey();
        }
        static void Anonimous()
        {
            var anonimous = new { anstr = "sdtfgh", annum = 999};
            Console.WriteLine($"Анонимный тип: {anonimous.GetType()}\n\n");
        }
        static void WriteBookData(Book book)
        {
            Console.WriteLine($"Книга:\n\tНазвание: {book.Title}\n\tАвтор: {book.AuthorName}\n\tИздательство: {book.PublisherName}\n\tГод издания: {book.PublishingYear}\n\tСтраниц: {book.PagesCount}\n\tЦена: {book.Price}$\n\tПереплёт: {book.BindingType}");
        }
    }
}
