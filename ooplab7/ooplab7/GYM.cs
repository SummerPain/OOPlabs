using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooplab7
{
    class GYM
    {
        private Inventory[] count_of;
        public Inventory[] Count_of
        {
            get { return count_of; }
        }
        private int maxIndex;
        private int all_Price;
        private int counted_all;
        private int count = 0;
        public int All_price
        {
            get { return All_price; }
        }
        public int MaxIndex
        {
            get { return maxIndex; }
        }
        public Inventory this[int index] /////////////////аксессоры
        {
            get
            {
                if (index > maxIndex)
                {
                    Console.WriteLine("Превышение максимального размера массива");
                    return null;
                }
                return count_of[index];
            }
            set
            {
                counted_all = counted_all + value.Price;
                if (index > maxIndex)
                {
                    Console.WriteLine("Элемента с таким индексом не существует");
                }
                else if (counted_all > all_Price && all_Price != 0)
                {
                    Console.WriteLine("Превышение максимальной цены!");
                    count_of[index] = null;
                }
                else
                {
                    count_of[index] = value;
                    count++;
                }
            }
        }
        public GYM(int maxIndex, int All_price) ////конструктор
        {
            this.maxIndex = maxIndex;
            count_of = new Inventory[maxIndex];
            this.all_Price = All_price;
        }
        public GYM(int maxIndex)
        {
            this.maxIndex = maxIndex;
            count_of = new Inventory[maxIndex];
        }
        public void Info()////////вывод содержимого массива
        {
            for (int i = 0; i < MaxIndex; i++)
            {
                Console.WriteLine(count_of[i]);
            }
        }
        //public void Del(int index)
        //{
        //    count_of[index] = null;
        //}
        public bool isEmpty()
        {
            return (count == 0);
        }
        public bool isFull()
        {
            return (count == maxIndex);
        }
        public void Add(Inventory el)   //////добавление элемента в массив
        {
            if (isFull())
                return;
            count_of[count++] = el;
        }

        public void Del(Inventory el) ///удаление элемента по его имени
        {
            int num = 0;
            if (isEmpty())
                return;
            for (int i = 0; i < count; i++)
            {
                if (count_of[i].Equals(el))
                    num = i;
            }
            for (int i = num; i < count; i++)
            {
                count_of[i] = count_of[i + 1];
            }
            count--;
        }
        public static void Sort(GYM el) ///////////////Сортировка по цене: от большего к меньшему
        {
            Inventory elem;
            for (int i = 0; i < el.count - 1; i++)
            {
                for (int j = 0; j < el.count - i - 1; j++)
                {
                    if (el.Count_of[j].Price < el.Count_of[j + 1].Price)
                    {
                        elem = el.Count_of[j];
                        el.Count_of[j] = el.Count_of[j + 1];
                        el.Count_of[j + 1] = elem;
                    }
                }
            }
        }
    }
}
