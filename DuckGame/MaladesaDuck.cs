using System;

namespace DuckGame
{
    public class MaladesaDuck : Duck, IQuackable, IFlyable
    {
        public string Categoria { get; set; }

        public MaladesaDuck(string nome, string categoria) : base(nome)
        {
            Categoria = categoria;
        }

        public void Fly()
        {
            Console.WriteLine($"{Nome} está voando malado de mais!");
        }
        public override void Display()
        {
            Console.WriteLine($"{Nome} é um pato de borracha ({Categoria})!");
        }
        public void Quack()
        {
            Console.WriteLine("Quack Truta");
        }
    }
}
