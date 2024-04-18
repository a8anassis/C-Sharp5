using StackApp.Exceptions;

namespace StackApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CFStack? myStack = new CFStack(200);

            try
            {
                myStack.Push(1);
                myStack.Push(2);
                myStack.Push(3);
                myStack.Push(4);
                myStack.Push(5);
                int popped = myStack.Pop();
                Console.WriteLine($"Popped: {popped}");

                if (myStack.Stack == null)
                {
                    return;
                }

                for (int i = 0; i <= myStack.Size; i++)
                {
                    Console.WriteLine($"{myStack.Stack[i]}");
                }
            } catch (StackIsEmptyException e)
            {
                Console.Error.WriteLine($"{e.StackTrace}");
                throw;
            } catch (StackIsFullException e)
            {
                Console.Error.WriteLine($"{e.StackTrace}");
            }
        }
    }
}