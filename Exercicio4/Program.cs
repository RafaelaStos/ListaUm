using System;

namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius, fahrenheit;
            Console.WriteLine("Conversor de temperatura");
            Console.WriteLine("Digite a temperatura em celsius: ");
            celsius = Convert.ToDouble(Console.ReadLine());

            fahrenheit = celsius * 1.8 + 32;
            Console.WriteLine("A temperata em fahrenheit é: " + fahrenheit);
            Console.ReadLine();
        }
    }
}
