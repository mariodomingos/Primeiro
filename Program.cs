using System;

namespace PrimeiroGit
{
    class Program
    {
        static void Main(string[] args)
        {
        //Declaração das variaveis para guardar valores
        //que o usuario entrará
        double valor1, valor2, resultado;
        Console.WriteLine("digite um valor");
        valor1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Entre com outro valor");
        valor2 = double.Parse (Console.ReadLine());

        resultado = valor1+valor2;

        Console.WriteLine("O resultado da soma é: "+resultado");
        

        
        
        }
    }
}
