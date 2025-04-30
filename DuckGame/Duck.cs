using System;

namespace DuckGame
{
    public class Duck : Flyable, Quackable
    {
        public string nome { get; set; }

        public Duck(string nome)
        {
            Nome = nome;
        }

        public void Swin(){        }
        public void Display(){        }
    }
}
