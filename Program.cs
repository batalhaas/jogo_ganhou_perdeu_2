using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo ao Jogo do Acertou: Perdeu! - Versão 2.0");

        // Gerando automaticamente o número oculto
        Random random = new Random();
        int numeroOculto = random.Next(1, 101); // Número entre 1 e 100

        // Solicitando a quantidade de jogadores
        Console.Write("Digite a quantidade de jogadores: ");
        int quantidadeJogadores = int.Parse(Console.ReadLine());

        bool acertou = false;
        int jogadorAtual = 1;

        while (!acertou)
        {
            Console.Write($"Jogador {jogadorAtual}, digite seu palpite: ");
            int palpite = int.Parse(Console.ReadLine());

            if (palpite == numeroOculto)
            {
                Console.WriteLine($"Acertou! Jogador {jogadorAtual} perdeu!");
                acertou = true;
            }
            else
            {
                Console.WriteLine("Errado! Tente novamente.");
                jogadorAtual = jogadorAtual % quantidadeJogadores + 1;
            }
        }
    }
}