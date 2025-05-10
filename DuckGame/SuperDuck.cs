
using System;

namespace DuckGame
{
    public class SuperDuck : Duck, IQuackable, IPower
    {
        public string Categoria { get; set; }

        public SuperDuck(string nome, string categoria) : base(nome)
        {
            Categoria = categoria;
        }

        public override void Display()
        {
            Console.WriteLine($"{Nome} é um pato supremo ({Categoria})!");
        }

        public void Quack()
        {
            Console.WriteLine("Quack: De onde eu venho o 'S' significa esperança!");
        }

        public void UsePower()
        {
            Console.WriteLine($"{Nome} atira a laser pelos olhos!");
        }
    }
}
