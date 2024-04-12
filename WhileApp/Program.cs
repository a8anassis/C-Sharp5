namespace WhileApp
{
    /// <summary>
    /// Προσθέτει τους 10 πρώτους ακεραίους
    /// από το 1 έως το 10 με επαναληπτικό
    /// τρόπο (while) και εμφανίζει το αποτέλεσμα.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i = 1;

            while (i <= 10)
            {
                sum += i++;
            }

            Console.WriteLine($"Sum = {sum}");
        }
    }
}