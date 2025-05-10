
using System;

namespace DuckGame
{
    public class VikingDuck : Duck, IQuackable, IFlyable, IPower
    {
        public string Categoria { get; set; }

        public VikingDuck(string nome, string categoria) : base(nome)
        {
            Categoria = categoria;
        }

        public override void Display()
        {
            Console.WriteLine($"{Nome} é um pato viking ({Categoria})!");
        }

        public void Quack()
        {
            Console.WriteLine("Quack: Por Asgard!");
        }

        public void Fly()
        {
            Console.WriteLine($"{Nome} voa como um trovão!");
        }

        public void UsePower()
        {
            Console.WriteLine($"{Nome} invoca o Martelo do Thor! Um estrondo ecoa pelos céus!");
        }
    }
}
