using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    internal class GenericNode<T>
    {
        public T? Value { get; set; }
        public GenericNode<T>? Next { get; set; }
    }
}
