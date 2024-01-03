using System;

class Program
{
    static void AdicionarJogo(int indice, string[] nomesDosJogos)
    {
        for (int i = 0; i < indice; i++)
        {
            nomesDosJogos[i] = Console.ReadLine();
        }
    }

    static void Main()
    {
        Console.WriteLine("Bem-vindo ao Catálogo de Jogos!");

        Console.Write("Quantos jogos deseja adicionar? ");
        int quantidadeJogos = int.Parse(Console.ReadLine());

        // Inicializa o array com base na quantidade informada pelo usuário:
        string[] nomesJogos = new string[quantidadeJogos];

        // Loop para adicionar jogos conforme a quantidade especificada:
        Console.WriteLine($"\nDigite os nomes dos jogos:\n(São {quantidadeJogos}!)");
        AdicionarJogo(quantidadeJogos, nomesJogos);

        Console.WriteLine("\nResumo da adição de jogos:");
        ExibirResumoAdicaoJogos(quantidadeJogos, nomesJogos);
    }

    static void ExibirResumoAdicaoJogos(int quantidadeJogos, string[] nomes)
    {
        Console.WriteLine($"Foram adicionados {quantidadeJogos} jogos ao catálogo:");
        for (int i = 0; i < quantidadeJogos; i++)
        {
            Console.Write($"{nomes[i]}");
            if (i < quantidadeJogos - 1)
            {
                Console.Write(", ");
            }
            else
            {
                Console.Write(".");
            }
        }
    }
}
