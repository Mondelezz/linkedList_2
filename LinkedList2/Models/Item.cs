using System;


namespace LinkedList2.Models
{
    public class Item<T>
    {
        private T data = default(T);
        public T Data { get { return data; } set { data = value; } }
        public Item<T> Next { get; set; }

        public Item(T data)
        {
            Data = data;
        }

    }
}
