using System;
using System.Reflection;

namespace P01_CustomLIst
{
    public class CustomLIst
    {
        private const int IniitialCapacity = 2;
        private int initailIntValue = 0;

        private int[] items;

        public CustomLIst()
        {
            this.items = new int[IniitialCapacity];
        }

        public int Count { get; private set; }
        public int this[int index]
        {
            get
            {
                ValidateIndex(index);
                return items[index];
            }
            set
            {
                ValidateIndex(index);
                items[index] = value;
            }
        }

        public void Add(int item)
        {
            if (this.Count == items.Length)
            {
                this.Resize();
            }

            this.items[Count] = item;
            this.Count++;
        }

        public int RemoveAt(int index)
        {
            ValidateIndex(index);

            int removedItem = this.items[index];
            this.items[index] = default(int);
            Shift(index);

            this.Count--;
            if (Count < this.items.Length / 4)
            {
                this.Shrink();
            }

            return removedItem;
        }

        public void Insert(int index, int item)
        {
            ValidateIndex(index);

            if (this.Count == items.Length)
            {
                this.Resize();
            }

            this.ShiftToRight(index);

            this.items[index] = item;
            Count++;
        }

        public bool Contains(int item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (items[i] == item)
                {
                    return true;
                }
            }
            return false;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            ValidateIndex(firstIndex);
            ValidateIndex(secondIndex);

            int tempItem = items[firstIndex];
            items[firstIndex] = items[secondIndex];
            items[secondIndex] = tempItem;
        }

        private void ValidateIndex(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException();
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

        private void Shift(int index)
        {
            for (int i = index; i < Count - 1; i++)
            {
                this.items[i] = this.items[i + 1];
            }
        }

        private void Shrink()
        {
            int[] copy = new int[this.items.Length / 2];

            for (int i = 0; i < this.items.Length; i++)
            {
                copy[i] = this.items[i];
            }

            this.items = copy;
        }

        private void ShiftToRight(int index)
        {
            for (int i = Count; i > index; i--)
            {
                this.items[i] = this.items[i - 1];
            }
        }
    }
}

