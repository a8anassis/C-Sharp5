namespace GradesApp
{

    /// <summary>
    /// Λαμβάνει ως είσοδο δύο ακεραίους, το σύνολο
    /// των βαθμών και το πλήθος των μαθημάτων και υπολογίζει
    /// τονμέσο όρο και αντίσοιχα εμφανίζει τον μέσο όρο 
    /// και ένα χαρακτηρισμό (Άριστα, Πολύ καλά, Καλά, Αποτυχία).
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            //int gradesSum = 0;
            //int gradesCount = 0;
            int average = 0;

            Console.WriteLine("Please enter grades sum and grades count");
            if (!int.TryParse(Console.ReadLine()!, out int totalMarks)) {
                Console.WriteLine("Error in read");
            }

            if (totalMarks <= 0)
            {
                Environment.Exit(1);
            }

            if (!int.TryParse(Console.ReadLine()!, out int coursesCount))
            {
                Console.WriteLine("Error in read");
            }


            if (coursesCount <= 0)
            {
                Console.WriteLine("Grades count can not be negative or zero");
                Environment.Exit(1);
            }

            average = totalMarks / coursesCount;

            if (average > 10)
            {
                Console.WriteLine("Average must not be greater than 10");
                Environment.Exit(1);
            }

            switch (average)
            {
                case >= 8:
                    Console.WriteLine($"Excellent: {average:N2}");
                    break;

                case >= 6:
                    Console.WriteLine($"Very Good: {average:N2}");
                    break;

                case >= 5:
                    Console.WriteLine($"Good: {average:N2}");
                    break;

                default:
                    Console.WriteLine($"Failure: {average:N2}");
                    break;
            }

            //if (average >= 8)
            //{
            //    Console.WriteLine($"Excellent: {average:N2}");
            //}
            //else if (average >= 6)
            //{
            //    Console.WriteLine($"Very Good: {average:N2}");
            //}
            //else if (average >= 5)
            //{
            //    Console.WriteLine($"Good: {average:N2}");
            //}
            //else
            //{
            //    Console.WriteLine($"Failure: {average:N2}");
            //}
        }
    }
}