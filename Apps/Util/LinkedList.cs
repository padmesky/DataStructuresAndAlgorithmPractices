using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithmPractise.Apps.Util
{
    public class LinkedList<T> : ICollection<T>
    {
        public class ListNode<T>
        {
            public ListNode<T> prev;
            public ListNode<T> next;
            public T value;
            public ListNode(T value)
            {
                this.value = value;
            }
        }

        public ListNode<T> head;
        public ListNode<T> tail;
        private int size = 0;

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void InsertFront(T value)
        {
            ListNode<T> ptr = new ListNode<T>(value);
            if (IsEmpty())
            {
                head = ptr;
                tail = ptr;
            }
            else
            {
                head.prev = ptr;
                ptr.next = head;
                head = ptr;
            }
            size++;
        }

        public void InsertEnd(T value)
        {
            ListNode<T> ptr = new ListNode<T>(value);
            if (IsEmpty())
            {
                head = ptr;
                tail = ptr;
            }
            else
            {
                tail.next = ptr;
                ptr.prev = tail;
                tail = ptr;
            }
            size++;
        }

        public T RemoveFront()
        {
            T value;
            if (IsEmpty())
            {
                return default(T);
            }
            if (head == tail)
            {
                value = head.value;
                head = null;
                tail = null;
                size--;
                return value;
            }
            value = head.value;
            head = head.next;
            head.prev = null;
            size--;
            return value;
        }

        public T RemoveEnd()
        {
            T value;
            if (IsEmpty())
            {
                return default(T);
            }
            if (head == tail)
            {
                value = tail.value;
                head = null;
                tail = null;
                size--;
                return value;
            }
            value = tail.value;
            tail = tail.prev;
            tail.next = null;
            size--;
            return value;
        }

        public bool Remove(T value)
        {
            if (IsEmpty())
            {
                return false;
            }
            if (head == tail && head.value.Equals(value))
            {
                head = null;
                tail = null;
                size--;
                return true;
            }

            ListNode<T> curr = head;

            while (curr != null)
            {
                if (!curr.value.Equals(value))
                {
                    curr = curr.next;
                    continue;
                }

                if (curr == head)
                {
                    head = head.next;
                    head.prev = null;
                    size--;
                    return true;
                }

                if (curr == tail)
                {
                    tail = tail.prev;
                    tail.next = null;
                    size--;
                    return true;
                }

                curr.next.prev = curr.prev;
                curr.prev.next = curr.next;
                size--;
                return true;
            }

            return false;
        }


        public T Front()
        {
            if (IsEmpty())
            {
                return default(T);
            }
            return head.value;
        }

        public T Back()
        {
            if (IsEmpty())
            {
                return default(T);
            }
            return tail.value;
        }

        public bool Contains(T value)
        {
            ListNode<T> curr = head;
            while (curr != null)
            {
                if (curr.value.Equals(value))
                {
                    return true;
                }
                curr = curr.next;
            }
            return false;
        }

        public bool IsEmpty()
        {
            if (head == null && tail == null)
            {
                return true;
            }
            return false;
        }

        public int Size()
        {
            return size;
        }

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }


        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            ListNode<T> curr = head;
            T value = default(T);
            if (curr != null)
            {
                value = curr.value;
                curr = curr.next;
            }

            return (IEnumerator<T>)value;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
