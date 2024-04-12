namespace IgnorePositivesApp
{
    /// <summary>
    /// Λαμβάνει διαδοχικά ακεραίους από τον
    /// χρήστη μέσα σε μια while μέχρι ο χρήστης
    /// να δώσει 0 και μετράει μόνο τους αρνητικούς
    /// ενώ αγνοεί τους θετικούς (>= 0).
    /// 
    /// Και εκτυπώνει το αποτέλεσμα.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int negativesCount = 0;
            
            try
            {
                do
                {
                    Console.WriteLine("Please insert a num");
                    if (num < 0) negativesCount++;
                } while ((num = int.Parse(Console.ReadLine()!)) != 0);

                Console.WriteLine($"Negatives count: {negativesCount}");
            } catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}