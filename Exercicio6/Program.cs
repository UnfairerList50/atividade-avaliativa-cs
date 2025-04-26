using System;
using System.Collections.Generic;

class Produto
{
    public string Nome;
    public double Preco;
    public int Quantidade;

    public double ValorTotal()
    {
        return Preco * Quantidade;
    }
}

class Program
{
    static void Main()
    {
        List<Produto> produtos = new List<Produto>();

        for (int i = 0; i < 3; i++)
        {
            Produto p = new Produto();

            Console.Write("Nome do produto: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            p.Preco = Convert.ToDouble(Console.ReadLine());

            Console.Write("Quantidade: ");
            p.Quantidade = Convert.ToInt32(Console.ReadLine());

            produtos.Add(p);
        }

        Console.WriteLine("\nProdutos cadastrados:");
        foreach (var p in produtos)
        {
            Console.WriteLine(p.Nome + " - Valor total em estoque: " + p.Quantidade * p.Preco + " reais.");
        }
    }
}
