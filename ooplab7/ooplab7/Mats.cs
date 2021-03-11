using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ooplab7
{
    partial class Mats : Inventory, Iusing
    {
        private string form; //форма мата
        private int space; //площадь мата
        public Mats()
        {
            Quantity = 0;
            Price = 0;
            form = "";
            space = 0;
        }
        void Iusing.Use()
        {
            Console.WriteLine("Прилёг на мат...");
        }
        public override void Use()
        {
            Console.WriteLine("Прилёг на переопределённый мат...");
        }

        public Mats(int _quantity, int _price, string _form, int _space)
        {
            Quantity = _quantity;
            Price = _price;
            form = _form;
            Debug.Assert(_space > 100, "Слишком маленькая площадь мата");
            space = _space;
        }

    }
}
