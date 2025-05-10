
using System;

namespace DuckGame
{
    public class SamuraiDuck : Duck, IQuackable, IFlyable, IPower
    {
        public string Categoria { get; set; }

        public SamuraiDuck(string nome, string categoria) : base(nome)
        {
            Categoria = categoria;
        }

        public override void Display()
        {
            Console.WriteLine($"{Nome} é um pato samurai ({Categoria})!");
        }

        public void Quack()
        {
            Console.WriteLine("Quack: Shhh... concentração total!");
        }

        public void Fly()
        {
            Console.WriteLine($"{Nome} voa cortando o vento como uma katana!");
        }

        public void UsePower()
        {
            Console.WriteLine($"{Nome} usa o Grito da Katana! Uma onda cortante atravessa o ar!");
        }
    }
}
