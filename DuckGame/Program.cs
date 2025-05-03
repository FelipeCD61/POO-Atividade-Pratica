using System;
using System.Linq.Expressions;

namespace DuckGame
{
    class Program
    {

        public static void Main(string[] args)
        {
            Console.Clear();
            RubberDuck patodebanheira = new RubberDuck("Pato de banheira", "Amarelo");
            patodebanheira.Display();

            //Esperar o usuário pressionar uma tecla
            Console.WriteLine("\nPressione qualquer tecla para continuar...\n");
            Console.ReadKey();

            RubberDuck patoBoracha = new RubberDuck("Pato Borracha", "Azu");
            patoBoracha.Display();
            patoBoracha.Swim();
            patoBoracha.Quack();

            //Esperar o usuário pressionar uma tecla
            Console.WriteLine("\nPressione qualquer tecla para continuar...\n");
            Console.ReadKey();

            RedHatDuck PatoRedHat = new RedHatDuck("Pato Chapéuzinho Vermelho", "Petro");
            PatoRedHat.Display();
            PatoRedHat.Swim();
            PatoRedHat.Quack();
            PatoRedHat.Fly();
            

            //Esperar o usuário pressionar uma tecla
            Console.WriteLine("\nPressione qualquer tecla para continuar...\n");
            Console.ReadKey();

            MaladesaDuck PatoMalado = new MaladesaDuck("Pato Chave", "Petro");
            PatoMalado.Display();
            PatoMalado.Quack();
            PatoMalado.Fly();
            PatoMalado.Swim();
            // switch cases = new switch()
            // {
            //     case 1:
            //         Console.WriteLine("Pato de banheira: Amarelo");
            //     //ele voa
            //     // ele nada
            //         break;
            //     case 2:
            //         Console.WriteLine("Pato Borracha: Azul");
            //         break;
            //     case 3:
            //         Console.WriteLine("Pato Chapéuzinho Vermelho: Petro");
            //         break;
            //     case 4:
            //         Console.WriteLine("Pato Chave: Petro");
            //         break;
            //     default:
            //         Console.WriteLine("voltar!");
            //         break;
                
            // }
        }
    }
}