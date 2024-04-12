namespace HelloOOApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student alice = new Student();
            //Student bob = new();            // C# 9.0
            var costas = new Student();     // C# 3.0

            alice.Id = 1;
            alice.Firstname = "Alice";
            alice.Lastname = "W.";


            Console.WriteLine($"{alice.Id}");
            Console.WriteLine($"{alice.Firstname}");
            Console.WriteLine($"{alice.Lastname}");

            Student bob = new()
            {
                Id = 2,
                Firstname = "Bob",
                Lastname = "D."
            };

            Student dylan = new Student(2, "Dylan", "S.");

            Course course = new Course(1, "Java", "Java Programming");
            Course course1 = new()
            {
                Id = 4,
                ShortTitle = "SQL",
                Title = "Structured Query Language"
            };

            //course.Title = " ";

            School school1 = new(1, "IEK Αγ. Αναργύρων", SchoolType.IEK);
            School school2 = new(1, "IEK Αγ. Αναργύρων", SchoolType.IEK);

            if (school1 == school2) {
                Console.WriteLine("EQUAL");
            }
            else
            {
                Console.WriteLine("NOT EQUAL");
            }

            school2.Id = 3;





        }
    }
}