using System;


namespace MyLibrary
{
    public class MyLibrary
    {
        public class List
        {
            private object[] items;
            private int count;
            private int capacity;

            // Конструктор з ємністю за замовчуванням
            public List()
            {
                capacity = 5; // Базова Ємність
                items = new object[capacity];
                count = 0;
            }

            // Конструктор із заданою потужністю
            public List(int initialCapacity)
            {
                capacity = initialCapacity > 0 ? initialCapacity : 5; // Мінімальна ємніть 5
                items = new object[capacity];
                count = 0;
            }

            public int Count { get { return count; } }

            public object this[int index]
            {
                get { return items[index]; }
                set { items[index] = value; }
            }

            public void Add(object obj)
            {
                EnsureCapacity();
                items[count] = obj;
                count++;
            }

            public void Insert(int index, object obj)
            {
                if (index < 0 || index > count)
                    throw new IndexOutOfRangeException("Index out of range.");

                EnsureCapacity();

                // Зсув елементів вправо
                for (int i = count; i > index; i--)
                {
                    items[i] = items[i - 1];
                }

                items[index] = obj;
                count++;
            }

            public void Remove(object obj)
            {
                for (int i = 0; i < count; i++)
                {
                    if (items[i].Equals(obj))
                    {
                        RemoveAt(i);
                        return;
                    }
                }
            }

            public void RemoveAt(int index)
            {
                if (index < 0 || index >= count)
                    throw new IndexOutOfRangeException("Index out of range.");

                for (int i = index; i < count - 1; i++)
                {
                    items[i] = items[i + 1];
                }

                items[count - 1] = null; // Видалити останній елемент
                count--;
            }

            public void Clear()
            {
                for (int i = 0; i < count; i++)
                {
                    items[i] = null;
                }
                count = 0;
            }

            public bool Contains(object obj)
            {
                for (int i = 0; i < count; i++)
                {
                    if (items[i].Equals(obj))
                        return true;
                }
                return false;
            }

            public int IndexOf(object obj)
            {
                for (int i = 0; i < count; i++)
                {
                    if (items[i].Equals(obj))
                        return i;
                }
                return -1;
            }

            public object[] ToArray()
            {
                object[] array = new object[count];
                for (int i = 0; i < count; i++)
                {
                    array[i] = items[i];
                }
                return array;
            }

            public void Reverse()
            {
                for (int i = 0; i < count / 2; i++)
                {
                    object temp = items[i];
                    items[i] = items[count - i - 1];
                    items[count - i - 1] = temp;
                }
            }

            private void EnsureCapacity()
            {
                if (count == capacity)
                {
                    capacity *= 2; // Подвоїти ємніть
                    Array.Resize(ref items, capacity);
                }
            }
        }
    }
}
