using System;
using System.Collections.Generic;

namespace DuckGame
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Duck> Ducks = new List<Duck>
            {
                new RubberDuck("Pato de Borracha", "Borrachudo"),
                new RedHatDuck("Pato Chapeuzinho Vermelho", "Voador"),
                new MaladesaDuck("Pato Chave", "Do Verde"),
                new SamuraiDuck("Samurai Jack", "Samurai"),
                new VikingDuck("Thor Duck", "Viking"),
                new SuperDuck("Super Pato", "Super")
            };

            int opcao = -1;

            while (opcao != 0)
            {
                Console.WriteLine("\nEscolha um pato para ver suas habilidades:");
                for (int i = 0; i < Ducks.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {Ducks[i].Nome}");
                }
                Console.WriteLine("0. Sair");

                Console.Write("Digite sua opção: ");
                if (int.TryParse(Console.ReadLine(), out opcao))
                {
                    if (opcao > 0 && opcao <= Ducks.Count)
                    {
                        Console.WriteLine($"\nVocê escolheu o:");
                        Ducks[opcao - 1].Display();
                        Ducks[opcao - 1].Swim();

                        if (Ducks[opcao - 1] is IQuackable quackable)
                            quackable.Quack();

                        if (Ducks[opcao - 1] is IFlyable flyable)
                            flyable.Fly();

                        if (Ducks[opcao - 1] is IPower power)
                            power.UsePower();

                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                    }
                    else if (opcao != 0)
                    {
                        Console.WriteLine("Opção inválida. Tente novamente.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, insira um número.");
                }
            }
            Console.WriteLine("Programa encerrado.");
        }
    }
}