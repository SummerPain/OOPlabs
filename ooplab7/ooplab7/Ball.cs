using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooplab7
{
    class Ball : Inventory, Iusing //наследование св-в инвентаря
    {
        internal string material; //материал
        internal int year_of_create; //дата создания
        internal string brand; //бренд
        public string Brand { get { return brand; } } ////////////свойства
        public int Year_of_create { get { return year_of_create; } }
        public string Material { get { return material; } }
        public Type_of_Ball type_of_ball;
        public Ball()
        {

            Price = 0;
            material = "";
            year_of_create = 0;
            brand = "";
        }

        public Ball(Type_of_Ball type_of_ball)
        {
            this.type_of_ball = type_of_ball;
            Price = 0;
            material = "";
            year_of_create = 0;
            brand = "";
        }
        public Ball(string _material, int _year_of_create, string _brand, int _quantity, int _price)
        {
            if (_price > 450)
            {
                throw new PriceOfBallException("Превышена максимальная стоимость мяча!"); //искючение на стоимость мяча
            }
            material = _material;
            year_of_create = _year_of_create;
            brand = _brand;
            Quantity = _quantity;
            Price = _price;
        }
        void Iusing.Use()
        {
            Console.WriteLine("Играем с мячом...");
        }
        public void Print()
        {
            Console.WriteLine(type_of_ball);
        }
        //public string GetInfo()
        //{
        //    return "Количество: " + Quantity + "\nЦена: " + Price + "\nМатериал: " + material + "\nДата создания: " + year_of_create + "\nБренд: " + brand;
        //}
        public override void Use()
        {
            Console.WriteLine("Произошло переопределение абстрактного метода..Играем с мячом дальше....");
        }
        public override string ToString()////////переопределение tostring
        {
            return "Мячи: " +
                "\n Количество: " + Quantity.ToString() +
                "\n Цена: " + Price.ToString() +
                "\n Материал: " + material.ToString() +
                "\n Бренд: " + brand.ToString() +
                "\n Год создания: " + year_of_create.ToString() + "\n------------------------------------------------";
        }
        public override int GetHashCode() ///////переопределение gethashcode
        {
            return Quantity.GetHashCode() + Price.GetHashCode() + material.GetHashCode() + brand.GetHashCode() + year_of_create.GetHashCode();
        }
        public virtual void Virtual_For_Ball()
        {
            Console.WriteLine("Виртуальный метод мяча............");
        }
        public override bool Equals(object obj) ////Переопределение equals
        {
            if (obj.GetType() != GetType())
                return false;
            if (obj.GetHashCode() != GetHashCode())
                return false;
            return true;
        }
    }
}
