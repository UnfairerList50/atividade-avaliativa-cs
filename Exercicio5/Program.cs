using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma palavra ou frase: ");
        string entrada = Console.ReadLine().ToLower();

        // Remove espaços e pontuações simples
        string fraseLimpa = new string(entrada.Where(c => char.IsLetter(c)).ToArray());

        // Verifica se é palíndromo
        string reverso = new string(fraseLimpa.Reverse().ToArray());

        if (fraseLimpa == reverso)
        {
            Console.WriteLine("A palavra é um palíndromo");
        }
        else
        {
            Console.WriteLine("A palavra não é um palíndromo.");
        }
    }
}
