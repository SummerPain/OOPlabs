using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задания/функции:\n");
            Console.WriteLine(" 1)Типы.\n 2)Строки.\n 3)Массивы.\n 4)Кортежи.\n 5)Работа с массивами.\n 6)Работа с checked/unchecked.\n");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    func1(args);
                    break;

                case 2:
                    func2(args);
                    break;

                case 3:
                    func3(args);
                    break;

                case 4:
                    func4(args);
                    break;

                case 5:
                    func5(args);
                    break;
                case 6:
                    func6(args);
                    break;

            }
            Console.ReadKey();
        }
        static void func1(string[] args)
        {

            //Типы
            Console.WriteLine("Тип bool:");
            bool check = true;
            Console.WriteLine(check ? "Checked" : "Not checked");
            Console.WriteLine(false ? "Checked" : "Not checked");
            Console.WriteLine("Тип byte:");
            byte a = 254;
            Console.WriteLine(a);
            Console.WriteLine("Тип sbyte:");
            sbyte b = -128;
            Console.WriteLine(b);
            Console.WriteLine("Тип char:");
            char c = 's';
            Console.WriteLine(c);
            Console.WriteLine("Тип decimal:");
            decimal d = 45.08M;
            Console.WriteLine(d);
            Console.WriteLine("Тип double:");
            double e = 12312312313;
            Console.WriteLine(e);
            Console.WriteLine("Тип float:");
            float f = 12313.22F;
            Console.WriteLine(f);
            Console.WriteLine("Тип int:");
            int g = 1;
            Console.WriteLine(g);
            Console.WriteLine("Тип uint");
            uint a1 = 43023421;
            Console.WriteLine(a1);
            Console.WriteLine("Тип long:");
            long a2 = -213123123;
            Console.WriteLine(a2);
            Console.WriteLine("Тип ulong");
            ulong a3 = 123123;
            Console.WriteLine(a3);
            Console.WriteLine("Тип short");
            short a4 = 3212;
            Console.WriteLine(a4);
            Console.WriteLine("Тип ushort:");
            ushort b1 = 2313;
            Console.WriteLine(b1);

            //Не явное преоброзование
            int a11 = 111111111;
            long b11 = a11;

            byte a22 = 22;
            ushort b22 = a22;

            uint a33 = 2323233;
            ulong b33 = a33;

            sbyte a44 = 127;
            short b44 = a44;

            //Явное преоброзование 
            Console.WriteLine("Явное преобразование:");
            double x = 1234.7;
            Console.WriteLine("До " + x);
            int a55;
            a55 = (int)x;
            Console.WriteLine("После " + a55);

            //Упаковка и распоковка 
            int price = 10;
            object obj = price;

            int price2 = (int)obj;

            //Неявно типизорованая переменная
            for (var i = 0; i < 10; i++)
            {
                string b66 = DateTime.Now.ToString();
                Console.WriteLine(b66);
            }

            //работа с null
            int? c66 = 7;
            if (c66 != null)
            {
                Console.WriteLine($"c is {c66.Value}");
            }
            else
            {
                Console.WriteLine("c does not have a value");
            }
            //????????????????????????????????
            var aa = 10000;
            int bb = aa;
            //????????????????????????????????
        }
        static void func2(string[] args)
        {
            //сравнение строк
            Console.WriteLine("Введите первую строку: ");
            string s1 = Console.ReadLine();
            Console.WriteLine("Введите вторую строку: ");
            string s2 = Console.ReadLine();
            Console.WriteLine("Результат сравнения:" + (s1 == s2));

            //приколы над строками
            string line1 = "Первая строка";
            string line2 = "Вторая строка";
            string line3 = "Третья строка";
            Console.WriteLine("Конкантинация:" + (line1 + line2 + line3));
            Console.WriteLine("Выделение подстроки:" + (line1.Substring(2, 5)));
            string[] words = line1.Split(' ');
            Console.WriteLine("Певрое слово:" + words[0]);
            Console.WriteLine("Второе слово:" + words[1]);
            string modif = line2.Insert(2, line1);
            Console.WriteLine("После вставки подстроки: " + modif);
            var user = new
            {
                Name = "John Doe",
                Age = 42
            };
            Console.WriteLine($"{user.Name} is {user.Age} years old");

            //Создайте пустую и nullстроку. Продемонстрируйте использование метода string.IsNullOrEmpty. Продемонстрируйте что еще можно выполнить с такими строками
            Console.WriteLine("Провекра на пустоту: ");
            string str1 = null;
            string str2 = "";
            Console.WriteLine(string.IsNullOrEmpty(str1));
            Console.WriteLine(string.IsNullOrEmpty(str2));

            StringBuilder sb1 = new StringBuilder("hello world");
            sb1.Remove(0, 2);
            Console.WriteLine("Удаление символов: " + (sb1));
            sb1.Replace("world", "мир");
            Console.WriteLine("Замена слова: " + sb1);
            sb1.Insert(0, "хочу кушац");
            Console.WriteLine("Вставка слова: " + sb1);
        }
        static void func3(string[] args)
        {
            //массивы
            //a
            // Объявляем двумерный массив
            int[,] myArr = new int[4, 5];

            Random ran = new Random();

            // Инициализируем данный массив
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    myArr[i, j] = ran.Next(1, 15);
                    Console.Write("{0}\t", myArr[i, j]);
                }
                Console.WriteLine();
            }
            string[] mas = { "first", "second", "third" };
            int length = mas.Length;
            for (int i = 0; i < length; ++i)
            {
                if (i == 2)
                {
                    mas[i] = "not second";
                }
            }
            Console.WriteLine();
            for (int i = 0; i < length; ++i)
            {
                Console.WriteLine(mas[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Длинна массива : {0}", length);
            Console.ReadKey();

            int[][] mas1 = new int[3][];
            mas1[0] = new int[2] { 1, 2 };
            mas1[1] = new int[3] { 1, 2, 3 };
            mas1[2] = new int[4] { 1, 2, 3, 4 };
            for (int i = 0; i < mas1.Length; i++)
            {
                for (int j = 0; j < mas1[i].Length; j++)
                {
                    Console.Write($"{mas1[i][j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            var varMas = new[] { 1, 2, 3, 4, 5 };
            for (int k = 1; k <= varMas.Length; k++)
            {
                Console.WriteLine(k);
            }
            Console.ReadKey();

            var array = new object[0];
            var str = "";
        }
        static void func4(string[] args)
        {
            (int, string, char, string, ulong) tuple1 = (10, "Привет", 't', "world", 12312313);
            Console.WriteLine(tuple1);
            Console.WriteLine(tuple1.Item1);
            Console.WriteLine(tuple1.Item3);
            Console.WriteLine(tuple1.Item4);

            var t = ("post office", 3.6);
            (string destination, double distance) = t;
            Console.WriteLine($"Distance to {destination} is {distance} kilometers.");

            (int a, byte b) left = (5, 10);
            (long a, int b) right = (5, 10);
            Console.WriteLine(left == right);  // output: True
            Console.WriteLine(left != right);
        }
        static void func5(string[] args)
        {
            int[] a = new int[] { 3, 4, 1, 2, 5 };
            string s = "Hello";
            var tuple = GetValues(a, s);
            Console.WriteLine($"Максимальный элемент: {tuple.Max}");
            Console.WriteLine($"Минимальный элемент: {tuple.Min}");
            Console.WriteLine($"Сумма элементов: {tuple.Sum}");
            Console.WriteLine($"Первый символ строки: {tuple.First}");
            Console.ReadKey();
        }
        private static (int Max, int Min, int Sum, string First) GetValues(int[] a, string s)
        {

            var result = (Max: a[0], Min: a[0], Sum: 0, First: "");
            result.First = s.Remove(1);
            for (int i = 0; i < a.Length; i++)
            {
                result.Sum += a[i];
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (result.Max < a[i])
                {
                    result.Max = a[i];
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (result.Min > a[i])
                {
                    result.Min = a[i];
                }
            }
            return result;
        }
        static void func6(string[] args)
        {
            int ten = 10;
            unchecked //при переполнении типа считает заново, при чеке выдаёт ошибку

            {

                int i1 = 2147483647 + ten;
                Console.WriteLine(i1);
            }
        }
    }
}
