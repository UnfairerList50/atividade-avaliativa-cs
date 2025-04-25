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
O fatorial de um número n se dá pela multiplicação de todos os números inteiros positivos menores ou iguais a n, até 1. O programa se inicia solicitando um número ao usuário, em seguida a variável `fatorial` é inicializada em 1 e uma variável auxiliar chamada `contador` recebe o valor do número digitado. Em seguida, por meio de um laço `while`, o valor de `fatorial` é multiplicado pelo `contador`, e este é decrementado até atingir 1. Por fim, o resultado é impresso na tela.

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
Palíndromo é uma palavra ou frase que pode ser lida de frente para trás ou de trás para frente, pois o resultado é o mesmo.
O exercício solicitava um sistema capaz de verificar se uma palavra ou frase se tratava ou não de um palíndromo. 

* O programa se inicia solicitando ao usuário que digite uma sentença para que a verificação seja feita, o texto digitado é armazenada na variável do tipo string `palavra`.

```csharp
Console.WriteLine("Digite uma palavra  ou frase para verificar se é um palíndromo: ");
string palavra = Console.ReadLine();
```
Em seguida, fora criado a variável `correcao`, ela será responsável, juntamente de outras méetodos, por formatar a palavra ou frase digitada pelo usuário para um determinado padrão, evitando erros lógicos por parte do programa.

```csharp
string correcao = palavra.Replace(" ", "").ToLower().RemoverAcentos();
```

* O método `Replace` serve para substituir um carácter por outro, sua sintaxe é a seguinte: `string.Replace(char, char)`, onde, dentro do parênteses, o primeiro carácter antes da vírgula se trata do alvo da substituição e após a vírgula, o carácter que vai substituir o antigo. Nesse caso ele está alterando a string `palavra`, o alvo da substituição é qualquer espaço que uma frase digitada pelo usuário possa ter. A ideia é que todos os espaços sejam eliminados, garantindo o funcionamento correto da lógica desenvolvida.

```csharp
palavra.Replace(" ", "")
```

* Em diante temos outro método, o `ToLower()`, seu papel é simples, converter todas as letras maiúsculas em minúsculas. Alguns palíndromos, como "Ana", não seriam considerados palíndromos sem esse método, pois as letras "A" e "a" seriam considerados carácteres distintos, devido a diferença de tamanho de ambos.

```csharp
.ToLower()
```

Para fechar essa etapa, temos a função `RemoverAcentos()`. Infelizmente, em Java, não existe um método que retire a acentuação de uma string, portanto, a solução foi criar uma função capaz de fazer isso.

```csharp
RemoverAcentos();
```

* Uma nova classe pública chamada `Acentuacao` foi criada na parte inferior do código, dentro dela está a função nomeada de `RemoverAcentos`, dentro dela foi declarado uma string chamada `acento`, é importante que essa string seja acompanhada de um `this`, 


### 6. Cadastro Simples de Produtos

### 7. Soma de Números Pares de um Array

### 8. Cálculo de IMC com Classificação
IMC é uma medida que faz uma relação entre o peso e a altura de uma pessoa para determinar se ela está dentro do peso adequado. O programa se inicia solicitando o peso e altura do usuário, em seguida ele utiliza a fórmula: `peso / (altura * altura)` para calcular o IMC. Utilizando as condições `if`, `else if`,`else` e, com base no valor obtido, o programa finaliza exibindo a classificação correspondente, que pode ser `Abaixo do peso`, `Peso normal`, `Sobrepeso` ou `Obesidade`.

### 9. Jogo da Adivinhação

### 10. Lista de Tarefas (To-Do List)