using System;
using System.IO;

namespace ooplab7
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////////////////////////////////////////////////////////////// 5
            //Inventory inv;
            //Ball ball1 = new Ball("материал мяча", 2021, "бренд", 5, 228);
            //Basketball_Ball ball2 = new Basketball_Ball("синтетика", 2009, "Бренд", 16, 300);
            //Console.WriteLine(ball2.ToString());
            //Console.WriteLine(ball1.ToString());
            //Iusing ball3 = new Ball("звёздная пыль", 2999, "NePers", 1, 200);
            //Console.WriteLine(ball3.ToString());
            //inv = ball1 as Inventory;
            //Console.WriteLine(inv.ToString());
            //Tennis ten1 = new Tennis(1, 2223, 2, "зелёный");
            //Console.WriteLine(ten1.ToString());
            //Iusing bar1 = new Bars(2, 3213, 2, 3);
            //Console.WriteLine(bar1.ToString());
            //Mats mat1 = new Mats(5, 1531, "Квадратный", 200);
            //Console.WriteLine(mat1.ToString());
            //Iusing ben1 = new Bench(4, 214, 4);
            //Console.WriteLine(ben1.ToString());
            //ball1.Use();
            //ball2.Use();
            //ball3.Use();
            //((Iusing)ball1).Use(); //вызов переопределённого метода интерфейса
            //inv.Use();
            //ten1.Use();
            //bar1.Use();
            //mat1.Use();
            //ben1.Use();
            //Iusing[] array = { ball3, bar1, ben1 };
            //Printer printer = new Printer();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    printer.iAmPrinting(array[i]);
            //}
            //Console.ReadLine();
            /////////////////////////////////////////////////////////////////////////////////////////////////////////// 6
            //Ball football = new Ball(Type_of_Ball.football);
            //football.Print();
            //Prikol prikol1 = new Prikol("да", "нет");
            //Prikol prikol2 = new Prikol("нет", "да");
            //GYM gym = new GYM(10, 2000);
            //Bars bar1 = new Bars(4, 444, 555, 666);
            //gym[0] = new Mats(5, 500, "круг", 200);
            //gym[1] = new Bars(1, 1000, 200, 324);
            //gym[2] = new Bench(120, 10, 200);
            //gym[3] = new Bars(3, 100, 200, 324);
            //gym[4] = new Bars(2, 1000, 200, 324);
            //gym.Add(bar1);
            //Console.WriteLine("Вывод изначального массива: ");
            //gym.Info();
            //Console.WriteLine("Удаление элемента..");
            //gym.Del(gym[1]);
            //gym.Info();
            //GYM.Sort(gym);
            //Console.WriteLine("Отсортированный массив:");
            //gym.Info();
            //Console.WriteLine("Вывод снарядов в определённом ценовом диапазоне");
            //GYMController.Item_On_Price_Range(200, 900, gym);
            ////дополнительное задание:

            ////GYM gym_file = new GYM(3);
            ////GYMController.Read_from_file(ref gym_file);
            ////gym_file.Info();
            //Console.ReadLine();
            ////////////////////////////////////////////////////////////////////////////////////////////7ая лаба
            try
            {
                Mats mat1 = new Mats(5, 1245, "Овал", 1000);////////исключение на минимальную пложадь мата.
                Tennis ten1 = new Tennis(1, 200, 2, "red");        //////количество ракеток больше 3
                Ball ball1 = new Ball("кожа", 2020, "nike", 1, 500); ////цена больше 450
                Bench ben1 = new Bench(200, 2, 2142); ////длина больше 300
                int i = 5;
                int j = i / 0;
            }
            catch (LengthOfBenchException ex)///////////////длина скамейки
            {
                Console.WriteLine(ex.Message);
            }
            catch (CountOfRacketInTennisException ex)////////////////количество ракеток
            {
                Console.WriteLine(ex.Message);
            }
            catch (PriceOfBallException ex)///////////////////цена мяча
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)////////////деление на ноль
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)///////////////////////////универсальное исключение
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally");
            }
            Console.ReadLine();
        }
    }









    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////разделённый класссссссссссссссс(просто ВО)
    //    partial class Mats
    //    {
    //        void Iusing.Use()
    //        {
    //            Console.WriteLine("Адыхаем на мате....");
    //        }
    //        public override void Use()
    //        {
    //            Console.WriteLine("Уже спим на мате...");
    //        }
    //        //    public string GetInfo()
    //        //    {
    //        //        return "Количество: " + Quantity + "\nЦена: " + Price + "\nФорма: " + form + "\nПлощадь: " + space;
    //        //}
    //        public override string ToString()////////переопределение tostring
    //        {
    //            return "Маты: " +
    //                "\n Количество: " + Quantity.ToString() +
    //                "\n Цена: " + Price.ToString() +
    //                "\n Форма: " + form.ToString() +
    //                "\n Площадь мата: " + space.ToString() + "\n------------------------------------------------";
    //        }
    //    }
}
