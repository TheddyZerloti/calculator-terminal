using System;
using System.Collections;
using System.Runtime.InteropServices.Marshalling;

internal class Program
{
    private static void Main(string[] args)
    {

        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("Qual operação matemática deseja executar?");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Divisão");
        Console.WriteLine("4 - Multiplicação");

        Console.WriteLine("--------------------------------");
        Console.WriteLine("Selecione a opção desejada: ");

        short res = short.Parse(Console.ReadLine());

        switch(res)
        {
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Divisao(); break;
            case 4: Multiplicacao(); break;
            default: Menu(); break;
        
        }


    }

    static void Soma()
    {
    Console.Clear();
        Console.WriteLine("Digite o Primeiro Valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o Segundo Valor: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = v1 + v2;

        // Console.WriteLine("O resultado da soma é: " + resultado);
        Console.WriteLine($"O resultado da soma é: {resultado}");
        // Console.WriteLine($"O resultado da soma é: {v1 + v2}");
        // Console.WriteLine("O resultado da soma é: " + (v1 + v2));

        Console.ReadKey();
        Menu();
    }

    static void Subtracao()
    {
        Console.Clear();


        Console.WriteLine("Digite o Primeiro Valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o Segundo Valor: ");
        float v2 = float.Parse(Console.ReadLine());
        
        Console.WriteLine("");

        float resultado = v1 - v2;

        Console.WriteLine($"O Resultado da subtração é {resultado}");

        Console.ReadKey();

        Menu();



    }

    static void Divisao()
    {
        Console.Clear();

        Console.WriteLine("Digite o Primeiro Valor:");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o Segundo Valor:");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = v1/v2;
        Console.WriteLine($"O rescultado da divisão é: {resultado}");

        Console.ReadKey();

        Menu();
      
    }

    static void Multiplicacao()
    {

        Console.Clear();

        Console.WriteLine("Digite o Primeiro Valor:");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o Segundo Valor:");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = v1*v2;
        Console.WriteLine($"O rescultado da Multiplicação é: {resultado}");

        Console.ReadKey();

        Menu();


    }
}