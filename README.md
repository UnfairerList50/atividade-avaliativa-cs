# Atividade avaliativa C#

## Integrantes da equipe
* Jorge Fernando Kozloski de Aquino
* Juan Bernando Ferreira
* Northon Henrique dos Santos

## Resolução e questões detalhadas
As questões 4 e 5 foram escolhidas para serem detalhadas.

### 1. Validador de Senhas Fortes
Após a entrada do usuário, é feita uma verificação por meio de métodos dentro de um laço `foreach` se cada caractere satisfaz as condições para que a senha seja aceita. Se houver erros, estes são armazenados em um vetor e exibidos ao usuário. Caso contrário, o programa finaliza com uma mensagem de sucesso.

### 2. Tabuada Completa com Laço
O programa inicia solicitando a entrada de um número. Então, por meio de um laço `for`, é imprimido a multiplicação desse número, de 1 a 10.

### 3.  Cálculo de Fatorial com `while`

### 4. Conversor de Temperaturas com Menu (questão detalhada)
Neste exercício, é calculado a conversão de temperaturas nas escalas Celsius e Fahrenheit.  
O programa inicia exibindo um menu enumerado dentro de um laço infinito, com as opções Celsius para Fahrenheit, Fahrenheit para Celsius e Sair. A escolha do usuário é salva na variável `escolha` pelo comando `Convert.ToInt32(Console.ReadLine())`, que converte a string lida do teclado para o tipo inteiro.  
    
```csharp
while (true)
{
    Console.WriteLine("\nCONVERSOR DE TEMPERATURA");
    Console.WriteLine("1. Celsius para Fahrenheit");
    Console.WriteLine("2. Fahrenheit para Celsius");
    Console.WriteLine("3. Sair");
    int escolha = Convert.ToInt32(Console.ReadLine());
```
Depois, a condicional `switch` recebe a escolha do usuário e direciona o fluxo de execução para a conversão desejada:

* Na conversão de Celsius para Fahrenheit, o programa solicita a temperatura , tratando a entrada do teclado da mesma forma como detalhado antes. Depois, é exibido ao usuário a temperatura convertida por meio da fórmula `(celsius * 1.8) + 32)`, em seguida retornando ao laço `While` no início do programa.

    ```csharp
    switch (escolha)
    {

        case 1:
            Console.Write("Digite a temperatura (°C): ");
            int celsius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A temperatura em Fahrenheit é: " + ((celsius * 1.8) + 32));
            break;
    ```

* A conversão de Fahrenheit para Celsius segue a mesma lógica, apenas usando outra fórmula: `(fahrenheit - 32) * 5 / 9)`.

    ```csharp
        case 2:
            Console.Write("Digite a temperatura (°F): ");
            int fahrenheit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A temperatura em Fahrenheit é: " + ((fahrenheit - 32) * 5 / 9));
            break;
    ```

* Por fim, a opção Sair termina a função `Main` e encerra o programa.

    ```csharp
        case 3:
            return;
    ```

Qualquer entrada fora do intervalo do menu exibe uma mensagem de erro.

```csharp
default:
    Console.WriteLine("Opção inválida. Tente novamente.");
    break;
    }
}
```

### 5. Verificador de Palíndromos (questão detalhada)
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

### 6. Cadastro Simples de Produtos

### 7. Soma de Números Pares de um Array

### 8. Cálculo de IMC com Classificação

### 9. Jogo da Adivinhação

### 10. Lista de Tarefas (To-Do List)