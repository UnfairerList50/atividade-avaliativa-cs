using System;

class Program
{
    static void Main()
    {
        int somaPares = 0;
        int num = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Digite um número (" + (i + 1) + "/10): ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                somaPares += num;
            }
        }

        Console.WriteLine("A soma dos números pares é: " + somaPares);
    }
}
