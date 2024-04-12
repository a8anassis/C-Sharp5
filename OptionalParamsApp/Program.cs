namespace OptionalParamsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetDateTime(2024, 4, 5, 19, 56, 10, 10));
            Console.WriteLine(GetDateTime());
            
        }

        public static DateTime GetDateTime(int year = 2024, int month = 1, int day = 1, 
            int hour = 00, int min = 00, int sec = 00, int mill = 00)
        {
            return new DateTime(year, month, day, hour, min, sec, mill, DateTimeKind.Utc);
        }
    }
}