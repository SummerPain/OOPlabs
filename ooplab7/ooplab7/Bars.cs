using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooplab7
{
    sealed class Bars : Inventory, Iusing
    {
        private double heigth; //высота брусьев
        private double length; //длина брусьев
        public Bars()
        {
            Quantity = 0;
            Price = 0;
            heigth = 0;
            length = 0;
        }
        public Bars(int _quantity, int _price, double _heigth, double _length)
        {
            Quantity = _quantity;
            Price = _price;
            heigth = _heigth;
            length = _length;
        }
        void Iusing.Use()
        {
            Console.WriteLine("Делаем упражнения на брусьях.....");
        }
        public override void Use()
        {
            Console.WriteLine("Делаем упражнения усерднее....");
        }
        // public string GetInfo()
        // {
        //return "Количество: " + Quantity + "\nЦена: " + Price + "\nДлина брусьев: " + length + "\nВысота брусьев: " + heigth;
        // }
        public override string ToString()////////переопределение tostring
        {
            return "Брусья: " +
                "\n Количество: " + Quantity.ToString() +
                "\n Цена: " + Price.ToString() +
                "\n Длина брусьев: " + length.ToString() +
                "\n Высота брусьев: " + heigth.ToString() + "\n------------------------------------------------";
        }
    }
}
