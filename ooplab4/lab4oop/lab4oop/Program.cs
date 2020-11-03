using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Security.Cryptography.X509Certificates;

namespace lab4oop
{

    class Program
    {
        static void Main(string[] args)
        {

            var list1 = new List<string>();
            var list2 = new List<string>();
            List<string>.Owner user1 = new List<string>.Owner();  
            user1.ID = 1337808;                                   
            user1.name = "SummerPain";                        
            user1.organisation = "OOO Oscorp";                    //OWNER
            List<string>.Owner user2 = new List<string>.Owner();
            user2.ID = 0112358;                            
            user2.name = "Fibonacci";                              
            user2.organisation = "NoLifeSummerSadness";       
            List<string>.Date date1 = new List<string>.Date();
            list1.Add("1Первй");
            list1.Add("1Врой");
            list1.Add("1Третий");
            list2.Add("2Первй");
            list2.Add("орой");
            list2.Add("2Третиbbbй");
            var list3 = new List<string>();

            bool check = list1 == list2; // равенство
            Console.WriteLine("Первый список:");
            Print(list1);
            Console.WriteLine(" \nВторой список:");
            Print(list2);
            Console.WriteLine("Проверка равенства - 1 и 2 списки - " + check);
            Console.WriteLine("Дата создания " + date1.date);
            Console.WriteLine("Кол-во элементов 1 списка" + StatisticOperation.elemetsCount(list1));
            var list3int = new List<int>();
            list3int.Add(177013);
            list3int.Add(1707);
            list3int.Add(228);
            list3int.Add(314);
            list3int.Add(1337);
            list3int.Add(8);

            list1 = list1 >> 1;
            Console.WriteLine(" \n1 список с удалённым элементом: ");
            Print(list1);

            list1 = list1 + 1;
            Console.WriteLine(" \n1 список с новым элементом: ");
            Print(list1);

            bool listsEquality = list1 != list1;
            Console.WriteLine(" \n Проверка равенства - списки не равны? - " + listsEquality);

            Console.WriteLine(" \nТретий список(int):");
            Print(list3int);
            Console.WriteLine(" \nСумма элементов в 3ем списке:");
            Console.WriteLine(StatisticOperation.elementsSum(list3int));

            Console.WriteLine(" \nРазница между макс. и мин. элементами в 3ем списке: " + StatisticOperation.MaxElem(list3int));

            Console.WriteLine(" \nСамое длинное слово во 2ом списке: " + StatisticOperation.longestWord(list2));

            Console.ReadLine();
        }
        static void Print(List<string> list)
        {
            var node = list.First;
            while (node != null)
            {
                Console.Write(node.Value + " - ");
                node = node.Next;
            }
            Console.WriteLine();
        }
        static void Print(List<int> list)
        {
            var node = list.First;
            while (node != null)
            {
                Console.Write(node.Value + " - ");
                node = node.Next;
            }
            Console.WriteLine();
        }
    }
}