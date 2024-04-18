using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SinglyLinkedList
{
    internal class SLList<T>
    {
        public GenericNode<T>? Head { get; set; }

        public SLList()
        {
            Head = null;
        }

        public void InsertFirst(T t)
        {
            GenericNode<T> tmp = new()
            {
                Value = t,
                Next = Head
            };
            Head = tmp;
        }

        public GenericNode<T>? RemoveFirst()
        {
            if (Head is null)
            {
                return null;
            }
            GenericNode<T> tmp = Head;
            Head = Head.Next;
            return tmp;
        }

        public void InsertLast(T t)
        {
            GenericNode<T> node;

            // If list is empty
            if (Head is null)
            {
                InsertFirst(t);
                return;
            }

            GenericNode<T> tmp = new()
            {
                Value = t,
                Next = null
            };

            for (node = Head; node.Next is not null; node = node.Next)
            {

            }

            node.Next = tmp;
        }

        public GenericNode<T>? RemoveLast()
        {
            GenericNode<T>? tmp;
            GenericNode<T>? node;

            // If list is empty
            if (Head is null)
            {
                return null;
            }

            // If list includes only one node
            if (Head.Next is null)
            {
                tmp = Head;
                Head = Head.Next;   // null
                return tmp;
            }

            // If list contains more than one nodes
            for (node = Head; node.Next is not null; node = node.Next)
            {
                if (node.Next.Next is null)
                {
                    break;
                }
            }
            tmp = node.Next;
            node.Next = null;
            return tmp;
        }

        public void Traverse()
        {
            if (Head is null)
            {
                Console.WriteLine("Empty List");
                return;
            }
            for (GenericNode<T> node = Head; node is not null; node = node.Next!)
            {
                Console.WriteLine($"Value: {node.Value}");
            }
        }
    }
}
