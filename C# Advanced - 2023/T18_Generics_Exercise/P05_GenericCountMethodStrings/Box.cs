using System;
using System.Text;

namespace GenericCountMethodStrings
{
    public class Box<T> where T : IComparable<T>
    {
        private List<T> items;

        public Box()
        {
            this.items = new List<T>();
        }

        public void Add(T item)
        {
            items.Add(item);
        }

        public int Count(T value)
        {
            int count = 0;

            foreach (var item in items)
            {
                if (item.CompareTo(value) > 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}