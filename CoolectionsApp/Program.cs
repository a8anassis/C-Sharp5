namespace CoolectionsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var intList = new List<int>() { 1, 2, 3};
            var linkedList = new LinkedList<string>();
            var words = new SortedDictionary<int, string>() { {1, "Anna" }, {2, "Bob" } };
            var stack = new Stack<string>();
            var queue = new Queue<string>();


            /* intList.AddRange(new[] { 1, 3, 2 });
             intList.Add(4);
             intList.Add(10);
             intList.Insert(0, 5);
             intList.Remove(10);
             intList.RemoveAt(0);

             intList.Sort();
             intList.Reverse();

             foreach (int item in intList)
             {
                 Console.WriteLine(item);
             }*/


            // Linked List
            /*var item1 = linkedList.AddFirst("Coding");
            var item2 = linkedList.AddAfter(item1, "Factory");
            var item3 = linkedList.AddLast("AUEB");

            linkedList.First!.Next!.Next!.Value = "Athens Uni of Econ and Bus";

            foreach (string item in linkedList)
            { 
            
                Console.WriteLine(item);
            }

            // Dictionaries

            words.Add(1, "Athens");
            words[2] = "Uni";
            words[3] = "Economics";

            words.Remove(1);

            if (words.ContainsKey(4))
            {
                Console.WriteLine("Contains 4");
            }
            else
            {
                words.Add(4, "Business");
            }

            foreach (var keyVal in words)
            {
                Console.WriteLine($"{keyVal.Key}, {keyVal.Value}");
            }*/

            // Sets
           /* var myCharSet1 = new SortedSet<char>() { 'a', 'b', 'c', 'd' };
            var myCharSet2 = new SortedSet<char>() { 'a', 'b', 'c', 'f' };

            myCharSet1.Add('x');
            myCharSet2.Remove('a');

            myCharSet1.ExceptWith(myCharSet2);

            foreach (char c in myCharSet1)
            {
                Console.Write(c + " ");
            }

            myCharSet1.UnionWith(myCharSet2);
            Console.WriteLine();
            foreach (char c in myCharSet1)
            {
                Console.Write(c + " ");
            }*/

            // Stack
            /*stack.Push("hello");
            stack.Push("World");
            stack.Push("World2");
            string s = stack.Pop();
            string s2 = stack.Peek();*/


            // Queue
            queue.Enqueue("car1");
            queue.Enqueue("car2");
            queue.Enqueue("car3");

            string car1 = queue.Dequeue();

            foreach (string car in queue)
            {
                Console.Write(car);
            }

        }
    }
}