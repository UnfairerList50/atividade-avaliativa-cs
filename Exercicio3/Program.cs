Console.Write("Digite um número: ");
int num = Convert.ToInt32(Console.ReadLine());
int fatorial = 1;

for (int i = 1; i <= num; i++)
{
    fatorial *= i;
}

Console.WriteLine("O Fatorial de " + num + " é " + fatorial);