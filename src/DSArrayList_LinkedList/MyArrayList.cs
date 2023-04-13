using System;

namespace KTLT2_TAODOITUONG.src.DSArrayList_LinkedList
{
    class MyArrayList
    {
        private int[] items;
        private int capacity;
        private int count = 0;

        public MyArrayList(int maxSize)
        {
            this.items = new int[maxSize];
            this.capacity = maxSize;
            this.count = 0;
        }

        public int Capacity
        {
            get => capacity;
            set
            {

                if (value >= capacity)
                {
                    capacity = value;
                    Array.Resize(ref items, capacity);
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        public int Count { get => count; }

        public bool isFull()
        {
            return Count == Capacity;
        }
        public bool isEmpty()
        {
            return Count == 0;
        }
        public bool Clear()
        {
            return true;
        }

        public int Add(int value)
        {
            if (!isFull())
            {
                items[count] = value;
            }
            else
            {
                if (capacity == 0)
                {
                    capacity = 4;
                }
                else
                {
                    capacity = capacity * 2;
                }
                items[count] = value;
            }
            count++;
            return count - 1;
        }

        public void Insert(int index, int value)
        {
            // kiem tra tinh hop le cua index
            if (index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                // kiem tra dung luong
                if (!isFull())
                {
                    // dich sang phai cac vi tri
                    // chep gia tri vao vi tri can chen
                    for (int i = index; i < count; i++)
                    {
                        items[i] = items[i + 1];
                    }
                    items[index] = value;
                    count++;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        public int FindFirstItem(int value)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }
        public bool Remove(int value)
        {
            int position = FindFirstItem(value);
            if (position == -1)
            {
                return false;
            }
            for (int i = position; i < count - 1; i++)
            {
                items[i] = items[i + 1];
                items[count - 1] = 0;
            }
            count--;

            return true;
        }
        //in mang
        public void PrintList()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(items[i] + " ");
            }
            Console.WriteLine();
        }
        //indexer
        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return items[index];
            }
            set
            {
                items[(int)index] = value;
            }
        }
    }
}
