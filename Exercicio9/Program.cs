using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int numAleatorio = random.Next(1, 101);
        int tentativa, tentativas = 0;

        Console.WriteLine("Adivinhe o número entre 1 e 100");

        do
        {
            Console.Write("Digite sua tentativa: ");
            tentativa = Convert.ToInt32(Console.ReadLine());
            tentativas++;

            if (tentativa < numAleatorio)
                Console.WriteLine("O número gerado é maior!\n");
            else if (tentativa > numAleatorio)
                Console.WriteLine("O número gerado é menor!\n");

        } while (tentativa != numAleatorio);

        Console.WriteLine("Você acertou em " + tentativas + " tentativas.");
    }
}
