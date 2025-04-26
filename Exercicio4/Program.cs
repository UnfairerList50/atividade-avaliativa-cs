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
            Console.WriteLine("A temperatura em Celsius é: " + ((fahrenheit - 32) * 5 / 9));
            break;
        case 3:
            return;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
}