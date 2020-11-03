using System;

namespace lab4oop
{
    public class Item<T>
    {
        public T Value;
        public Item<T> Next;
        public Item(T value, Item<T> next = null)
        {
            Value = value;
            Next = next;
        }
    }
}