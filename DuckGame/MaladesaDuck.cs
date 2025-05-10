using System;

namespace DuckGame
{
    public class MaladesaDuck : Duck, IQuackable, IFlyable, IPower
    {
        public string Categoria { get; set; }

        public MaladesaDuck(string nome, string categoria) : base(nome)
        {
            Categoria = categoria;
        }
                public override void Display()
        {
            Console.WriteLine($"{Nome} é um pato malado ({Categoria})!");
        }
        public void Fly()
        {
            Console.WriteLine($"{Nome} está voando malado de mais!");
        }
        public void Quack()
        {
            Console.WriteLine("Quack Truta");
        }

        public void UsePower()
        {
            Console.WriteLine($"{Nome} usa o Poder do Maladeza! Ele fica malado!");
        }
    }
}
