namespace CustomListArrayCollections.Models
{
    internal class CustomList<T>
    {
        private T[] array = new T[0];
        public int Capacity { get; set; } = 4;
        public int Count { get; set; } = 0;
        private int Length { get; set; }
        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
        int n = 0;
        public CustomList()
        {
            array = new T[Capacity];
        }
        public void Add(T item)
        {
            Count++;
            if (Count > Capacity)
            {
                Capacity *= 2;
                Length = Capacity;
                Array.Resize(ref array, Length * 2);
                n++;
            }
            array[Count - 1] = item;
            Console.WriteLine($"--------------{n}-------ARRAY RESIZE METODU SAYI----");
        }

        public void AddRange(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Add(array[i]);
            }
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (item.GetType == array[i].GetType)
                {
                    return true;
                }
            }
            return false;
        }



        //daxiline int tipinden deyisen daxil edirikk o deyisene silmek istediyimiz elementin indeksin oturub bize verir bir nov indexof metodu kimi
        public int Contains(T item, int a)
        {
            for (int i = 0; i < Count; i++)
            {
                if (item.GetType == array[i].GetType)
                {
                    a = i;
                    return a;
                }
            }
            return -1;
        }
        //public T Sum()//MENTIQSIZ OLDUGU QERARINA GELDIM
        //{
        //    T sum = default(T);
        //    for (int i = 0; i<array.Length; i++)
        //    {
        //        sum = sum + array[i];
        //    }

        //}

        public void Remove(T item)
        {
            int index = 0;
            index = Contains(item, index);
            for (int i = index; i < Count - 1; i++)
            {
                array[i] = array[i + 1];
            }

            Count--;
        }

        public void RemoveRange(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Remove(array[i]);
            }
        }
        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < Count; i++)
            {
                result += $"   {array[i]}   ";
            }
            return result;
        }

    }
}
