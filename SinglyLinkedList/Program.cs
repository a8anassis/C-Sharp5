namespace SinglyLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SLList<int>? intList = new();

            intList.InsertLast(2);
            intList.InsertLast(3);
            intList.InsertFirst(1);

            GenericNode<int>? removedNode = intList.RemoveFirst();
            if (removedNode != null)
            {
                Console.WriteLine($"{removedNode.Value}");
            }

            intList.Traverse();
        }
    }
}