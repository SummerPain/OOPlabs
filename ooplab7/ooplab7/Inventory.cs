using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooplab7
{
    abstract class Inventory
    {
        private int quantity; //Количество элементов данного класса в инвентаре
        protected int Quantity
        {
            get => quantity;
            set => quantity = value;
        }
        private int price; //общая цена элементов данного класса в инвентаре
        public int Price
        {
            protected set => price = value;
            get => price;
        }
        public abstract void Use();
    }
}
