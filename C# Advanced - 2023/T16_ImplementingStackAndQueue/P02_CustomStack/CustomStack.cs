using System;
namespace P02_CustomStack
{
    public class CustomStack
    {
        private const int IniitialCapacity = 4;
        private int[] items;
        private int count;

        public CustomStack()
        {
            this.count = 0;
            this.items = new int[IniitialCapacity];
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public void Push(int item)
        {
            if (count == items.Length)
            {
                this.Resize();
            }

            this.items[this.count] = item;
            count++;
        }

        public int Pop()
        {
            this.IsCustomStackEmpty();

            int lastIndex = this.items[this.count - 1];
            this.count--;
            return lastIndex;
        }

        public int Peek()
        {
            this.IsCustomStackEmpty();

            int lastIndex = this.items[this.count - 1];
            return lastIndex;
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

        private void IsCustomStackEmpty()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("CustomStack is empty");
            }
        }
    }
}

