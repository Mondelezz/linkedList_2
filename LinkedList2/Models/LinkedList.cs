using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList2.Models
{
    public class LinkedList<T> : IEnumerable
    {
        public Item<T> Head { get; private set; }
        public Item<T> Tail { get; private set; }
        public int Count { get; private set; }

        public LinkedList()
        {
            Clear();
        }

        public LinkedList(T data)
        {
            SetHeadAndTail(data);
        }

        public void Add(T data)
        {
            if (Tail != null)
            {
                Item<T> item = new Item<T>(data);
                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else
            {
                SetHeadAndTail(data);
            }
        }

        public void AddAfterValue(T target, T data)
        {
            if (Head != null)
            {
                var current = Head;
                Item<T> item = new Item<T>(data);
                while (current != null)
                {
                    if (current.Data.Equals(target))
                    {
                        item.Next = current.Next;
                        current.Next = item;
                        Count++;
                        return;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }
            }
            else
            {
                SetHeadAndTail(data);
            }
        }

        public void AppendHead(T data)
        {
            Item<T> item = new Item<T>(data);
            item.Next = Head;
            Head = item;
            Count++;
        }

        public void Delete(T data)
        {
            if (Head!=null)
            {
                if (Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }
                var current = Head.Next;
                var previous = Head;

                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        previous.Next = current.Next;
                        Count--;
                        return;
                    }
                    previous = current;
                    current = current.Next;
                }
            }           
            else
            {
                SetHeadAndTail(data);
            }
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public void SetHeadAndTail(T data)
        {
            Item<T> item = new Item<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}
