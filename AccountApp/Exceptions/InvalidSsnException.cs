namespace AccountApp.Exceptions
{
    internal class InvalidSsnException : Exception
    {
        public InvalidSsnException(string ssn) : base("SSN: " + ssn + " is not valid")
        {

        }
    }
}
