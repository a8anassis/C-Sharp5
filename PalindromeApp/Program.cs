namespace PalindromeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? s;  // s == null
            Console.WriteLine("Please insert a string to check palindrome");
            s = Console.ReadLine();

            Console.WriteLine($"{s} is palindrome: {IsPalindrome(s!)}");
        }

        public static bool IsPalindrome(string s) { 
            
            if (s is null)
            {
                return false;
            }
            bool palindrome = true;
            int length = s.Length;
            
            for (int i = 0, j = length -1; i < j; i++, j--) 
            {
                if (s[i] != s[j])
                {
                    palindrome = false;
                    break;
                }
            }
            return palindrome;
        }
    }
}