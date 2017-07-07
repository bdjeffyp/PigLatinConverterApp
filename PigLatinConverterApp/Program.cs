using System;

namespace PigLatinConverterApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string message = "";
            PigLatinConverter converter = new PigLatinConverter();

            Console.Write("Give me a message to convert: ");
            message = Console.ReadLine();

            Console.WriteLine(converter.Convert(message));

		}
    }
}
