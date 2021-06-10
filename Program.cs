using System;

namespace P7_Stringspractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string value1 = "hola";
            string value2 = value1.ToUpper();
            Console.WriteLine($"\"{value1}\" -> \"{value2}\"");

            value1 = "John, Peter, Charlie";
            string [] value2array = value1.Split(", ");
            Console.WriteLine($"\"{value1}\" -> [\"{value2array[0]}\", \"{value2array[1]}\", \"{value2array[2]}\"] ");

            value1 = "Pizza";
            char[] charArray = value1.ToCharArray();
            Array.Reverse( charArray );
            value2 = new string( charArray );
            Console.WriteLine($"\"{value1}\" -> \"{value2}\"");

            value1 = "Tacos > Hamburguesa";
            value2 = value1.Replace(">", "&gt;");
            Console.WriteLine($"\"{value1}\" -> \"{value2}\"");

            value1 = "Pizza < Hamburguesa";
            value2 = value1.Replace("<", "&gt;");
            Console.WriteLine($"\"{value1}\" -> \"{value2}\"");

            value1 = "Azul, Verde, Morado";
            value2 = value1.Replace(" ", "");
            value2array = value2.Split(",");
            Console.WriteLine($"\"{value1}\" -> \"{value2array[(value2array.Length-1)]}\"");

            value1 = " ave, banco, comida, duda, ejercicio, fuente, girasol";
            value2 = value1.Replace(" ", "");
            value2 = value2.ToUpper();
            value2 = value2.Replace(",", ";");
            value2array = value2.Split(";");
            Array.Reverse(value2array);
            value2 = string.Join(";", value2array);
            string substring = value2.Substring(8, 35);
            Console.WriteLine($"\"{value1}\" -> {substring}");
        }
    }
}
