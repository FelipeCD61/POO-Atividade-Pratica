using DuckSimulatorImproved.Abstractions;
using DuckSimulatorImproved.Interfaces;

namespace DuckSimulatorImproved.Ducks
{
    public class MallardDuck : Duck, IFlyable, IQuackable
    {
        public static string Variant => "Pato-real";

        public MallardDuck() : base(Variant) { }

        public override string Display() => "Pato-real";

        public string Fly() => Display() + " voando!";

        public string Quack() => Display() + " grasnando!";
    }
}
