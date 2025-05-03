using System;

namespace DuckGame
{
    public class RedHatDuck : Duck, IQuackable, IFlyable
    {
        public string Categoria { get; set; }

        public RedHatDuck(string nome, string categoria) : base(nome)
        {
            Categoria = categoria;
        }
        public override void Display()
        {
            Console.WriteLine($"{Nome} é um pato de borracha ({Categoria})!");
        }

        public void Fly()
        {
            Console.WriteLine($"{Nome} está voando com um chapéu vermelho!");
        }

        public void Quack()
        {
            Console.WriteLine("Quack: Já estudou hoje?");
        }
    }
}
