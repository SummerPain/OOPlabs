using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3oop
{
    partial class Book
    {
        private static uint count = 0;
        private uint id;
        private string title;
        private string author;
        private string publisher;
        private Int16 year;
        private Int16 pages;
        private float price;
        private string binding;
        //out example
        public static void outexample(out int num) //работа с out
        {
            num = 88;
        }
        //info
        public static void Info()
        {
            Console.WriteLine("\nИнформация объекта:\n");
            Console.WriteLine("ID книги");
            Console.WriteLine("Название книги");
            Console.WriteLine("Имя автора");
            Console.WriteLine("Год издания книги");
            Console.WriteLine("Количество страниц");
            Console.WriteLine("Цена книги");
            Console.WriteLine("Тип переплёта\n\n");
        }
        //get/set funcs
        public uint Count
        {
            get
            {
                return count;
            }
        }
        public uint ID
        {
            get
            {
                return id;
            }
            private set
            {
                while (value < 0)
                {

                    Console.WriteLine("ID был введён неверно, введите заново: ");
                    value = Convert.ToUInt32(Console.ReadLine());
                }
                id = value;
            }
        }
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {

                    throw new ArgumentNullException("Ошибка: пустое название");

                }
                title = value;
            }
        }
        public string AuthorName
        {
            get
            {
                return author;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {

                    throw new ArgumentNullException("Ошибка: пустое имя автора");

                }
                author = value;
            }
        }

        public string PublisherName
        {
            get
            {
                return publisher;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {

                    throw new ArgumentNullException("Ошибка: пустое название издательства");

                }
                publisher = value;
            }
        }
        public Int16 PublishingYear
        {
            get
            {
                return year;
            }
            private set
            {
                while (value <= 0 || value > 2020)
                {
                    Console.WriteLine("Год издания был введён некорректно, введите заново: ");
                    value = Convert.ToInt16(Console.ReadLine());
                }
                year = value;
            }
        }
        public Int16 PagesCount
        {
            get
            {
                return pages;
            }
            private set
            {
                while (value < 0)
                {
                    Console.WriteLine("Количество страниц было введено некорректно, введите заново: ");
                    value = Convert.ToInt16(Console.ReadLine());
                }
                pages = value;
            }
        }
        public float Price
        {
            get
            {
                return price;
            }
            private set
            {
                while (value <= 0 || value > 2020)
                {
                    Console.WriteLine("Цена была введена некорректно, введите заново: ");
                    value = (float)Convert.ToDouble(Console.ReadLine());
                }
                price = value;
            }
        }
        public string BindingType
        {
            get
            {
                return binding;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {

                    throw new ArgumentNullException("Ошибка: пустое название типа переплёта");

                }
                binding = value;
            }
        }
        //constructors

        public Book()
        {
            count++;
            this.title = "Default title";
            this.author = "Default author";
            this.publisher = "Default publisher";
            this.year = 0;
            this.pages = 0;
            this.price = 0;
            this.binding = "Default binding";
            this.id = Hash(pages, (int)price, title);
        }
        public Book(string title, string author, string publisher, Int16 year, Int16 pages, float price, string binding)
        {
            count++;
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.year = year;
            this.pages = pages;
            this.price = price;
            this.binding = binding;
            this.id = Hash(pages, (int)price, title);
        }
        static Book()
        {
            Console.WriteLine("/called static constructor/");
        }
    }
    public partial class Book
    {
        public uint Hash(int pages, int price, string title)
        {
            return (uint)(count - pages*title.Length + price);
        }
    }
    //переопред
    public class NewClass : object
    {
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
