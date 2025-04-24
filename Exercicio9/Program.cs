using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 101);
        int tentativa, tentativas = 0;

        Console.WriteLine("Adivinhe o número entre 1 e 100");

        do
        {
            Console.Write("Digite sua tentativa: ");
            tentativa = Convert.ToInt32(Console.ReadLine());
            tentativas++;

            if (tentativa < numeroSecreto)
                Console.WriteLine("O número gerado é maior!");
            else if (tentativa > numeroSecreto)
                Console.WriteLine("O número gerado é menor!");

        } while (tentativa != numeroSecreto);

        Console.WriteLine("Você acertou em " + tentativas + " tentativas.");
    }
}
