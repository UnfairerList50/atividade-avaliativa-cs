Console.WriteLine("Informe um número: ");
int num = Convert.ToInt32(Console.ReadLine());

int contador = num;
int fatorial = 1;

while(contador > 1)
{
    fatorial *= contador;
    contador--;
}

Console.WriteLine($"{num}! = {fatorial}");