using System;

namespace Execicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double pao = 0.12;
            const double broa = 1.50;

            double totalPaes, totalBroas, total = 0, poupanca;

            Console.Write("Quantidade de pães vendidos do dia: ");
            int qtdPaes = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nQuantidade de broas vendidas do dia: ");
            int qtdBroas = Convert.ToInt32(Console.ReadLine());

            totalPaes = qtdPaes * pao;
            totalBroas = qtdBroas * broa;

            total = totalPaes + totalBroas;
            poupanca = total * 0.1;

            Console.WriteLine("O total vendido do dia: R$" + total);
            Console.WriteLine("\nTotal a ser guardado na poupança: R$" + poupanca);
            Console.ReadLine();
        }
    }
}
