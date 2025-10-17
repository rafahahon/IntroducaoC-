using System;

namespace Introdução_C_;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem vindo(a) ao sistema."); // WriteLine pula linha/ Write nao pula

        // Entrada de dados
        /* Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nOla, {nome}! Voce tem {idade} anos.");

        if(idade < 18) {
         Console.WriteLine("Voce ainda e menor de idade.");
        } else {
         Console.WriteLine("Voce ja e maior de idade.");
        } */

        // Menu
        Console.WriteLine("\nEscolha uma opcao: ");
        Console.WriteLine("1- Ver a tabuada de um numero: ");
        Console.WriteLine("2- Contar ate um numero: ");
        Console.WriteLine("3- Fibonacci: ");
        Console.WriteLine("4- Sair");
        Console.WriteLine("Digite a sua opcao: ");

        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1: // Tabuada
                Console.WriteLine("Digite um número: ");
                int tabuada = int.Parse(Console.ReadLine());
                for (int i = 1; i <= 10; i++)
                {
                    int resultado = i * tabuada;
                    Console.WriteLine($"{tabuada} * {i} = {resultado}");
                }
                break;

            case 2: // Contar 
                Console.WriteLine("Digite um número: ");
                int contar = int.Parse(Console.ReadLine());
                for (int i = 0; i <= contar; i++)
                {
                    Console.WriteLine(i);
                }
                break;

            case 3: // Fibonacci
            Console.WriteLine("Digite um número: ");
            int fibonacci = int.Parse(Console.ReadLine());
                int numero1 = 1;
                int numero2 = 1;
                int numero3 = 1;
                for (int i = 0; i <= fibonacci; i++)
                {
                    Console.WriteLine($"Sequência: {numero3}");
                    numero3 = numero1 + numero2;
                    numero2 = numero1;
                    numero1 = numero3;
                }
                break;

            case 4: // Sair
                Console.WriteLine("Adeus!");
                break;

            default: // Caso a pessoa digite nenhuma das opções
                Console.WriteLine("Escolha uma opção válida.");
                break;
        }
    }
}
