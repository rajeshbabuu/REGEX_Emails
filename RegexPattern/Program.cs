namespace RegexPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular Expressions");

            Console.Write("Enter an EMail Address: ");
            Console.Write("(Format for EMail Address ==> abc.xyz@bridgelabz.co.in, where abc, bridgelabz and co are mandatory): ");
            string userInput = Console.ReadLine();

            Pattern objPattern = new Pattern();
            objPattern.ValidateEMail(userInput);
            Console.ReadLine();
        }
    }
}