namespace DuckSimulatorImproved.Abstractions
{

    public abstract class Duck
    {
        public Duck(string name) => Name = name;

        public string Name { get; }

        public void Swim() => MessageBox.Show(Name + " está nadando!");

        public abstract string Display();
    }
}

