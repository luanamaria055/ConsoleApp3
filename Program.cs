//using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Números pares no intervalo [0, 20] em ordem crescente:");

        int numero = 0; // Começamos do 0

        while (numero <= 20) // Enquanto o número for menor ou igual a 20
        {
            Console.WriteLine(numero); // Imprime o número par atual
            numero += 2; // Incrementa para o próximo número par
        }

        Console.WriteLine("Fim do intervalo.");
        Console.ReadLine(); // Para manter a janela aberta no Visual Studio
    }
}
