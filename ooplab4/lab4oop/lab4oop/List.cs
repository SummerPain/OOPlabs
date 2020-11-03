using System;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Messaging;

namespace lab4oop { 

    public class List<T> where T : IComparable
    {
        private Item<T> head;
        private Item<T> tail;
        private int count;
        public class Owner
        {
            public int ID;
            public string name;
            public string organisation;
            public Owner()
            {
                ID = 0;
                name = null;
                organisation = null;
            }

        }
        public class Date
        {
            public DateTime date = DateTime.Now;
            public Date()
            {

            }
        }
        public int Count
        {
            get
            {
                return count;
            }
        }
        public Item<T> First
        {
            get
            {
                return head;
            }
        }
        public List()
        {

        }
        public void AddAfter(Item<T> node, T value)
        {
            Item<T> newNode = new Item<T>(value, node.Next);
            node.Next = newNode;

            count++;
        }
        public void Add(T value)
        {
            if (head == null)
            {
                head = tail = new Item<T>(value, null);
                count++;
            }
            else
            {
                AddAfter(tail, value);
                tail = tail.Next;
            }
        }
        public Item<T> Find(T value)
        {
            Item<T> ptr = head;
            while (ptr != null)
            {
                if (ptr.Value.CompareTo(value) == 0)
                    return ptr;
                ptr = ptr.Next;
            }
            return null;
        }
        public static List<T> operator >>(List<T> list, int delNum) //удалить элемент
        {
            Item<T> bufferNextPtr = null;
            Item<T> node = list.First;
            int nodeNum = 0;
            while (node != null)
            {
                if(nodeNum == delNum-1)
                {
                    bufferNextPtr = node;
                } else if(nodeNum == delNum)
                {
                    bufferNextPtr.Next = node.Next;
                    node = null;
                    break;
                }
                nodeNum++;
                node = node.Next;
            }
            return list;
        }
        private static Item<T> createNewItem(object value, Item<T> nextPtr)
        {
            return new Item<T>((T)value, nextPtr);
        }
        public static List<T> operator +(List<T> list, int plusNum) //добавить элемент
        {
            Item<T> bufferNextPtr = null;
            Item<T> node = list.First;
            object V = "0";
            int nodeNum = 0;
            while (node != null)
            {
                if (nodeNum == plusNum - 1)
                {
                    bufferNextPtr = node;
                }
                else if (nodeNum == plusNum)
                {
                    bufferNextPtr.Next = createNewItem(V, node); //hcgvksedrfgUYJHINGETUJIYHER B BHNLseDRT UI;HN EDRTFG BJHMNG ESDRFV
                    break;
                }
                nodeNum++;
                node = node.Next;
            }
            return list;
        }

        public static bool operator ==(List<T> list1, List<T> list2) //перегрузка на равность
        {
            bool check = false;
            var node1 = list1.First;
            var node2 = list2.First;
            while (node1 != null && node2 != null)
            {

                if (node1.Value.CompareTo(node2.Value) == 0)
                {
                    check = true;
                }
                node1 = node1.Next;
                node2 = node2.Next;
            }
            return check;
        }
        public static bool operator !=(List<T> list1, List<T> list2) //Перегрузка на неравность
        {
            bool check = true;
            var node1 = list1.First;
            var node2 = list2.First;
            while (node1 != null && node2 != null)
            {

                if (node1.Value.CompareTo(node2.Value) == 0)
                {
                    check = false;
                }
                node1 = node1.Next;
                node2 = node2.Next;
            }
            return check;
        }
    }
    public static class StatisticOperation
    {
        public static int elemetsCount(List<string> list)
        {
            int count = 0;
            var node = list.First;
            while (node != null)
            {
                node = node.Next;
                count++;
            }
            return count;
        }
        public static int elementsSum(List<int> list)
        {
            int summ = 0;
            var node = list.First;
            while (node != null)
            {
                summ = summ + node.Value;
                node = node.Next;
            }
            return summ;
        }
        public static int MaxElem(List<int> list)
        {
            int max = 0;
            var node = list.First;
            int min = node.Value;
            while (node != null)
            {
                if (max < node.Value)
                {
                    max = node.Value;
                }
                if (min > node.Value)
                {
                    min = node.Value;
                }

                node = node.Next;
            }
            max = max - min;
            return max;
        }
        public static string longestWord(List<string> list)
        {
            int maxLen = 0;
            var node = list.First;
            Item<string> maxLenWord = null;
            while (node != null)
            {
                if (maxLen < node.Value.Length)
                {
                    maxLen = node.Value.Length;
                    maxLenWord = node;
                }
                node = node.Next;
            }

            return maxLenWord.Value;
        }
    }
}