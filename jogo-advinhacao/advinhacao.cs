using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("╔══════════════════════════════╗");
        Console.WriteLine("║  Bem-vindo ao Jogo de Adivinhação  ║");
        Console.WriteLine("╚══════════════════════════════╝");
        Console.WriteLine("Estou pensando em um número de 1 a 100. Tente adivinhar!");

        Random random = new Random();
        int numeroAleatorio = random.Next(1, 101);

        int tentativas = 0;
        bool acertou = false;

        while (!acertou)
        {
            Console.Write("\nDigite seu palpite: ");
            string palpiteStr = Console.ReadLine();

            if (!int.TryParse(palpiteStr, out int palpite))
            {
                Console.WriteLine("Por favor, insira um número válido.");
                continue;
            }

            tentativas++;

            if (palpite < numeroAleatorio)
            {
                Console.WriteLine("Tente um número maior.");
            }
            else if (palpite > numeroAleatorio)
            {
                Console.WriteLine("Tente um número menor.");
            }
            else
            {
                acertou = true;
                Console.WriteLine($"\nParabéns! Você acertou em {tentativas} tentativas.");
            }
        }

        Console.WriteLine("\nO jogo acabou. Obrigado por jogar!");
    }
}