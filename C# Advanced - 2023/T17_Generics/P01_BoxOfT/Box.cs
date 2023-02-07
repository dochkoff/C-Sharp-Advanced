using System;
namespace BoxOfT
{
    public class Box<T>
    {
        private int count;
        private List<T> list;

        public Box()
        {
            count = 0;
            list = new();
        }

        public int Count { get { return this.count; } }

        public void Add(T element)
        {
            list.Add(element);
            count++;
        }

        public T Remove()
        {
            T removed = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            count--;
            return removed;
        }
    }
}

