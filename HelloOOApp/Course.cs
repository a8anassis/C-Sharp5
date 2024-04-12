namespace HelloOOApp
{
    internal sealed class Course
    {
        public int Id { get; private set; }    
        public string? ShortTitle { get; init; }
        public string? Title { get; init; }

        public Course()
        {

        }

        public Course(int id, string? shortTitle, string? title)
        {
            Id = id;
            ShortTitle = shortTitle;
            Title = title;
        }
    }
}
