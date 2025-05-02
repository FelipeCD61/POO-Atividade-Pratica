using System;

namespace DuckGame
{
    public class RubberDuck : Duck, IQuackable
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
            Console.WriteLine("Quack");
        }
    }
}
