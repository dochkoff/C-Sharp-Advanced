using System;
using System.Collections;

namespace Stack
{
    public class CustomStack<T> : IEnumerable<T>
    {
        private int initialSize = 4;
        T[] items;

        public CustomStack()
        {
            this.items = new T[initialSize];
        }

        public int Count { get; private set; }

        public void Push(T element)
        {
            if (items.Length == Count)
            {
                Resize();
            }

            this.items[Count] = element;

            Count++;
        }

        public T Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("No elements");
            }

            T removedItem = items[Count - 1];
            Count--;
            return removedItem;
        }

        private T[] Resize()
        {
            T[] copy = new T[items.Length * 2];

            for (int i = 0; i < items.Length; i++)
            {
                copy[i] = items[i];
            }

            items = copy;

            return items;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}

