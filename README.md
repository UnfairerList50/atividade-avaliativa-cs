# Atividade avaliativa C#

## Integrantes da equipe
* Jorge Fernando Kozloski de Aquino
* Juan Bernando Ferreira

## Questões detalhadas

### 4. Conversor de Temperaturas com Menu
Crie um menu com as opções:  
1 - Celsius para Fahrenheit  
2 - Fahrenheit para Celsius  
3 - Sair  
Use switch e while para manter o menu ativo até o usuário sair.

Esse é `um trecho de código` no meio de uma frase.
    
```csharp
while (true)
{
    Console.WriteLine("\nCONVERSOR DE TEMPERATURA");
    Console.WriteLine("1. Celsius para Fahrenheit");
    Console.WriteLine("2. Fahrenheit para Celsius");
    Console.WriteLine("3. Sair");
    int escolha = Convert.ToInt32(Console.ReadLine());

    switch (escolha)
    {
        case 1:
            Console.Write("Digite a temperatura (°C): ");
            int celsius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A temperatura em Fahrenheit é: " + ((celsius * 1.8) + 32));
            break;
        case 2:
            Console.Write("Digite a temperatura (°F): ");
            int fahrenheit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A temperatura em Fahrenheit é: " + ((fahrenheit - 32) * 5 / 9));
            break;
        case 3:
            return;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
}
```

### 5. Verificador de Palíndromos
Peça ao usuário para digitar uma palavra ou frase e verifique se ela é um palíndromo (lê-se igual de frente para trás e de trás para frente, desconsiderando espaços e acentos).

Esse é `um trecho de código` no meio de uma frase.

```csharp
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
```