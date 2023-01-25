namespace RegexPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular Expressions");

            Pattern objPattern = new Pattern();
            objPattern.ValidateEMail("abc");
        }
    }
}