using System;

namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double aumento = 0.15;
            const double impostos = 0.08;

            double salarioAtual, salarioAjustado, salarioFinal;

            Console.Write("Digite o seu salário atual: ");
            salarioAtual = Convert.ToDouble(Console.ReadLine());

            salarioAjustado = salarioAtual + salarioAtual * aumento;

            salarioFinal = salarioAjustado - salarioAjustado * impostos;

            Console.Write("Saralio inicial: R$");
            Console.WriteLine("O salário com ajuste: R$" + salarioAjustado);
            Console.WriteLine("O salário final é: R$" + salarioFinal);
            Console.ReadLine();
        }
    }
}
