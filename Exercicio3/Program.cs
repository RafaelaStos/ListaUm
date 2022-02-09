using System;

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade, diasdevida;

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            diasdevida = idade * 365;

            Console.WriteLine(nome + ", você já viveu " + diasdevida + " dias");
            Console.ReadLine();

        }
    }
}
