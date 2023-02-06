using System;
namespace P03_CustomQueue
{
    public class CustomQueue
    {
        private const int IniitialCapacity = 4;
        private const int FirstItemIndex = 0;
        private int[] items;
        private int count;

        public CustomQueue()
        {
            count = 0;
            items = new int[IniitialCapacity];
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public void Enqueue(int item)
        {
            if (items.Length == count)
            {
                Resize();
            }

            items[count] = item;
            count++;
        }

        public int Dequeue()
        {
            IsEmpty();
            int fisrtItem = items[FirstItemIndex];
            SwitchElements();
            count--;

            return fisrtItem;
        }

        public int Peek()
        {
            IsEmpty();

            int firstItem = items[FirstItemIndex];
            return firstItem;
        }

        public void Clear()
        {
            IsEmpty();
            items = new int[IniitialCapacity];
            count = 0;
        }

        public void ForEach(Action<int> action)
        {
            for (int i = 0; i < this.count; i++)
            {
                action(items[i]);
            }
        }

        private void Resize()
        {
            int[] copy = new int[this.items.Length * 2];

            for (int i = 0; i < this.items.Length; i++)
            {
                copy[i] = this.items[i];
            }

            this.items = copy;
        }

        private void IsEmpty()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("CustomQueue is empty");
            }
        }

        private void SwitchElements()
        {
            items[FirstItemIndex] = default;


            for (int i = 1; i < items.Length; i++)
            {
                items[i - 1] = items[i];
            }
        }
    }
}

