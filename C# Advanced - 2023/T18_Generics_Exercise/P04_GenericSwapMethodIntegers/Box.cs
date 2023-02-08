using System;
using System.Text;

namespace GenericSwapMethodIntegers
{
    public class Box<T>
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

        public void Swap(int index1, int index2)
        {
            T temp = items[index1];
            items[index1] = items[index2];
            items[index2] = temp;
        }

        public override string ToString()
        {
            StringBuilder sb = new();

            foreach (var item in items)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}