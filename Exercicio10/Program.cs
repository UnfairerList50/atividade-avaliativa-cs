using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> tarefas = new List<string>();
        List<bool> concluidas = new List<bool>();
        int opcao;

        do
        {
            Console.WriteLine("\nLISTA DE TAREFAS");
            Console.WriteLine("\t1 - Adicionar tarefa");
            Console.WriteLine("\t2 - Marcar como concluída");
            Console.WriteLine("\t3 - Mostrar todas as tarefas");
            Console.WriteLine("\t4 - Sair");
            Console.Write("\nDigite sua opção: ");
            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite a tarefa: ");
                    tarefas.Add(Console.ReadLine());
                    concluidas.Add(false);
                    break;
                case 2:
                    Console.Write("Digite o número da tarefa concluída: ");
                    int num = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (num >= 0 && num < concluidas.Count)
                    {
                        concluidas[num] = true;
                    }
                    else
                    {
                        Console.WriteLine("Número inválido!");
                    }
                    break;
                case 3:
                    Console.WriteLine("\nTarefas:");
                    for (int i = 0; i < tarefas.Count; i++)
                    {
                        string status = concluidas[i] ? "[X]" : "[ ]";
                        Console.WriteLine($"\t{i + 1}. {status} {tarefas[i]}");
                    }
                    break;
            }
        } while (opcao != 4);
    }
}
