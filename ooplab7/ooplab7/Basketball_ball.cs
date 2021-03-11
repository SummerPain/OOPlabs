using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooplab7
{
    sealed class Basketball_Ball : Ball, Iusing
    {
        new private string type_of_ball = "баскет боль...";
        public Basketball_Ball()
        {
            Quantity = 0;
            Price = 0;
            material = "";
            year_of_create = 0;
            brand = "";
        }
        public Basketball_Ball(string _material, int _year_of_create, string _brand, int _quantity, int _price)
           : base(_material, _year_of_create, _brand, _quantity, _price)
        {
        }
        void Iusing.Use()
        {
            Console.WriteLine("Играем с баскетбольным мячом...");
        }
        public override void Virtual_For_Ball()
        {
            Console.WriteLine("Виртуальный метод баскетбольного мяча");
        }
        //public string GetInfo()
        //{
        //    return "Количество: " + Quantity + "\nЦена: " + Price + "\nМатериал: " + material + "\nДата создания: " + year_of_create + "\nБренд: " + brand + "\n" +  type_of_ball;
        //}
        public override void Use()
        {
            Console.WriteLine("Произошло переопределение абстрактного метода..Играем с баскетбольным мячом дальше....");
        }
        public override string ToString()////////переопределение tostring
        {
            return "Баскетбольные мячи: " +
                "\n Количество: " + Quantity.ToString() +
                "\n Цена: " + Price.ToString() +
                "\n Материал: " + material.ToString() +
                "\n Бренд: " + brand.ToString() +
                "\n Год создания: " + year_of_create.ToString() +
                "\n" + type_of_ball.ToString() + "\n------------------------------------------------";
        }
    } 
}
