using StackApp.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackApp
{
    internal class CFStack
    {
        public int[]? Stack { get; set; }
        public int Size { get; set; }
        public int Top { get; set; }

        public CFStack()
        {
            Stack = new int[100];
            Size = 100;
            Top = -1;
        }

        public CFStack(int n)
        {
            Stack = new int[n];
            Size = n;
            Top = -1;
        }

        public void Push(int num)
        {
            if (Top == Size - 1)
            {
                throw new StackIsFullException("Error Stack Full");
            }
            if (Stack == null)
            {
                throw new StackIsEmptyException("Error Stack Empty");
            }
            
            Stack[++Top] = num;
        }

        public int Pop()
        {
            if (Top == -1 || Stack is null)
            {
                throw new StackIsEmptyException("Error. Stack is empty");
            }
            
            return Stack[Top--];
        }
    }
}
