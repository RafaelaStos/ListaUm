using System;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double largura, comprimento;
            Console.WriteLine("Imobiliaria");

            Console.WriteLine("Digite a largura do terreno: ");
            largura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o comprimento do terreno:");
            comprimento = Convert.ToDouble(Console.ReadLine());

            double area = 0;
            area = largura * comprimento;

            Console.WriteLine("Area total do terreno, "area);
            Console.ReadLine();
        }
    }
}
