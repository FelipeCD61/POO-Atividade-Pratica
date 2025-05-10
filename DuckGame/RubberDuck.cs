using System;

namespace DuckGame
{
    public class RubberDuck : Duck, IQuackable, IPower
    {
        public string Categoria { get; set; }

        public RubberDuck(string nome, string categoria) : base(nome)
        {
            Categoria = categoria;
        }

        public override void Display()
        {
            Console.WriteLine($"{Nome} é um pato de borracha ({Categoria})!");
        }
        public void Quack()
        {
            Console.WriteLine("Quack: Eu vou ser o rei dos piratas!");
        }

        public void UsePower()
        {
            Console.WriteLine($"{Nome} usa o Poder do Borracha! Ele se estica!");
        }
    }
}
