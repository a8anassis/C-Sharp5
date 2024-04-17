namespace LinqApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers =  { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            // Method Syntax - Fluent API
            // 1. Filtering
            var evenNumbers = numbers.Where(n => n % 2 == 0);
            Console.WriteLine(string.Join(", ", evenNumbers));

            // 2. Map Squares
            var squares = numbers.Select(n => n * n);
            foreach (var square in squares)
            {
                Console.Write(square + " ");
            }

            // 3. Sum
            var sum = numbers.Sum();
            Console.WriteLine("Sum" + sum);

            // 4. Min
            var min = numbers.Min();
            Console.WriteLine("Min" + min);

            // 5. Max
            var max = numbers.Max();
            Console.WriteLine("Max" + max);

            // 6. Average
            var average = numbers.Average();
            Console.WriteLine("Average" + average);

            // 7. Any + predicate
            var anyGE10 = numbers.Any(n => n >= 10);
            Console.WriteLine("Any grater equal 10: " + anyGE10);

            // 8. All + Predicate
            var allGT0 = numbers.All(n => n > 0);
            Console.WriteLine("All grater than 0: " + allGT0);

            var odds = numbers.Where(n => n % 2 != 0).Select(n => n * 2);

            foreach (int i in odds)
            {
                Console.WriteLine(i);
            }

            var list = numbers.Where(n => n % 2 != 0).Select(n => n * 2).ToList();


            // Query Syntax

            var allNumbers = from num in numbers select num;

            foreach (int number in allNumbers)
            {
                Console.WriteLine(number + " ");
            }

            var myOdds = from num in numbers
                       where (num % 2) != 0
                       select num;

            foreach (int num in myOdds)
            {
                Console.WriteLine(num);
            }

            List<int> evensList = (from num in numbers 
                                   where num % 2 == 0 
                                   orderby num descending
                                   select num).ToList();

            evensList.ForEach(el => Console.WriteLine(el));
        }
    }
}