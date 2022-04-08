using System;

namespace CIValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            CIVAL validator = new CIVAL();
            String ci = Console.ReadLine();
            Boolean valid = validator.ValidateCI(ci);
            Console.WriteLine(valid);

        }
    }
}
