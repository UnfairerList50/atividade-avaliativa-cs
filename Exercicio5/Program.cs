using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma palavra ou frase para verificar se é um palíndromo: ");
        string palavra = Console.ReadLine();

        string correcao = palavra.Replace(" ", "").ToLower().RemoverAcentos();

        string reverso = "";

        for (int i = correcao.Length - 1; i >= 0; i--)
        {
            reverso += correcao[i];
        }

        if (correcao == reverso)
        {
            Console.WriteLine($"{palavra} é um palíndromo");
        }
        else
        {
            Console.WriteLine($"{palavra} não é um palíndromo");
        }
    }
}

public static class Acentuacao
{
    public static string RemoverAcentos(this string acento)
    {
        return acento.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("â", "a")
                     .Replace("é", "e").Replace("ê", "e")
                     .Replace("í", "i")
                     .Replace("ó", "o").Replace("ô", "o").Replace("õ", "o")
                     .Replace("ú", "u")
                     .Replace("ç", "c");
    }
}
