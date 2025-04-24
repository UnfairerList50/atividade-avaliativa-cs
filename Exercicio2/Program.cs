Console.Write("Digite um número: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(num + " x " + i + " = " + num * i);
}