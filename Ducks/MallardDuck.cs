using DuckSimulatorImproved.Abstractions;
using DuckSimulatorImproved.Interfaces;

namespace DuckSimulatorImproved.Ducks
{
    public class MallardDuck : Duck, IFlyable, IQuackable
    {
        public static string Variant => "Pato-real";

        public MallardDuck() : base(Variant) { }

        public override string Display() => "Pato-real";

        public void Fly() => MessageBox.Show(Display() + " voando!");

        public void Quack() => MessageBox.Show(Display() + " grasnando!");
    }
}
