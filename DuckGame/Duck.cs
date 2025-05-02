namespace DuckGame
{
    public abstract class Duck
    {
        public string Nome { get; set; }

        public Duck(string nome)
        {
            Nome = nome;
        }

        public void Swim()
        {
            Console.WriteLine($"{Nome} está nadando...");
        }

        public abstract void Display();
    }
}