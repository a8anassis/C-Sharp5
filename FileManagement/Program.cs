using FileManagement.Model;

namespace FileManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DLList<char>? fileList = new();
            //StreamReader? reader;
            int totalCharsCount = 0;
            char ch;
            string filePath = @"C:\tmp\file.txt";
            GenericNode<char>? node;
            int ord;

            try
            {
                using StreamReader? reader = new StreamReader(filePath);

                while ((ord = reader.Read()) != -1)
                {
                    ch = (char)ord;
                   
                    if (Convert.ToInt32(ch) == 13 || Convert.ToInt32(ch) == 10) // CR or LF
                    {
                        reader.Read();
                        continue;
                    }

                    node = fileList.GetPosition(ch);
                    if (node == null)
                    {
                        fileList.InsertLast(ch);
                    } else
                    {
                        fileList.IncreaseCount(node);
                    }

                    totalCharsCount++;
                }
                Console.WriteLine("Print sorted by value ascending");
                fileList.SortByValueAsc();
                fileList.Traverse(totalCharsCount);
            } catch (IOException e)
            {
                Console.Error.WriteLine(e.StackTrace);
            }
        }
    }
}